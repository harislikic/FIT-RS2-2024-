import 'package:flutter/material.dart';
import 'package:infinite_scroll_pagination/infinite_scroll_pagination.dart';
import 'package:vroom_app/components/LoginButton.dart';
import 'package:vroom_app/components/shared/ToastUtils.dart';
import 'package:vroom_app/services/AuthService.dart';
import '../components/MyAutomobileAdsCard.dart';
import '../models/automobileAd.dart';
import '../services/AutomobileAdService.dart';
import 'package:vroom_app/main.dart' show routeObserver;

class MyAutomobileAdsScreen extends StatefulWidget {
  const MyAutomobileAdsScreen({Key? key}) : super(key: key);

  @override
  _MyAutomobileAdsScreenState createState() => _MyAutomobileAdsScreenState();
}

class _MyAutomobileAdsScreenState extends State<MyAutomobileAdsScreen>
    with RouteAware {
  final AutomobileAdService _automobileAdService = AutomobileAdService();
  static const _pageSize = 25;

  final PagingController<int, AutomobileAd> _pagingController =
      PagingController(firstPageKey: 0);

  String _selectedTab = 'active';

  @override
  void initState() {
    super.initState();
    _pagingController.addPageRequestListener((pageKey) {
      _fetchPage(pageKey);
    });
  }

  Future<bool> _checkIfLoggedIn() async {
    final userId = await AuthService.getUserId();
    return userId != null;
  }

  bool _isFetchingPage = false;

  Future<void> _fetchPage(int pageKey) async {
    if (_isFetchingPage) return;

    _isFetchingPage = true;
    final userId = await AuthService.getUserId();
    try {
      final myAutomobileAds = await _automobileAdService.fetchUserAutomobiles(
        userId: userId.toString(),
        page: pageKey,
        pageSize: _pageSize,
        status: _selectedTab == 'highlighted' ? null : _selectedTab,
        IsHighlighted: _selectedTab == 'highlighted',
      );

      final isLastPage = myAutomobileAds.length < _pageSize;
      if (isLastPage) {
        _pagingController.appendLastPage(myAutomobileAds);
      } else {
        final nextPageKey = pageKey + 1;
        _pagingController.appendPage(myAutomobileAds, nextPageKey);
      }
    } catch (error) {
      print("Fetch Page Error: $error");
      _pagingController.error = error;
    } finally {
      _isFetchingPage = false;
    }
  }

  Future<void> _removeAutomobile(int automobileId) async {
    final headers = await AuthService.getAuthHeaders();

    try {
      await _automobileAdService.removeAutomobile(automobileId, headers);
      _pagingController.refresh();

      ToastUtils.showToast(message: "Oglas je uspešno obrisan.");
    } catch (error) {
      ToastUtils.showErrorToast(
          message: "Greška prilikom zavrsavanja oglasa: $error");
    }
  }

  Future<void> _markAsDone(int automobileId) async {
    try {
      await _automobileAdService.markAsDone(automobileId);
      _pagingController.refresh();
    } catch (error) {
      ToastUtils.showErrorToast(
          message: "Greška prilikom zavrsavanja oglasa: $error");
    }
  }

  @override
  void didPopNext() {
    super.didPopNext();
    _pagingController.refresh();
  }

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    final modalRoute = ModalRoute.of(context);
    if (modalRoute != null) {
      routeObserver.subscribe(this, modalRoute);
    }
  }

  @override
  void dispose() {
    routeObserver.unsubscribe(this);
    _pagingController.dispose();
    super.dispose();
  }

  void _onTabSelected(String tab) {
    if (_selectedTab != tab) {
      setState(() {
        _selectedTab = tab;
        _pagingController.itemList = [];
      });
      _pagingController.refresh();
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Moji Oglasi"),
        iconTheme: const IconThemeData(
          color: Colors.blueAccent,
        ),
      ),
      body: FutureBuilder<bool>(
        future: _checkIfLoggedIn(),
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }

          if (snapshot.hasData && !snapshot.data!) {
            return Center(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const Padding(
                    padding: EdgeInsets.symmetric(horizontal: 24.0),
                    child: Text(
                      "Morate se prijaviti da biste vidjeli svoje oglase.",
                      style: TextStyle(
                        fontSize: 18,
                        fontWeight: FontWeight.bold,
                        color: Colors.black54,
                      ),
                      textAlign: TextAlign.center,
                    ),
                  ),
                  const SizedBox(height: 16),
                  LoginButton(
                    onPressed: () {
                      Navigator.pushReplacementNamed(context, '/login');
                    },
                  ),
                ],
              ),
            );
          }

          return Column(
            children: [
              Container(
                color: Colors.grey.shade800,
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: [
                    _buildTab("Aktivni", "active"),
                    _buildTab("Završeni", "done"),
                    _buildTab("Izdvojeni", "highlighted"),
                  ],
                ),
              ),
              Expanded(
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: PagedListView<int, AutomobileAd>(
                    pagingController: _pagingController,
                    builderDelegate: PagedChildBuilderDelegate<AutomobileAd>(
                      itemBuilder: (context, item, index) {
                        return MyAutomobileAdsCard(
                          automobileAd: item,
                          selectedTab: _selectedTab,
                          onRemove: (id) async {
                            await _removeAutomobile(id);
                          },
                          onComplete: (id) async {
                            _markAsDone(id);
                          },
                        );
                      },
                      firstPageProgressIndicatorBuilder: (context) =>
                          const Center(child: CircularProgressIndicator()),
                      newPageProgressIndicatorBuilder: (context) =>
                          const Padding(
                        padding: EdgeInsets.all(12.0),
                        child: Center(child: CircularProgressIndicator()),
                      ),
                      noItemsFoundIndicatorBuilder: (context) => Center(
                        child: Text(
                          _selectedTab == "active"
                              ? "Trenutno nemate nijedan aktivan oglas.\nAko ste kreirali oglas, on je u procesu pregleda."
                              : "Nemate nijedan oglas.",
                          textAlign: TextAlign.center,
                        ),
                      ),
                    ),
                  ),
                ),
              ),
            ],
          );
        },
      ),
    );
  }

  Widget _buildTab(String title, String tab) {
    final isSelected = _selectedTab == tab;
    return GestureDetector(
      onTap: () => _onTabSelected(tab),
      child: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Text(
              title,
              style: TextStyle(
                color: isSelected ? Colors.white : Colors.grey.shade400,
                fontWeight: isSelected ? FontWeight.bold : FontWeight.normal,
              ),
            ),
          ),
          if (isSelected)
            Container(
              height: 2,
              width: 80,
              color: Colors.white,
            ),
        ],
      ),
    );
  }
}

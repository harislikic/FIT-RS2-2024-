import 'package:flutter/material.dart';
import 'package:infinite_scroll_pagination/infinite_scroll_pagination.dart';
import 'package:vroom_app/components/RecommendedCarousel.dart';
import 'package:vroom_app/main.dart';
import 'package:vroom_app/screens/filterScreen.dart';
import 'package:vroom_app/services/AuthService.dart';
import '../models/automobileAd.dart';
import '../services/AutomobileAdService.dart';
import '../components/automobileCard.dart';
import '../components/SearchBarComponent.dart';

class AutomobileListScreen extends StatefulWidget {
  const AutomobileListScreen({Key? key}) : super(key: key);

  @override
  _AutomobileListScreenState createState() => _AutomobileListScreenState();
}

class _AutomobileListScreenState extends State<AutomobileListScreen>
    with RouteAware {
  final AutomobileAdService _automobileAdService = AutomobileAdService();

  static const _pageSize = 25;

  final PagingController<int, AutomobileAd> _pagingController =
      PagingController(firstPageKey: 0);

  String _searchTerm = '';
  bool _isSearchVisible = false;
  bool _isFilterVisible = false;
  bool _isGridView = true;
  bool _isLoggedIn = false;

  String _minPrice = '';
  String _maxPrice = '';
  String _minMileage = '';
  String _maxMileage = '';
  String _yearOfManufacture = '';
  bool _registered = false;
  String _carBrandId = '';
  String _carCategoryId = '';
  String _carModelId = '';
  String _cityId = '';

  @override
  void initState() {
    super.initState();
    _pagingController.addPageRequestListener((pageKey) {
      _fetchPage(pageKey);
    });
    _checkLoginStatus();
  }

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    routeObserver.subscribe(this, ModalRoute.of(context)!);
  }

  @override
  void dispose() {
    _pagingController.dispose();
    routeObserver.unsubscribe(this);
    super.dispose();
  }

  @override
  void didPopNext() {
    _pagingController.refresh();
  }

  Future<void> _checkLoginStatus() async {
    final userId = await AuthService.getUserId();
    setState(() {
      _isLoggedIn = userId != null;
    });
  }

  bool _hasActiveFilters() {
    return _minPrice.isNotEmpty ||
        _maxPrice.isNotEmpty ||
        _minMileage.isNotEmpty ||
        _maxMileage.isNotEmpty ||
        _yearOfManufacture.isNotEmpty ||
        _registered ||
        _carBrandId.isNotEmpty ||
        _carCategoryId.isNotEmpty ||
        _carModelId.isNotEmpty ||
        _cityId.isNotEmpty ||
        _searchTerm.isNotEmpty;
  }

  Future<void> _fetchPage(int pageKey) async {
    try {
      await Future.delayed(const Duration(milliseconds: 500));

      final newAds = await _automobileAdService.fetchAutomobileAds(
        searchTerm: _searchTerm,
        page: pageKey,
        pageSize: _pageSize,
        minPrice: _minPrice,
        maxPrice: _maxPrice,
        minMileage: _minMileage,
        maxMileage: _maxMileage,
        yearOfManufacture: _yearOfManufacture,
        registered: _registered,
        carBrandId: _carBrandId,
        carCategoryId: _carCategoryId,
        carModelId: _carModelId,
        cityId: _cityId,
      );

      final isLastPage = newAds.length < _pageSize;
      if (isLastPage) {
        _pagingController.appendLastPage(newAds);
      } else {
        final nextPageKey = pageKey + 1;
        _pagingController.appendPage(newAds, nextPageKey);
      }
    } catch (error) {
      _pagingController.error = error;
    }
  }

  void _onSearch(String searchTerm) {
    setState(() {
      _searchTerm = searchTerm;
      _pagingController.refresh();
    });
  }

  void _applyFilters(
      String minPrice,
      String maxPrice,
      String minMileage,
      String maxMileage,
      String yearOfManufacture,
      bool registered,
      String carBrandId,
      String carCategoryId,
      String carModelId,
      String cityId) {
    setState(() {
      _minPrice = minPrice;
      _maxPrice = maxPrice;
      _minMileage = minMileage;
      _maxMileage = maxMileage;
      _yearOfManufacture = yearOfManufacture;
      _registered = registered;
      _isFilterVisible = false;
      _carBrandId = carBrandId;
      _carCategoryId = carCategoryId;
      _carModelId = carModelId;
      _cityId = cityId;
      _pagingController.refresh();
    });
  }

  void _resetFilters() {
    setState(() {
      _minPrice = '';
      _maxPrice = '';
      _minMileage = '';
      _maxMileage = '';
      _yearOfManufacture = '';
      _registered = false;
      _carBrandId = '';
      _carCategoryId = '';
      _carModelId = '';
      _cityId = '';
      _pagingController.refresh();
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blueGrey[900],
        title: Row(
          children: [
            IconButton(
              icon: Icon(
                Icons.grid_on,
                color: _isGridView ? Colors.lightBlueAccent : Colors.blue,
                size: 26.0,
              ),
              onPressed: () {
                setState(() {
                  _isGridView = true;
                });
              },
            ),
            IconButton(
              icon: Icon(
                Icons.list,
                color: !_isGridView ? Colors.lightBlueAccent : Colors.blue,
                size: 30.0,
              ),
              onPressed: () {
                setState(() {
                  _isGridView = false;
                });
              },
            ),
            const Expanded(
              child: Center(
                child: Text(
                  'Oglasi',
                  style: TextStyle(color: Colors.white, fontSize: 20),
                ),
              ),
            ),
            IconButton(
              icon: Icon(
                Icons.search,
                color: _isSearchVisible ? Colors.lightBlueAccent : Colors.blue,
                size: 30.0,
              ),
              onPressed: () {
                setState(() {
                  _isSearchVisible = !_isSearchVisible;
                });
              },
            ),
            IconButton(
                icon: const Icon(
                  Icons.filter_list,
                  color: Colors.blue,
                  size: 30.0,
                ),
                onPressed: () async {
                  final result = await Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) => FilterScreen(
                        onApplyFilters: _applyFilters,
                        onResetFilters: _resetFilters,
                        currentFilters: {
                          'minPrice': _minPrice,
                          'maxPrice': _maxPrice,
                          'minMileage': _minMileage,
                          'maxMileage': _maxMileage,
                          'yearOfManufacture': _yearOfManufacture,
                          'registered': _registered,
                          'carBrandId': _carBrandId,
                          'carCategoryId': _carCategoryId,
                          'carModelId': _carModelId,
                          'cityId': _cityId,
                        },
                      ),
                    ),
                  );

                  if (result == true) {
                    setState(() {});
                  }
                }),
          ],
        ),
      ),
      body: GestureDetector(
        onTap: () {
          FocusScope.of(context).unfocus();
        },
        child: Column(
          children: [
            Offstage(
              offstage: !_isSearchVisible,
              child: AnimatedOpacity(
                opacity: _isSearchVisible ? 1.0 : 0.0,
                duration: const Duration(milliseconds: 300),
                child: Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: SearchBarComponent(onSearch: _onSearch),
                ),
              ),
            ),
            Expanded(
              child: CustomScrollView(
                slivers: [
                  if (_isLoggedIn &&
                      !_isSearchVisible &&
                      !_isFilterVisible &&
                      !_hasActiveFilters())
                    const SliverToBoxAdapter(
                      child: Padding(
                        padding: EdgeInsets.symmetric(vertical: 0.0),
                        child: SizedBox(
                          child: RecommendedCarousel(),
                        ),
                      ),
                    ),
                  if (_isLoggedIn &&
                      !_isSearchVisible &&
                      !_isFilterVisible &&
                      !_hasActiveFilters())
                    const SliverToBoxAdapter(
                      child: SizedBox(height: 16.0),
                    ),
                  if (_isLoggedIn &&
                      !_isSearchVisible &&
                      !_isFilterVisible &&
                      !_hasActiveFilters())
                    const SliverToBoxAdapter(
                      child: Padding(
                        padding: EdgeInsets.symmetric(
                            horizontal: 16.0, vertical: 8.0),
                        child: Text(
                          'Ostali oglasi',
                          style: TextStyle(
                            fontSize: 18.0,
                            fontWeight: FontWeight.bold,
                          ),
                          textAlign: TextAlign.start,
                        ),
                      ),
                    ),
                  if (_isGridView)
                    PagedSliverGrid<int, AutomobileAd>(
                      pagingController: _pagingController,
                      gridDelegate:
                          const SliverGridDelegateWithFixedCrossAxisCount(
                        crossAxisCount: 2,
                        crossAxisSpacing: 10,
                        mainAxisSpacing: 10,
                        childAspectRatio: 4 / 6,
                      ),
                      builderDelegate: PagedChildBuilderDelegate<AutomobileAd>(
                        itemBuilder: (context, item, index) => AutomobileCard(
                          automobileAd: item,
                          isGridView: true,
                        ),
                        firstPageProgressIndicatorBuilder: (context) =>
                            const Center(child: CircularProgressIndicator()),
                        newPageProgressIndicatorBuilder: (context) =>
                            const Padding(
                          padding: EdgeInsets.all(12.0),
                          child: Center(child: CircularProgressIndicator()),
                        ),
                        noItemsFoundIndicatorBuilder: (context) =>
                            const Center(child: Text('Nema dostupnih oglasa.')),
                      ),
                    )
                  else
                    PagedSliverList<int, AutomobileAd>(
                      pagingController: _pagingController,
                      builderDelegate: PagedChildBuilderDelegate<AutomobileAd>(
                        itemBuilder: (context, item, index) => AutomobileCard(
                          automobileAd: item,
                          isGridView: false,
                        ),
                        firstPageProgressIndicatorBuilder: (context) =>
                            const Center(child: CircularProgressIndicator()),
                        newPageProgressIndicatorBuilder: (context) =>
                            const Padding(
                          padding: EdgeInsets.all(12.0),
                          child: Center(child: CircularProgressIndicator()),
                        ),
                        noItemsFoundIndicatorBuilder: (context) =>
                            const Center(child: Text('Nema dostupnih oglasa.')),
                      ),
                    ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}

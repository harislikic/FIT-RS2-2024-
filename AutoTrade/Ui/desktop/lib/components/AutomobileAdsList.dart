import 'package:desktop_app/components/AutomobileAdsTable.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:desktop_app/services/AutomobileAdService.dart';
import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/services/ApiConfig.dart';
import 'package:desktop_app/models/automobileAd.dart';

class AutomobileAdsList extends StatefulWidget {
  const AutomobileAdsList({Key? key}) : super(key: key);

  @override
  State<AutomobileAdsList> createState() => _AutomobileAdsListState();
}

class _AutomobileAdsListState extends State<AutomobileAdsList> {
  final TextEditingController _searchController = TextEditingController();
  final ScrollController _scrollController = ScrollController();
  List<AutomobileAd> _ads = [];
  int _count = 0;
  int _currentPage = 0;
  bool _isLoading = false;
  final int _pageSize = 25;
  String? _selectedStatus = "Active";

  @override
  void initState() {
    super.initState();
    _fetchAutomobileAds();
    _scrollController.addListener(_onScroll);
  }

  void _onScroll() {
    if (_scrollController.position.pixels >=
            _scrollController.position.maxScrollExtent - 100 &&
        !_isLoading) {
      _fetchAutomobileAds();
    }
  }

  Future<void> _fetchAutomobileAds({String? query}) async {
    if (_isLoading) return;

    setState(() {
      _isLoading = true;
      if (query != null) {
        _ads = [];
        _currentPage = 0;
      }
    });

    try {
      final response = await AutomobileAdService().fetchAutomobileAds(
        searchTerm: query ?? '',
        page: _currentPage,
        pageSize: _pageSize,
        status: _selectedStatus,
      );

      setState(() {
        _count = response['count']; // ✔️
        _ads.addAll(response['data']);
        _currentPage++;
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }

  Future<void> _approveAutomobile(int adId) async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda'),
        content: const Text('Da li želite da odobrite ovaj oglas?'),
        actions: [
          TextButton(
              onPressed: () => Navigator.of(context).pop(false),
              child: const Text('Ne')),
          TextButton(
              onPressed: () => Navigator.of(context).pop(true),
              child: const Text('Da')),
        ],
      ),
    );

    if (confirm != true) return;

    try {
      await AutomobileAdService().markAsActive(adId);

      await _fetchAutomobileAds();

      SnackbarHelper.showSnackbar(context, 'Oglas odobren',
          backgroundColor: Colors.green);
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    }
  }

  Future<void> _deleteAutomobile(int adId) async {
    final confirm = await showDialog<bool>(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Potvrda'),
        content: const Text('Da li ste sigurni da želite obrisati ovaj oglas?'),
        actions: [
          TextButton(
            onPressed: () => Navigator.of(context).pop(false),
            child: const Text('Ne'),
          ),
          TextButton(
            onPressed: () => Navigator.of(context).pop(true),
            child: const Text('Da'),
          ),
        ],
      ),
    );

    if (confirm != true) return;

    try {
      await AutomobileAdService().removeAutomobile(adId, {});

      await _fetchAutomobileAds();

      setState(() {
        _ads.removeWhere((ad) => ad.id == adId);
        _count--;
      });

      SnackbarHelper.showSnackbar(context, 'Oglas uspešno obrisan',
          backgroundColor: Colors.green);
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('Lista oglasa')),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                SizedBox(
                  width: 400,
                  child: TextField(
                    controller: _searchController,
                    decoration: InputDecoration(
                      labelText: 'Pretraga po naslovu',
                      border: const OutlineInputBorder(),
                      isDense: true,
                      suffixIcon: _searchController.text.isNotEmpty
                          ? IconButton(
                              icon: const Icon(Icons.clear),
                              onPressed: () {
                                _searchController.clear();
                                _fetchAutomobileAds();
                              },
                            )
                          : null,
                    ),
                    onSubmitted: (_) =>
                        _fetchAutomobileAds(query: _searchController.text),
                  ),
                ),
                const SizedBox(width: 8),
                Row(
                  children: [
                    Radio(
                      value: "Active",
                      groupValue: _selectedStatus,
                      onChanged: (String? value) {
                        setState(() {
                          _selectedStatus = value;
                        });
                        _fetchAutomobileAds();
                      },
                    ),
                    const Text("Active"),
                    Radio(
                      value: "Pending",
                      groupValue: _selectedStatus,
                      onChanged: (String? value) {
                        setState(() {
                          _selectedStatus = value;
                        });
                        _fetchAutomobileAds();
                      },
                    ),
                    const Text("Pending"),
                  ],
                ),
                const SizedBox(width: 8),
                ElevatedButton(
                  onPressed: () =>
                      _fetchAutomobileAds(query: _searchController.text),
                  child: const Text('Traži'),
                ),
                const SizedBox(width: 16),
                Text('Ukupno oglasa: $_count'),
              ],
            ),
          ),
          AutomobileAdsTable(
            ads: _ads,
            onDelete: _deleteAutomobile,
            onApprove: _approveAutomobile,
            scrollController: _scrollController,
          ),
        ],
      ),
    );
  }
}

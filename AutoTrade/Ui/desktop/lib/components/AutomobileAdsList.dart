import 'package:desktop_app/components/AutomobileAdsTable.dart';
import 'package:flutter/material.dart';
import 'package:desktop_app/services/AutomobileAdService.dart';
import 'package:desktop_app/components/shared/SnackbarHelper.dart';
import 'package:desktop_app/models/automobileAd.dart';

class AutomobileAdsList extends StatefulWidget {
  const AutomobileAdsList({Key? key}) : super(key: key);

  @override
  State<AutomobileAdsList> createState() => _AutomobileAdsListState();
}

class _AutomobileAdsListState extends State<AutomobileAdsList> {
  final TextEditingController _searchController = TextEditingController();

  List<AutomobileAd> _ads = [];

  int _count = 0;

  int _currentPage = 0;

  int _serverPage = 0;

  bool _isLoading = false;

  final int _pageSize = 25;

  String _selectedStatus = "Active";

  @override
  void initState() {
    super.initState();
    _fetchAutomobileAds();
  }

  Future<void> _fetchAutomobileAds({String? query}) async {
    if (_isLoading) return;
    setState(() => _isLoading = true);

    if (query != null) {
      _ads.clear();
      _currentPage = 0;
      _serverPage = 0;
    }

    try {
      final response = await AutomobileAdService().fetchAutomobileAds(
        searchTerm: query ?? _searchController.text,
        page: _serverPage,
        pageSize: _pageSize,
        status: _selectedStatus,
      );

      setState(() {
        _count = response['count'] as int;
        final fetchedAds = response['data'] as List<AutomobileAd>;
        _ads.addAll(fetchedAds);

        _serverPage++;
      });
    } catch (e) {
      SnackbarHelper.showSnackbar(context, 'Error: $e');
    } finally {
      setState(() => _isLoading = false);
    }
  }

  List<AutomobileAd> get _pageAds {
    final startIndex = _currentPage * _pageSize;
    int endIndex = startIndex + _pageSize;
    if (endIndex > _ads.length) {
      endIndex = _ads.length;
    }
    if (startIndex >= _ads.length) {
      return [];
    }
    return _ads.sublist(startIndex, endIndex);
  }

  void _onSearch() {
    _fetchAutomobileAds(query: _searchController.text);
  }

  void _onStatusChanged(String? value) {
    if (value == null) return;
    setState(() {
      _selectedStatus = value;
    });
    _fetchAutomobileAds(query: _searchController.text);
  }

  void _nextPage() {
    setState(() {
      final nextPage = _currentPage + 1;

      final nextStartIndex = nextPage * _pageSize;

      if (nextStartIndex >= _ads.length && _ads.length < _count) {
        _fetchAutomobileAds();
      }
      _currentPage = nextPage;
    });
  }

  void _prevPage() {
    setState(() {
      if (_currentPage > 0) {
        _currentPage--;
      }
    });
  }

  bool get canGoPrev => _currentPage > 0;
  bool get canGoNext {
    final nextStart = (_currentPage + 1) * _pageSize;
    if (nextStart >= _count) return false;
    return true;
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
      _ads.clear();
      _serverPage = 0;
      _currentPage = 0;
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
    int startDisplay;
    int endDisplay;

    if (_count == 0) {
      startDisplay = 0;
      endDisplay = 0;
    } else {
      startDisplay = _currentPage * _pageSize + 1;
      endDisplay = startDisplay + _pageSize - 1;
      if (endDisplay > _count) {
        endDisplay = _count;
      }
    }

    return Scaffold(
      appBar: AppBar(title: const Text('Lista oglasa')),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Wrap(
              alignment: WrapAlignment.start,
              spacing: 8.0,
              runSpacing: 8.0,
              crossAxisAlignment: WrapCrossAlignment.start,
              children: [
                SizedBox(
                  width: 400,
                  child: TextField(
                    controller: _searchController,
                    decoration: InputDecoration(
                      labelText: 'Pretraga po nazivu ili vlasniku',
                      border: const OutlineInputBorder(),
                      isDense: true,
                      suffixIcon: _searchController.text.isNotEmpty
                          ? IconButton(
                              icon: const Icon(Icons.clear),
                              onPressed: () {
                                _searchController.clear();
                                _onSearch();
                              },
                            )
                          : null,
                    ),
                    onSubmitted: (_) => _onSearch(),
                  ),
                ),
                Row(
                  mainAxisSize: MainAxisSize.min,
                  children: [
                    Radio<String>(
                      value: "Active",
                      groupValue: _selectedStatus,
                      onChanged: _onStatusChanged,
                    ),
                    const Text("Aktivni"),
                    Radio<String>(
                      value: "Pending",
                      groupValue: _selectedStatus,
                      onChanged: _onStatusChanged,
                    ),
                    const Text("Na obradi"),
                  ],
                ),
                ElevatedButton(
                  onPressed: _onSearch,
                  child: const Text('Traži'),
                ),
                Text(
                  'Ukupan broj oglasa: $_count',
                  style: const TextStyle(
                      fontSize: 16, fontWeight: FontWeight.bold),
                ),
              ],
            ),
          ),
          Expanded(
            child: SingleChildScrollView(
              scrollDirection: Axis.vertical,
              child: SingleChildScrollView(
                scrollDirection: Axis.horizontal,
                child: AutomobileAdsTable(
                  ads: _pageAds,
                  onDelete: _deleteAutomobile,
                  onApprove: _approveAutomobile,
                ),
              ),
            ),
          ),
          Padding(
            padding: const EdgeInsets.symmetric(vertical: 8.0),
            child: Column(
              children: [
                Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    ElevatedButton(
                      onPressed: canGoPrev ? _prevPage : null,
                      child: const Icon(Icons.arrow_back),
                    ),
                    const SizedBox(width: 16),
                    ElevatedButton(
                      onPressed: canGoNext ? _nextPage : null,
                      child: const Icon(Icons.arrow_forward),
                    ),
                  ],
                ),
                const SizedBox(height: 8),
                Text(
                  'Prikaz oglasa: $startDisplay - $endDisplay (od $_count)',
                  style: const TextStyle(fontSize: 15),
                ),
                if (_isLoading)
                  const Padding(
                    padding: EdgeInsets.all(8.0),
                    child: CircularProgressIndicator(),
                  ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}

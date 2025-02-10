import 'package:carousel_slider/carousel_slider.dart';
import 'package:desktop_app/services/config.dart';
import 'package:flutter/material.dart';

class ImageGalleryDialog extends StatefulWidget {
  final List<String> imageUrls;

  const ImageGalleryDialog({Key? key, required this.imageUrls})
      : super(key: key);

  @override
  _ImageGalleryDialogState createState() => _ImageGalleryDialogState();
}

class _ImageGalleryDialogState extends State<ImageGalleryDialog> {
  int _currentIndex = 0;
  final CarouselController _carouselController = CarouselController();

  @override
  Widget build(BuildContext context) {
    return Dialog(
      backgroundColor: Colors.white,
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
      child: Container(
        width: 800,
        height: 600,
        padding: const EdgeInsets.all(16),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            const Padding(
              padding: EdgeInsets.all(8.0),
              child: Text(
                "Pregled slika",
                style: TextStyle(
                  fontSize: 22,
                  fontWeight: FontWeight.w600,
                  color: Colors.black87,
                  letterSpacing: 1.2,
                ),
              ),
            ),

            Expanded(
              child: Stack(
                alignment: Alignment.center,
                children: [
                  CarouselSlider(
                    items: widget.imageUrls.map((imageUrl) {
                      return Container(
                        margin: const EdgeInsets.symmetric(horizontal: 10),
                        child: ClipRRect(
                          borderRadius: BorderRadius.circular(10),
                          child: Image.network(
                            '$baseUrl$imageUrl',
                            fit: BoxFit.contain,
                            width: double.infinity,
                            height: 500,
                            errorBuilder: (context, error, stackTrace) {
                              return Image.asset(
                                'assets/fallback.jpg',
                                fit: BoxFit.contain,
                                width: double.infinity,
                                height: 500,
                              );
                            },
                          ),
                        ),
                      );
                    }).toList(),
                    carouselController: _carouselController,
                    options: CarouselOptions(
                      height: 500,
                      enableInfiniteScroll: true,
                      enlargeCenterPage: true,
                      viewportFraction: 1.0,
                      autoPlay: false,
                      onPageChanged: (index, reason) {
                        setState(() {
                          _currentIndex = index;
                        });
                      },
                    ),
                  ),

                  Positioned(
                    left: 10,
                    child: GestureDetector(
                      onTap: () {
                        _carouselController.previousPage();
                      },
                      child: const CircleAvatar(
                        backgroundColor: Colors.grey,
                        radius: 25,
                        child: Icon(
                          Icons.arrow_back_sharp,
                          color: Colors.white,
                          size: 22,
                        ),
                      ),
                    ),
                  ),

              
                  Positioned(
                    right: 10,
                    child: GestureDetector(
                      onTap: () {
                        _carouselController.nextPage();
                      },
                      child: const CircleAvatar(
                        backgroundColor: Colors.grey,
                        radius: 25,
                        child: Icon(
                          Icons.arrow_forward_sharp,
                          color: Colors.white,
                          size: 22,
                        ),
                      ),
                    ),
                  ),
                ],
              ),
            ),

            // Indikatori
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: widget.imageUrls.asMap().entries.map((entry) {
                return GestureDetector(
                  onTap: () {
                    _carouselController.animateToPage(entry.key);
                    setState(() {
                      _currentIndex = entry.key;
                    });
                  },
                  child: Container(
                    width: 12.0,
                    height: 12.0,
                    margin: const EdgeInsets.symmetric(
                        vertical: 8.0, horizontal: 4.0),
                    decoration: BoxDecoration(
                      shape: BoxShape.circle,
                      color: _currentIndex == entry.key
                          ? Colors.blue
                          : Colors.grey,
                    ),
                  ),
                );
              }).toList(),
            ),

            TextButton(
              onPressed: () => Navigator.pop(context),
              child: const Text(
                "Zatvori",
                style: TextStyle(
                  color: Colors.black87,
                  fontSize: 16,
                  fontWeight: FontWeight.w500,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}

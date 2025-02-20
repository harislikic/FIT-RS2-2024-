import 'package:flutter/material.dart';

class ProfileHeader extends StatelessWidget {
  final String? profileImageUrl;
  final VoidCallback onEdit;
  final VoidCallback onLogout;
  final VoidCallback onReservationsForMe;
  final VoidCallback onMyReservations;

  const ProfileHeader({
    Key? key,
    required this.profileImageUrl,
    required this.onEdit,
    required this.onLogout,
    required this.onReservationsForMe,
    required this.onMyReservations,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Stack(
      children: [
        Container(
          width: double.infinity,
          height: 300,
          decoration: BoxDecoration(
            gradient: LinearGradient(
              colors: [Colors.pink.shade300, Colors.cyan.shade300],
              begin: Alignment.topLeft,
              end: Alignment.bottomRight,
            ),
          ),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Container(
                decoration: BoxDecoration(
                  shape: BoxShape.circle,
                  boxShadow: [
                    BoxShadow(
                      color: Colors.black.withOpacity(0.2),
                      blurRadius: 8,
                      spreadRadius: 2,
                      offset: Offset(0, 4),
                    ),
                  ],
                ),
                child: CircleAvatar(
                  radius: 55,
                  backgroundColor: Colors.white,
                  child: CircleAvatar(
                    radius: 50,
                    backgroundImage: profileImageUrl != null
                        ? NetworkImage(profileImageUrl!)
                        : null,
                    backgroundColor: Colors.grey[300],
                    child: profileImageUrl == null
                        ? Icon(
                            Icons.person,
                            size: 50,
                            color: Colors.grey[700],
                          )
                        : null,
                  ),
                ),
              ),
              const SizedBox(height: 12),
              Padding(
                padding: const EdgeInsets.symmetric(horizontal: 16),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Expanded(
                      child: ElevatedButton.icon(
                        onPressed: onReservationsForMe,
                        icon: const Icon(
                          Icons.event_available,
                          color: Colors.white,
                        ),
                        label: const Text(
                          "Za mene",
                          style: TextStyle(color: Colors.white),
                        ),
                        style: ElevatedButton.styleFrom(
                          side: BorderSide(
                            color: Colors.teal.shade200,
                            width: 2,
                          ),
                          backgroundColor: Colors.transparent,
                          padding: const EdgeInsets.symmetric(
                              horizontal: 10, vertical: 12),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(12),
                          ),
                        ),
                      ),
                    ),
                    const SizedBox(width: 10),
                    Expanded(
                      child: ElevatedButton.icon(
                        onPressed: onMyReservations,
                        icon: const Icon(
                          Icons.event_note,
                          color: Colors.white,
                        ),
                        label: const Text(
                          "Moje",
                          style: TextStyle(color: Colors.white),
                        ),
                        style: ElevatedButton.styleFrom(
                          side: BorderSide(
                            color: Colors.teal.shade200,
                            width: 2,
                          ),
                          backgroundColor: Colors.transparent,
                          padding: const EdgeInsets.symmetric(
                              horizontal: 10, vertical: 12),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(12),
                          ),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
              const SizedBox(height: 10),
              ElevatedButton.icon(
                onPressed: onEdit,
                icon: const Icon(Icons.edit, color: Colors.white),
                label: const Text(
                  "Uredi profil",
                  style: TextStyle(color: Colors.white),
                ),
                style: ElevatedButton.styleFrom(
                  side: BorderSide(
                    color: Colors.teal.shade200,
                    width: 2,
                  ),
                  backgroundColor: Colors.black.withOpacity(0.2),
                  padding:
                      const EdgeInsets.symmetric(horizontal: 24, vertical: 8),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(12),
                  ),
                  elevation: 0,
                ),
              ),
              const SizedBox(height: 8),
            ],
          ),
        ),
        Positioned(
          top: 16,
          right: 16,
          child: Row(
            children: [
              IconButton(
                icon: const Icon(
                  Icons.logout,
                  color: Colors.white,
                  size: 30,
                ),
                onPressed: onLogout,
              ),
              Container(
                padding: EdgeInsets.symmetric(horizontal: 12, vertical: 6),
                decoration: BoxDecoration(
                  color: Colors.black.withOpacity(0.4),
                  borderRadius: BorderRadius.circular(8),
                ),
                child: const Text(
                  'Odjava',
                  style: TextStyle(
                    color: Colors.white,
                    fontSize: 16,
                    fontWeight: FontWeight.w600,
                  ),
                ),
              ),
            ],
          ),
        ),
      ],
    );
  }
}

# FIT-RS2-2024

## Setup Instructions

### Docker Setup
To set up the project using Docker, follow these steps:

1. Open a terminal inside the solution folder.
2. Run the following commands:
   ```sh
   docker-compose up --build
   ```

---

## Flutter Desktop

### Desktop Credentials
- **Username:** `admin`
- **Password:** `password123`

### Setup Instructions
To set up and run the Flutter desktop application, execute the following commands:

```sh
flutter pub get
flutter run
```

**Note:** When prompted, choose option **1 (Windows)**.

---

## Flutter Mobile

### Login Credentials
You can create a new profile or use the existing credentials:
- **Username:** `admin`
- **Password:** `password123`

### Setup Instructions
To set up and run the Flutter mobile application, execute the following commands:

```sh
flutter pub get
flutter run
```

### Using Stripe Keys
If you want to use your own Stripe keys, run the following command:
```sh
flutter run --dart-define stripePublishableKey=yourStripePublishableKey --dart-define stripeSecretKey=yourStripeSecretKey
```

### Stripe Test Card Number
Use the following test card number for Stripe transactions:
- **Test Card Number:** `4242 4242 4242 4242`

---

## RabbitMQ Implementation

### AutoTrade Email Subscriber

#### 📩 Description
AutoTrade Email Subscriber is a backend service that uses **RabbitMQ** to asynchronously send emails to users after a car reservation is approved. This service listens for messages from RabbitMQ, processes them, and sends appropriate emails to users via the **ReservationApprovalEmail** service.

### RabbitMQ Credentials
- **Username:** `guest`
- **Password:** `guest`

### Testing Email Notifications via RabbitMQ
To test sending email notifications via RabbitMQ:

1. **Create a profile** with your email address.
2. **Search for a car** in the system, e.g., `'Audi A3 2018'`.
3. **Make a reservation** for the selected car.
4. **Log in** to the admin account on mobile app:
   - **Username:** `admin`
   - **Password:** `password123`
5. **Go to the "My Profile" section**, find your reservation, and approve it.
6. After approval, you should receive a **confirmation email** for the reservation you made.

---

## Additional Notes
- Ensure RabbitMQ is running before testing email notifications.
- Use **Docker** for setting up the backend services.
- **Stripe test cards** can be used for payment testing without actual transactions.

Feel free to contribute or report issues via the repository's issue tracker!


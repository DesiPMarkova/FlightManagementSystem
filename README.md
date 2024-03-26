# Flight Management System (WinForms with MSSQL)

This Flight Management System is a Windows Forms application designed to facilitate flight reservations and management. Users can search for available flights, reserve seats, and even book return flights. The system operates with an MSSQL database to store flight and reservation information.

## Getting Started

To start using the application, follow these steps:

1. **Database Setup**:
   - Begin by creating the MSSQL database required for the application.
   - Execute the provided SQL script to create the necessary tables and populate initial data.

2. **Connection String Configuration**:
   - Before running the application, ensure that the connection string is properly configured.
   - Locate and modify the connection string in the source code files. (Connection string is not stored in the application configuration.)

3. **Build and Run**:
   - Build the solution using Visual Studio or any preferred IDE.
   - Run the application to start using the Flight Management System.

## Features

### Flight Search
- Users can search for available flights based on criteria such as departure location, destination, and date.
- The system retrieves and displays a list of matching flights along with relevant details like flight number, departure time, and available seats.

### Seat Reservation
- Upon selecting a flight, users can reserve seats based on availability.
- The system ensures that only vacant seats are available for reservation, preventing overbooking.

### Return Flight Booking
- Users have the option to book return flights easily.
- The application provides a seamless process for selecting return flights based on the user's preferences.

### Database Interaction
- The system interacts with the MSSQL database to retrieve flight information, update seat reservations, and store booking details.

## Technologies Used

- **C#**: The application logic is implemented using C# programming language.
- **WinForms**: User interface design and interaction are built using Windows Forms.
- **MSSQL**: Microsoft SQL Server is used as the backend database management system.
## License

This project is licensed under the [MIT License](LICENSE).

---

Feel free to contribute or suggest improvements by forking the repository and submitting a pull request. For any issues or feature requests, please open an issue on GitHub.

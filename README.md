# Eventology Windows Forms Application

**Eventology** is a desktop application developed in **C#** with an integrated **SQL Server database**, designed to manage cultural events, venue reservations, and user interactions. The app supports multiple user roles, each with specific permissions for managing events, venues, and ticketing operations.

## Features

### **User Roles & Permissions**
**Superadministrator**:
  - Full access to all functionalities.
  - Can create, modify, and delete users (superadministrators, administrators, and organizers).
  - Complete management of venues and event configurations.
  
**Administrator**:
  - Can create and delete events and venues.
  - Can modify data for events and venues.
  - Cannot manage users at a higher permission level.
  
**Organizer**:
  - Can only create and manage their own events.
  - Cannot modify venue settings or manage users.

### **App Extensions**
**Event Scheduling**: Allows for precise scheduling of events, ensuring no conflicts in venue bookings.
**Seat Reservations**: Manages seat assignments for events with numbered seating.
**Reports & Analytics**: Provides insights into event participation, ticket sales, and user engagement.
**Multilingual Support**: Available in Catalan, Spanish, and English.
**Integrated Help & Support**: 
  - Built-in guides and FAQs to assist users.
  - In-app technical support for troubleshooting issues.

## Technologies Used

**C#**: The primary programming language for building the application.
**SQL Server**: Used as the backend database to store event data, reservations, and tickets.
**Windows Forms**: For creating the desktop interface of the application.

## Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/Eventolog/windows-forms.git
   ```
2. Open the project in **Visual Studio**.
3. Ensure that **SQL Server** is set up and configure the database as per the provided SQL script.
4. Build and run the application.

## Setup SQL Server

You can set up the database using the provided SQL script. Follow the instructions in the **SQL script** to create the database and tables.

## Contributing

We welcome contributions! Feel free to fork the repository, submit issues, or create pull requests to improve the application.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

If you have any questions or suggestions, feel free to contact us at 148581386+rwxce@users.noreply.github.com.

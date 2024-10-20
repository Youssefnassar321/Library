# Library Management System - Windows Forms Application

## Overview
This is a **Windows Forms application** designed to manage a library system with role-based access for **guest**, **librarian**, and **admin** users. The system allows users to manage books, authors, and borrowed books, with specific permissions based on their roles. The application includes a **login and sign-up system**, password management, and email verification for forgotten passwords. The application uses **C#**, **OOP**, **Entity Framework**, and **LINQ**, with a database managed in **Microsoft SQL Server** and **MongoDB**.

## Features

### General Features
- **Role-based User Management**:
  - Three user types: **Guest**, **Librarian**, and **Admin**.
  - Each user type has distinct permissions and functionalities.

### Librarian Features:
- Add, delete, and update authors and books.
- Search for books and authors by name.
- View borrowed books and identify who borrowed them.
- Mark books as unavailable when needed.

### Admin Features:
- Perform all librarian actions.
- Add and manage users.
- Assign roles to users.
- New users set their password on first login.

### Guest Features:
- View available books and authors.
- Borrow available books.
- Once a book is borrowed, it is automatically marked as unavailable.

### Password Management:
- Users can change their password by entering the old password and creating a new one.
- **Forgot Password** feature:
  - Users can request a password reset by entering their email.
  - A code is sent to the user’s email for verification before resetting the password.

### Database and Data Management:
- **SQL Server** and **MongoDB** are used for data storage, with tables linked by foreign keys.
- The system is implemented using **code-first** migrations.

### Design:
- The forms are designed using **C# Windows Forms**.
- **Photoshop** and **Canva** were used for creating logos and images in the application.

## Technology Stack

### Backend:
- **C#** for application logic.
- **Entity Framework** as the ORM for database interactions.
- **LINQ** for querying data.

### Database:
- **Microsoft SQL Server** for relational database management.
- **MongoDB** for handling additional data requirements using NoSQL.

### Frontend:
- **Windows Forms** designed using C#.
- **Photoshop** and **Canva** for graphical elements.

## Setup and Installation

1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Set up **SQL Server** and **MongoDB**, and configure the connection strings in `appsettings.json`.
4. Run the application locally to ensure functionality.
5. Use the login page to sign in or create an account with appropriate roles.

## Usage

1. **Guest**:
   - View books and authors.
   - Borrow available books.
2. **Librarian**:
   - Manage authors and books.
   - View and manage borrowed books.
3. **Admin**:
   - Manage users and roles in addition to librarian functionalities.

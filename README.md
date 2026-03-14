# Student Management Web App

A simple **Student Management System** built using **ASP.NET Core MVC**, **Entity Framework Core**, **SQL Server**, and **Bootstrap**.

This web application allows users to **add, edit, delete, search, and manage student records** through a clean and simple interface.

---

## Features

- Add new students
- Edit student information
- Delete student records
- Search students by name
- Pagination to display students across multiple pages
- Form validation to ensure correct data entry

---

## Tech Stack

- **Backend:** ASP.NET Core MVC  
- **ORM:** Entity Framework Core  
- **Database:** SQL Server  
- **Frontend:** Bootstrap  

---

## Screenshots

### Main Page (Student List)

Shows the main page displaying saved students.

![Main Page](https://raw.githubusercontent.com/adeelnisar1144/StudentManagement/main/images/database1.PNG)

---

### Add Student

Form used to add a student's **Name, Email, Course, and Age**.

![Add Student](https://raw.githubusercontent.com/adeelnisar1144/StudentManagement/main/images/database2.PNG)

---

### Delete Student

Students can be removed from the database.

![Delete Student](https://raw.githubusercontent.com/adeelnisar1144/StudentManagement/main/images/database3.PNG)

---

### Search Student

Users can search for students by typing their name.

![Search Student](https://raw.githubusercontent.com/adeelnisar1144/StudentManagement/main/images/database4.PNG)

---

## How to Run the Project

**1. Clone the repository**
```bash
git clone https://github.com/adeelnisar1144/StudentManagement.git
```

**2. Navigate to the project folder**
```bash
cd StudentManagement
```

**3. Restore dependencies**
```bash
dotnet restore
```

**4. Apply database migrations**
```bash
dotnet ef database update
```

**5. Run the application**
```bash
dotnet run
```

**6. Open in browser**

Your terminal will provide a URL — paste it into your browser.

---

## Author

**Adeel Nisar**

---

## Project Description

This project demonstrates **CRUD operations (Create, Read, Update, Delete)** using **ASP.NET Core MVC with Entity Framework Core and SQL Server**. It allows users to manage student data efficiently through a web interface.
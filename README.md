# Student Management Web App

A simple web application to **manage student information** using ASP.NET Core MVC, Entity Framework Core, SQL Server, and Bootstrap.  

This project allows users to **add, edit, delete, search, and paginate student records** through a clean web interface.

---

## Features

- **Add Student:** Save a student's Name, Email, Course, and Age.  
- **Edit Student:** Update existing student details.  
- **Delete Student:** Remove student records from the database.  
- **Search Student:** Search students by name.  
- **Pagination:** View students with 5 records per page.  
- **Form Validation:** Ensure valid input before saving.

---

## Tech Stack

- **Backend:** ASP.NET Core MVC  
- **ORM:** Entity Framework Core  
- **Database:** SQL Server  
- **Frontend:** Bootstrap 5  

---

## Screenshots

### Main Page - Student List
![Main Page](images/main_page.png)  
*Shows the list of saved students with 4 records.*

### Add Student Form
![Add Student](images/add_student.png)  
*Form to enter student Name, Email, Course, and Age.*

### Delete Student
![Delete Student](images/delete_student.png)  
*Delete functionality for removing student data.*

### Search Student
![Search Student](images/search_student.png)  
*Search students by name using the search box.*

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)  
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or LocalDB  
- [Visual Studio Code](https://code.visualstudio.com/) (or Visual Studio)  

### Steps to Run Locally

1. Clone the repository: 
```bash
git clone https://github.com/yourusername/StudentManagement.git
cd StudentManagement
Restore packages:

dotnet restore

Apply migrations to create the database:

dotnet ef database update

Run the project:

dotnet run

Open your browser and copy the url from your terminal:
Usage:

Add Student: Click Add Student, fill in the form, and click Save.

Edit Student: Click Edit on a student row, update the fields, and click Update.

Delete Student: Click Delete on a student row, then confirm deletion.

Search Student: Type a name in the search box and press Search.

Pagination: Use page numbers at the bottom to navigate multiple student records.

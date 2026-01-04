# University Registration System

This project is a functional prototype for a University Management System (UMS) designed to handle student course registration and administrative oversight. It features a secure login system that differentiates between Administrative and Student roles, providing distinct interfaces for each.

---

## Key Features

### 1. Secure Authentication
* **Role-Based Access:** The system identifies if a user is an Admin or a Student upon login.
* **Dynamic Redirection:** Admins are sent to the management dashboard, while Students are directed to their personalized registration portal.

### 2. Administrative Panel
* **Course Management:** Full CRUD (Create, Read, Update, Delete) operations for university courses, including credit counts and descriptions.
* **Major Management:** Ability to define and manage academic majors.
* **User Management:** Admins can create and manage both student and administrator accounts.
* **Relational Integrity:** Prevents the deletion of majors that currently have assigned courses or students.

### 3. Student Registration Portal
* **Personalized Welcome:** Displays the student's name, ID, and live registration statistics (total courses and total credits).
* **Major-Specific Courses:** Students only see courses available within their specific major.
* **Registration Workflow:** A "Cart" system allows students to select multiple courses from a checklist before finalizing their registration to the database.
* **Data Validation:** Handles data type conversion between alphanumeric course codes (e.g., CSIT381) and numeric database IDs automatically.

---

## Technical Stack
* **Language:** C# (.NET Framework/Core)
* **Interface:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server (SQLEXPRESS)
* **Library:** `Microsoft.Data.SqlClient`

---

## Database Architecture
The project relies on a relational database named `UniversityDB` with the following core tables:
* **Users:** Stores credentials, roles (`Admin`/`Student`), and `major_id`.
* **Majors:** Defines academic departments.
* **Courses:** Contains course details linked to specific majors.
* **Enrollments:** A junction table recording student IDs, numeric course IDs, and the date of registration.



---

## How to Run
1. Clone the repository.
2. Import the SQL schema into your local **SQL Server Management Studio (SSMS)**.
3. Update the `connString` variable in your C# code to match your local server instance.
4. Build and Run using **Visual Studio**.

---
**Joseph Abou Antoun - 52330567** **CSCI370 - LIU Tripoli**

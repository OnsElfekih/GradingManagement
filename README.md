# 🎓 GradingManagement

A C# desktop application designed to centralize the management of grades, subjects, and classes. It improves transparency and efficiency in the educational process.

---

## 📋 Table of Contents

- [Features](#features)
- [Roles & Permissions](#roles--permissions)
- [Tech Stack](#tech-stack)
- [Setup & Installation](#setup--installation)
- [Database Configuration](#database-configuration)
- [Default Credentials](#default-credentials)
- [Project Structure](#project-structure)
- [Author](#author)

---

## ✅ Features

- Role-based access control (Admin, Teacher, Student)
- Grade entry and management by teachers
- Grade consultation by students
- Subject and class management
- Teacher and student account administration

---

## 👥 Roles & Permissions

### 🔑 Administrator
| Permission               | Access |
|--------------------------|--------|
| Manage teacher accounts  | ✅     |
| Manage student accounts  | ✅     |
| Manage subjects          | ✅     |

### 👨‍🏫 Teacher
| Permission               | Access |
|--------------------------|--------|
| Log in                   | ✅     |
| Manage grades            | ✅     |
| View student list        | ✅     |

### 🎒 Student
| Permission               | Access |
|--------------------------|--------|
| Log in                   | ✅     |
| View grades              | ✅     |

---

## 🛠️ Tech Stack

| Layer            | Technology            |
|------------------|-----------------------|
| Language         | C#                    |
| Framework        | .NET (WinForms / WPF) |
| Database         | SQL Server            |
| Version Control  | Git                   |

---

## ⚙️ Setup & Installation

### Prerequisites

- Visual Studio 2019+
- .NET Framework / .NET SDK
- SQL Server (or SQL Server Express)
- Git

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/OnsElfekih/GradingManagement.git
   ```

2. **Open the solution**
   - Launch Visual Studio
   - File → Open → `GradingManagement.sln`

3. **Configure the database** — see [Database Configuration](#database-configuration)

4. **Build and run**
   - Press `Ctrl + F5` or click ▶ **Start**

---

## 🗄️ Database Configuration

1. Open SQL Server Management Studio (SSMS)
2. Run the provided SQL script:
   ```
   /Database/GradingManagement.sql
   ```
3. Update the connection string in `App.config`:
   ```xml
   <connectionStrings>
     <add name="GradingDB"
          connectionString="Server=YOUR_SERVER;Database=GradingManagement;Integrated Security=True;"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

---

## 🔐 Default Credentials

| Role          | Username | Password     |
|---------------|----------|--------------|
| Administrator | `admin`  | `adminadmin` |

> ⚠️ Change the default admin password after first login.

---

## 📂 Project Structure

```
GradingManagement/
├── Forms/
│   ├── LoginForm.cs
│   ├── AdminDashboard.cs
│   ├── TeacherDashboard.cs
│   └── StudentDashboard.cs
├── Models/
│   ├── User.cs
│   ├── Grade.cs
│   └── Subject.cs
├── Database/
│   ├── DBConnection.cs
│   └── GradingManagement.sql
├── App.config
└── GradingManagement.sln
```

---

## 👩‍💻 Author

**Ons Elfekih**  
IT Engineering Student — Business Intelligence  
🔗 [LinkedIn](https://www.linkedin.com/in/ons-elfekih) · [Portfolio](https://portfolio-elfekih-ons.vercel.app/)

---

## 📄 License

This project is for academic and portfolio purposes.

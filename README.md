
# Loan Management System

This is a full-stack Loan Management System built using **.NET 8 Web API (Clean Architecture)** for the backend and **Angular** for the frontend (frontend in progress).

---

## 🛠 Tech Stack

- **Backend:** ASP.NET Core 8 Web API
- **Architecture:** Clean Architecture (Domain, Application, Infrastructure, API)
- **Database:** SQL Server (EF Core 9)
- **Authentication:** JWT Token-based Authentication
- **Authorization:** Role-Based Access (Admin, Loan Officer, Customer)
- **Password Security:** Hashed using `PasswordHasher<T>` from `Microsoft.AspNetCore.Identity`

---

## ✅ Features Implemented So Far

### 🔐 Authentication & Authorization

- JWT Authentication
- Manual password hashing using `PasswordHasher<T>`
- Role-based authorization logic (Admin, Loan Officer, Customer)
- Seed default admin user with hashed password

### 🧱 Project Structure (Clean Architecture)

- `LoanManagement.Domain` – Contains core entities like `User`
- `LoanManagement.Application` – Contracts, interfaces, DTOs (WIP)
- `LoanManagement.Infrastructure` – EF Core DbContext, Repositories, SeedData
- `LoanManagement.API` – Main Web API project (controllers, DI setup)

### 📦 Database Setup

- Integrated Entity Framework Core 9
- Custom `User` table (not ASP.NET Identity-based)
- SeedData automatically creates an `Admin` user on first run with a hashed password

---

## ⚙️ Getting Started

### 🔧 Prerequisites

- .NET 8 SDK
- SQL Server
- Visual Studio 2022+ or VS Code
- Angular CLI (for frontend - work in progress)

### 🏁 Run Backend API

1. Clone the repo:
   ```bash
   git clone https://github.com/iam-viru/LoanManagement.git
   cd loan-management-system
   ```

2. Update your connection string in `appsettings.json` under `LoanManagement.API`.

3. Apply migrations and seed data:
   ```bash
   dotnet ef database update --project LoanManagement.Infrastructure --startup-project LoanManagement.API
   ```

4. Run the API:
   ```bash
   cd LoanManagement.API
   dotnet run
   ```

5. Default Admin Credentials:
   - **Email:** `admin@loanapp.com`
   - **Password:** `Admin@123`

---

## 🚧 In Progress

- ✅ Role-based route protection
- ✅ User login with JWT token
- ⏳ Angular frontend (Loan Officer / Customer Dashboards)
- ⏳ Loan Management CRUD
- ⏳ Payments, Reports, Loan Types

---

## 📁 Folder Structure

```
LoanManagement.Domain           → Entities, Enums
LoanManagement.Application      → Interfaces, DTOs, Use Cases (WIP)
LoanManagement.Infrastructure   → DbContext, SeedData, EF Configurations
LoanManagement.API              → Controllers, DI, Middleware
```

---

## 🧪 Testing

- API testing can be done using Postman or Swagger (Swagger setup WIP).
- Frontend will integrate token-based auth headers for secure calls.

---

## 📌 Contribution

Open to contributors once the base implementation is complete. Please fork and submit a PR.

---

## 📃 License

MIT License © 2025 [VEE]

# 🔐 Auth API (.NET)

![.NET](https://img.shields.io/badge/.NET-8-blue)
![Status](https://img.shields.io/badge/status-active-success)
![JWT](https://img.shields.io/badge/auth-JWT-orange)
![License](https://img.shields.io/badge/license-MIT-green)

A .NET Authentication API built with ASP.NET Core, Entity Framework Core, SQLite, and JWT Bearer Authentication.

---

## 🚀 Features

- User registration
- Password hashing
- Login authentication
- JWT token generation
- Role-based authorization
- Protected endpoints
- Admin-only endpoint

---

## 🛠 Technologies

- .NET 8
- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- JWT Bearer Authentication
- Swagger / Bruno / Postman

---

## 📌 API Endpoints

### Register User

POST /api/auth/register

{
  "fullName": "Edemar Costa",
  "email": "edemar@email.com",
  "password": "123456",
  "role": "Admin"
}

---

### Login

POST /api/auth/login

{
  "email": "edemar@email.com",
  "password": "123456"
}

---

### Protected Profile

GET /api/secure/profile  
Authorization: Bearer YOUR_TOKEN

---

### Admin Only

GET /api/secure/admin  
Authorization: Bearer YOUR_TOKEN

---

## 🧠 Business Rules Implemented

- Prevent duplicate email registration
- Store passwords using hashing
- Validate login credentials
- Generate JWT tokens with user claims
- Restrict access by authentication
- Restrict admin endpoint by role

---

## 🧱 Project Structure

AuthApiDotNet
├── Controllers
├── Data
├── DTOs
├── Models
├── Services
├── Program.cs
└── appsettings.json

---

## 📈 Future Improvements

- Refresh tokens
- Password reset flow
- Email confirmation
- Stronger password policy
- Clean Architecture
- Unit tests
- Docker support

---

## 👨‍💻 Author

Edemar Costa Oliveira

GitHub: https://github.com/edemarcosta  
LinkedIn: https://www.linkedin.com/in/edemar-costa-oliveira

---

## ⭐ Project Purpose

This project was created as part of a professional backend portfolio to demonstrate authentication, authorization, JWT, and secure API development using .NET.

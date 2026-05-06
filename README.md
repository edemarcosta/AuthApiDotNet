# 🔐 Auth API (.NET)

![.NET](https://img.shields.io/badge/.NET-8-blue)
![Status](https://img.shields.io/badge/status-production--ready-success)
![JWT](https://img.shields.io/badge/auth-JWT-orange)
![License](https://img.shields.io/badge/license-MIT-green)

---

## 💡 Overview

This project implements a **secure authentication API** using ASP.NET Core, designed to simulate real-world enterprise and financial systems.

It provides user registration, login, JWT token generation, and role-based authorization for protected resources.

---

## 💼 Business Context

Authentication is a critical component in modern systems, especially in **banking, fintech, and enterprise applications**.

This project demonstrates how authentication flows are implemented in production environments, including:

* Identity validation
* Secure credential storage
* Token-based authentication
* Role-based access control

---

## 🚀 Features

* User registration with validation
* Secure password hashing (no plain text)
* Login with credential verification
* JWT token generation
* Role-based authorization (User / Admin)
* Protected endpoints
* Admin-only access control

---

## 🏗 Architecture

Controllers → API layer
Services → Business logic
Data → Database context (EF Core)
Models → Domain entities
DTOs → Input/output contracts

---

## 🔐 Authentication Flow

1. User registers with email and password
2. Password is hashed before being stored
3. User logs in with valid credentials
4. API generates a JWT token
5. Token is used to access protected endpoints
6. Role-based access controls admin routes

---

## 📌 API Endpoints

### Register

POST `/api/auth/register`

```json
{
  "fullName": "Edemar Costa",
  "email": "edemar@email.com",
  "password": "123456",
  "role": "Admin"
}
```

---

### Login

POST `/api/auth/login`

```json
{
  "email": "edemar@email.com",
  "password": "123456"
}
```

---

### Protected Endpoint

GET `/api/secure/profile`

```
Authorization: Bearer YOUR_TOKEN
```

---

### Admin Only

GET `/api/secure/admin`

```
Authorization: Bearer YOUR_TOKEN
```

---

## 🔑 Example JWT Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

---

## ▶️ How to Run

```bash
dotnet run
```

Swagger:

```
https://localhost:7018/swagger
```

---

## 🧠 Business Rules

* Unique email per user
* Password stored securely (hash)
* Invalid login returns unauthorized
* JWT required for protected endpoints
* Admin routes require role validation

---

## 🔒 Security Decisions

* Password hashing (no plain text)
* JWT with claims (id, email, role)
* Token expiration
* Role-based access control

---

## 📸 API Preview (Recommended)

👉 Add a screenshot or GIF here to show:

* Register
* Login
* Token usage

---

## 📈 Future Improvements

* Refresh tokens
* Email confirmation
* Password reset flow
* Strong password validation
* Clean Architecture
* Unit tests
* Docker support

---

## 👨‍💻 Author

**Edemar Costa Oliveira**

* GitHub: https://github.com/edemarcosta
* LinkedIn: https://www.linkedin.com/in/edemar-costa-oliveira

---

## ⭐ Portfolio Context

This project is part of a backend portfolio demonstrating:

* Authentication systems
* Security best practices
* JWT implementation
* Real-world API design

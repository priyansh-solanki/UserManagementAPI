# UserManagementAPI

This is a .NET 6 Web API project developed for TechHive Solutions. It provides CRUD operations for managing users, and includes middleware for logging, authentication, and error handling.

## 🚀 Features

- CRUD API for User management
- Middleware for:
  - Logging HTTP requests/responses
  - Global exception handling
  - Token-based authentication
- Designed with modularity and performance in mind
- Copilot-assisted development and debugging

## 📦 Endpoints

| Method | Route            | Description             |
|--------|------------------|-------------------------|
| GET    | `/users`         | Get all users           |
| GET    | `/users/{id}`    | Get user by ID          |
| POST   | `/users`         | Add a new user          |
| PUT    | `/users/{id}`    | Update user             |
| DELETE | `/users/{id}`    | Delete user             |

## 🔧 Setup Instructions

```bash
# Clone the repository
git clone https://github.com/YOUR_USERNAME/UserManagementAPI.git
cd UserManagementAPI

# Run the project
dotnet run

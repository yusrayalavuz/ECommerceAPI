# 🛒 ECommerceAPI

A RESTful backend API built with **ASP.NET Core 8** and **Entity Framework Core**, modeled after a real e-commerce dataset previously analyzed in a [Power BI project](https://github.com/yusrayalavuz/ETicaret_PowerBI_Veri_Analizi). This project demonstrates the backend layer of the same domain — from data analysis to API development.

---

## 🚀 Tech Stack

| Layer           | Technology                           |
| --------------- | ------------------------------------ |
| Framework       | ASP.NET Core 8 Web API               |
| ORM             | Entity Framework Core 8 (Code-First) |
| Database        | Microsoft SQL Server                 |
| Architecture    | Controller → Service → DbContext     |
| Documentation   | Swagger / OpenAPI                    |
| Version Control | Git & GitHub                         |

---

## 🏗️ Architecture

This project follows a layered architecture pattern:

```
HTTP Request
     ↓
Controller      → Handles HTTP requests/responses
     ↓
Service         → Business logic lives here
     ↓
DbContext       → Entity Framework Core
     ↓
SQL Server      → Database
```

---

## 📦 Features

- ✅ **Products** — Full CRUD with filtering (category, price range) and input validation
- ✅ **Users** — Secure GET endpoints using DTOs (sensitive fields excluded)
- ✅ **Orders** — Create orders with multiple items; unit prices fetched from DB (not from client)
- ✅ **Service Layer** — Business logic separated from controllers
- ✅ **DTO Pattern** — Request/response models decoupled from database entities
- ✅ **Data Validation** — `[Required]`, `[Range]`, `[MinLength]` attributes with Turkish error messages
- ✅ **Seed Data** — Sample products, users, and addresses auto-seeded on startup
- ✅ **Swagger UI** — Interactive API documentation

---

## 🗂️ Project Structure

```
ECommerceAPI/
├── Controllers/
│   ├── ProductsController.cs
│   ├── UsersController.cs
│   └── OrdersController.cs
├── Services/
│   ├── IProductService.cs
│   └── ProductService.cs
├── Models/
│   ├── Product.cs
│   ├── User.cs
│   ├── Order.cs
│   ├── OrderItem.cs
│   └── Address.cs
├── DTOs/
│   ├── CreateProductDto.cs
│   ├── UserDto.cs
│   ├── CreateOrderDto.cs
│   └── OrderResponseDto.cs
├── Data/
│   ├── AppDbContext.cs
│   └── DbSeeder.cs
├── Migrations/
└── Program.cs
```

---

## 🔌 API Endpoints

### Products

| Method | Endpoint             | Description                            |
| ------ | -------------------- | -------------------------------------- |
| GET    | `/api/products`      | List all products (supports filtering) |
| GET    | `/api/products/{id}` | Get product by ID                      |
| POST   | `/api/products`      | Create new product                     |
| PUT    | `/api/products/{id}` | Update product                         |
| DELETE | `/api/products/{id}` | Delete product                         |

**Filtering examples:**

```
GET /api/products?category1=OYUNCAK
GET /api/products?minPrice=5&maxPrice=20
GET /api/products?category1=SEBZE&maxPrice=10
```

### Users

| Method | Endpoint          | Description                                      |
| ------ | ----------------- | ------------------------------------------------ |
| GET    | `/api/users`      | List all users (DTO — sensitive fields excluded) |
| GET    | `/api/users/{id}` | Get user by ID                                   |

### Orders

| Method | Endpoint           | Description                                |
| ------ | ------------------ | ------------------------------------------ |
| GET    | `/api/orders`      | List all orders with items                 |
| GET    | `/api/orders/{id}` | Get order by ID                            |
| POST   | `/api/orders`      | Create order (auto-calculates total price) |

**Create order example:**

```json
{
  "userId": 1,
  "addressId": 1,
  "items": [
    { "productId": 1, "amount": 2 },
    { "productId": 3, "amount": 1 }
  ]
}
```

---

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server) (Developer or Express edition)
- [SSMS](https://aka.ms/ssmsfullsetup) (optional)

### Run Locally

```bash
git clone https://github.com/yusrayalavuz/ECommerceAPI.git
cd ECommerceAPI
```

Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Swagger UI will be available at `http://localhost:5140/swagger`

---

## 📊 Background

This project complements my [E-Commerce Power BI Analytics project](https://github.com/yusrayalavuz/ETicaret_PowerBI_Veri_Analizi), where I analyzed the same e-commerce dataset using MS SQL Server, Power Query, and DAX. Here I'm building the backend API layer of the same domain — bridging data analysis and backend development.

---

## 📬 Contact

**Yüsra Yalavuz** · [LinkedIn](https://linkedin.com/in/yusra-yalavuz) · [GitHub](https://github.com/yusrayalavuz) · [Portfolio](https://yusra-yalavuz.vercel.app)

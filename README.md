# 🛒 ECommerceAPI

A RESTful backend API built with **ASP.NET Core 8** and **Entity Framework Core**, designed to power an e-commerce platform. This project is actively under development.

---

## 🚀 Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 8 Web API |
| ORM | Entity Framework Core (Code-First) |
| Database | Microsoft SQL Server |
| Documentation | Swagger / OpenAPI |
| Version Control | Git & GitHub |

---

## 📦 Features (In Progress)

- [x] Project setup & architecture
- [ ] Product & Category CRUD endpoints
- [ ] Order management (create, list, detail)
- [ ] Filtering & pagination (by category, price range)
- [ ] Input validation & global error handling
- [ ] Unit tests

---

## 🗂️ Project Structure

```
ECommerceAPI/
├── Controllers/        # API endpoints
├── Models/             # Entity classes (Product, Category, Order)
├── Data/               # DbContext & Migrations
├── DTOs/               # Data Transfer Objects
├── Services/           # Business logic
└── ECommerceAPI.sln
```

---

## 🛠️ Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server) (Developer or Express edition)
- [SSMS](https://aka.ms/ssmsfullsetup) (optional, for DB management)

### Run Locally

```bash
git clone https://github.com/yusrayalavuz/ECommerceAPI.git
cd ECommerceAPI
dotnet restore
dotnet ef database update
dotnet run
```

API will be available at `https://localhost:5001` and Swagger UI at `https://localhost:5001/swagger`.

---

## 📊 Background

This project complements my [E-Commerce Power BI Analytics project](https://github.com/yusrayalavuz/ETicaret_PowerBI_Veri_Analizi), where I analyzed e-commerce data using MS SQL Server, Power Query, and DAX. Here I'm building the backend layer of the same domain — from data analysis to API development.

---

## 📬 Contact

**Yüsra Yalavuz** · [LinkedIn](https://linkedin.com/in/yusra-yalavuz) · [GitHub](https://github.com/yusrayalavuz)

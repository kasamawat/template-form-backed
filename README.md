# Template Form Back-End

> Back-end repository for “Template Form” project (Pre-Test)  
> Built with C# .NET (ASP.NET Core)  

---

## 📍 Table of Contents

- [Project Overview](#project-overview)  
- [Tech Stack](#tech-stack)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Installation](#installation)  
  - [Running the Application](#running-the-application)  
- [Project Structure](#project-structure)  
- [API Endpoints](#api-endpoints)  
- [Database & Migrations](#database-&-migrations)  
- [Deployment](#deployment)  
- [Contributing](#contributing)  
- [License](#license)  
- [Contact](#contact)

---

## 🧭 Project Overview

This repository contains the back-end of the “Template Form” application designed as part of a **Pre-Test** assignment.  
It provides RESTful API services to support form templates, submission storage, authentication/authorization (if any), and data retrieval.  
Built with **ASP.NET Core** and possibly Entity Framework Core for data access.

---

## 🛠 Tech Stack

| Layer           | Technology                            |
|-----------------|---------------------------------------|
| Framework       | ASP.NET Core                          |
| Language        | C#                                    |
| Data Access     | Entity Framework Core (EF Core)       |
| Database        | SQL Server / PostgreSQL / MySQL (choose one) |
| Version Control | Git & GitHub                          |

---

## 🚀 Getting Started

### Prerequisites  
Make sure you have installed the following:  
- .NET SDK (recommend latest LTS version)  
- A supported database server (e.g., SQL Server, PostgreSQL)  
- (Optional) IDE like Visual Studio or VS Code  

### Installation  
1. Clone the repo:  
   ```bash
   git clone https://github.com/kasamawat/template-form-backed.git
   cd template-form-backed
2. Install Dependencies
    ```bash
    dotnet restore
3. Configure the database connection string
    ```bash
    Update `appsettings.json` with your database connection details.
    "ConnectionStrings": 
        "DefaultConnection": "Server=YOUR_SERVER;Database=TemplateFormDb;Trusted_Connection=True;MultipleActiveResultSets=true"

### Runing the Application
```bash
dotnet run --project YourProjectName
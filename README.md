# Microservices Demo

This project demonstrates a simple **microservices architecture** built with **.NET Core, Docker, and MongoDB**.

---

## 🔧 Tech Stack
- .NET 6 (C#)
- Docker & Docker Compose
- MongoDB
- REST APIs

---

## 📂 Services
- **Users Service** – manages user accounts
- **Orders Service** – handles order creation and tracking
- **API Gateway** – routes traffic between services

---

## 🚀 Getting Started

### 1. Clone the repo
```bash
git clone https://github.com/milannedeljkovic-webdev/microservices-demo-.git
cd microservices-demo-
```

### 2. Run with Docker Compose
```bash
docker-compose up --build
```

### 3. Access APIs
- Users API → http://localhost:5000/api/users  
- Orders API → http://localhost:5001/api/orders

---

## 📝 Notes / Next steps
- Ensure Docker Desktop is running and ports 5000/5001 are available.
- Add an `.env` or `docker-compose.override.yml` if you need to configure MongoDB credentials, environment variables or ports.
- Consider adding health endpoints, OpenAPI docs (Swagger) per service, and a root README section that explains how to run tests and apply migrations if any.
- If this is a monorepo for multiple services, add a top-level `docker-compose.yml` that orchestrates all services and a `README-root.md` linking to each service's README.

---

## 📫 About Me
Backend Developer specializing in C#, .NET Core, Microservices, Docker, and Cloud.

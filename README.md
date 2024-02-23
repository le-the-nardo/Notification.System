# Notification.System

Notification.System is a messaging system built to efficiently handle message notifications across various channels such as SMS, Email, and Push Notifications. 
The system is designed to categorize messages and notify users subscribed to specific categories through their preferred channels.

## Table of Contents
- [Features](#features)
- [Architecture](#architecture)
- [Contributing](#contributing)
- [License](#license)

## Features
- Categorization of messages
- Multi-channel notification delivery (SMS, Email, Push Notification)
- RESTful API with two main endpoints: `POST /api/Message` and `GET /api/Messages`
- Built with C# .Net Core 8, following Domain-Driven Design (DDD) and Clean Architecture principles

## Technologies
- C# .Net Core 8
- Entity Framework Core
- ASP.NET Core Web API
- (Add any other technologies used in the project)

## Architecture
The project adheres to the principles of Domain-Driven Design (DDD) and Clean Architecture to ensure maintainability, scalability, and flexibility.

Notification.System
|-- Application
  |-- Interfaces
  |-- UseCases
|-- Domain
  |-- Entities
  |-- Mocks
  |-- 
|-- Infrastructure
  |-- Models
  |-- Repositories
  |-- Services
|-- Presentation
|-- WebApi
  |-- Controllers
  |-- DTOs

## Contributing
Feel free to contribute by opening issues, providing feedback, or submitting pull requests.

## Author
Made with a lot of ☕ and ❤ by me, Leonardo.

## License
This project is licensed under the [MIT License](LICENSE).

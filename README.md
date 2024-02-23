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
- Clean code to ensure code readability
- Unit testing to ensure code quality

## Technologies
- C# .Net Core 8
- ASP.NET Core Web API
- Dependency Injection
- Design Pattners
- Unit testing with xUnit and Moq

## Architecture
The project adheres to the principles of Domain-Driven Design (DDD) and Clean Architecture to ensure maintainability, scalability, and flexibility.

```
Notification.System
|-- src
  |-- Application
  |-- Domain
  |-- Infrastructure
  |-- Presentation
  |-- WebApi
|-- unit tests
```

## Contributing
Feel free to contribute by opening issues, providing feedback, or submitting pull requests.

## Author
Made with a lot of ☕ and ❤ by me, Leonardo.

## License
This project is licensed under the [MIT License](LICENSE).

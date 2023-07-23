# Microservices Architecture with .NET - Beginner Level Course 

Course[https://youtu.be/CqCDOosvZIk]

Learn the foundational elements of a microservices architecture with .NET in this beginner level course. You will incrementally building a real microservices-based application with the .NET platform and C#.

# Course Overview 
In this course, we will take you through a step-by-step journey to demystify the world of microservices architecture. You'll learn how to break down a monolithic application into smaller, independently deployable microservices, enabling you to develop, test, and deploy each component individually. By the end of this course, you will be able to grasp the fundamental concepts behind microservices and have hands-on experience building a basic microservices-based application using the .NET ecosystem.


# ⭐️ Course Contents ⭐️
- (0:00:14) Module 1- Welcome to the course!
- (0:04:52) Development environment setup
- (0:12:39) Customizing VS Code for C# Development
- (0:17:37) What's wrong with the monolith?
- (0:25:32) What are microservices?

- (0:35:18) Module 2- Your first microservice
- (0:35:53) Creating a microservice via the .NET CLI
- (0:45:46) Introduction to the REST API and DTOs
- (0:47:35) Adding the DTOs
- (0:50:52) Adding the REST API operations
- (1:15:57) Handling invalid inputs

- (1:27:04) Module 3- Adding database storage
- (1:27:51) Introduction to the repository pattern and MongoDB
- (1:30:13) Implementing a MongoDB repository
- (1:44:18) Using the repository in the controller
- (1:55:11) Introduction to Docker
- (1:56:57) Trying out the REST API with a MongoDB container
- (2:09:50) Introduction to Dependency Injection and Configuration
- (2:14:47) Implementing dependency injection and configuration

- (2:31:40) Module 4- Preparing for the next microservice
- (2:32:37) Using Postman
- (2:48:01) Reusing common code via NuGet
- (2:52:12) Refactoring into a generic MongoDB repository
- (3:03:02) Refactoring MongoDB registration into extension methods
- (3:10:07) Moving generic code into a reusable NuGet package
- (3:26:04) Introduction to Docker Compose
- (3:28:24) Moving MongoDB to docker compose

- (3:39:18) Module 5- Synchronous inter-service communication
- (3:40:12) Creating the Inventory microservice
- (4:06:47) Introduction to synchronous communication
- (4:10:29) Implementing synchronous communication via IHttpClientFactory
- (4:22:15) Understanding timeouts and retries with exponential backoff
- (4:25:45) Implementing a timeout policy via Polly
- (4:35:41) Implementing retries with exponential backoff
- (4:46:53) Understanding the circuit breaker pattern
- (4:49:59) Implementing the circuit breaker pattern

- (4:56:36) Module 6- Asynchronous inter-service communication
- (4:57:31) Introduction to asynchronous communication
- (5:07:23) Defining the message contracts
- (5:11:09) Publishing messages via MassTransit
- (5:22:21) Standing up a RabbitMQ docker container
- (5:30:04) Refactoring MassTransit configuration into the reusable NuGet package
- (5:41:11) Consuming messages for eventual data consistency
- (6:01:54) Removing the inter-service synchronous communication

- (6:16:32) Module 7- Initial Frontend Integration
- (6:17:02) Installing Node.js
- (6:20:13) Getting started with the frontend
- (6:34:55) Understanding CORS
- (6:40:50) Adding the CORS middleware
- (6:46:49) Exploring the frontend to microservices communication

- (7:05:18) Next Steps
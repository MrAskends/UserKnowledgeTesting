# UserKnowledgeTesting
**UserKnowledgeTesting** is a complete C# Windows Forms **client-server application** for testing users on various topics.  
It includes user registration/login, quiz delivery using JSON files with full serialization/deserialization, and result storage via a MySQL database.  
The system supports multiple user roles (e.g. admin, user) and was created as a capstone-style university project.

## Project Goals
- Build a real client-server architecture in C#
- Practice object-oriented design and multi-form UI
- Work with external data formats like **JSON**
- Store and query data from a **MySQL** database
- Implement role-based login and session handling

## Features

### Client
- User registration and login
- Quiz interface with timed questions (from JSON)
- View test results
- Clean WinForms interface

### Server
- Accepts connections from multiple clients
- Sends questions & receives answers
- Stores data in MySQL database
- Handles clients using multithreading

## Data & Storage
- Questions and answers stored in **JSON files**
- User data and test results stored in **MySQL**
- Communication between client & server via sockets (TCP)

## Technologies
- C# (.NET Framework)
- WinForms
- MySQL
- Newtonsoft.Json
- Multithreading
- TCP Sockets
- Visual Studio 2019

## Getting Started

```bash
git clone https://github.com/MrAskends/UserKnowledgeTesting.git
```

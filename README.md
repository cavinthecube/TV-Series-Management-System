# ITPCA Q1 CODE

# TV Series Management System

## Description

The TV Series Management System is a C# console-based application that allows users to manage a collection of television series. The system provides functionality to capture, search, update, delete, and generate reports for series stored within the application.

This project was created to practice object-oriented programming concepts, data management using collections, and implementing user input validation in C#.

## Features

- Capture new series
- Search for a series using its ID
- Update existing series information
- Delete series from the system
- Display a report of all stored series
- Validate user input
- Handle invalid numeric inputs using exception handling

## Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming (OOP)
- Collections (List<T>)

## Concepts Practiced

### Object-Oriented Programming
- Classes and objects
- Encapsulation
- Separation of data models and application logic

### Collections
- Using `List<T>` to store and manage multiple series records

### Exception Handling
- Implemented `try-catch` blocks to handle invalid user input and prevent application crashes

### Input Validation
- Prevents empty series IDs and names
- Validates age restrictions
- Ensures numeric values are entered correctly

## System Functions

### Capture Series
Allows users to add a new series by entering:
- Series ID
- Series name
- Age restriction
- Number of episodes

### Search Series
Users can search for a series by entering its unique ID. If found, the system displays all stored information about the series.

### Update Series
Allows users to modify existing series information, including:
- Series name
- Age restriction
- Number of episodes

### Delete Series
Users can remove a series from the system after confirming the deletion request.

### Series Report
Displays all series currently stored in the system with their details.



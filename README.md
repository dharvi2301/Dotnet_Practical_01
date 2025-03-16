# Dotnet_Practical_01
This is the repository that consist of the Dotnet Practical 01 of LMS

# Calculator Application

## Overview
This is a simple console-based calculator application developed in C#. The application demonstrates fundamental concepts of Object-Oriented Programming (OOP) and allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division.

## Features
- Accepts user input for two integer numbers.
- Performs basic arithmetic operations: Addition, Subtraction, Multiplication, and Division.
- Handles division by zero scenarios.
- Uses a modular approach following OOP principles.

## Implementation Details
The application consists of three primary classes:

### 1. **Program Class (Entry Point)**
Located in `Program.cs`, this is the entry point of the application where the execution begins.

- Creates instances of `UserInput` and `Calculator` classes.
- Accepts two integer inputs from the user.
- Calls methods from the `Calculator` class to perform arithmetic operations.
- Displays results on the console.
- Handles division by zero scenarios.

### 2. **Calculator Class**
Located in `Calculator.cs`, this class contains methods for basic arithmetic operations:

- `Add(int a, int b)`: Returns the sum of two integers.
- `Subtract(int a, int b)`: Returns the difference of two integers.
- `Multiply(long a, long b)`: Returns the product of two numbers.
- `Divide(float a, float b)`: Returns the quotient of two numbers while checking for division by zero.

### 3. **UserInput Class**
Located in `UserInput.cs`, this class is responsible for handling user input.

- `GetIntegerInput(string message)`:  
  - Prompts the user to enter an integer.  
  - Uses `int.TryParse` to validate input.  
  - Ensures that only numeric values are accepted.  

## Object-Oriented Programming (OOP) Concepts Used
### 1. **Encapsulation**
Encapsulation is achieved by grouping related functions within dedicated classes (`UserInput` for user input handling and `Calculator` for calculations). This ensures modularity and separation of concerns.

### 2. **Abstraction**
The `Calculator` class abstracts mathematical operations, hiding implementation details from the `Program` class. Similarly, `UserInput` abstracts input validation logic.

### 3. **Modularity**
Each class serves a specific purpose, enhancing readability and maintainability.  

### 4. **Error Handling**
- The `GetIntegerInput` method ensures that only valid integers are accepted.
- The `Divide` method checks for division by zero to prevent runtime errors.

## How to Run the Application
1. Clone the repository or copy the source files.
2. Open the project in Visual Studio or any C# IDE.
3. Build and run the application.
4. Enter two integer values when prompted.
5. View the calculated results displayed on the console.

## Future Enhancements
- Implement more mathematical functions such as modulus, exponentiation, and square root.
- Enhance error handling and introduce exception handling.
- Implement a graphical user interface (GUI) using WinForms or WPF.

## Conclusion
This project demonstrates the implementation of a simple calculator using C# while following OOP principles. The structured approach ensures code reusability, maintainability, and scalability.


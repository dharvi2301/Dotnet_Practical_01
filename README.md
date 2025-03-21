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

# Below is the attached Screenshot for the Calculator Application Output
## Without Error (Positive Integers)
![image](https://github.com/user-attachments/assets/2a36e5d0-3d6c-4896-b540-83842db00e70)

## Without Error (Negative Integers)
![image](https://github.com/user-attachments/assets/2b1521a3-2a29-4526-af0d-2e4bd11b5fb9)

## With Divisibility Error 
![image](https://github.com/user-attachments/assets/c14c4c27-4495-4dd0-97d1-d4afb40fdae5)

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Debugging Application

## Description
This is a simple C# console application that reads user input, converts it into an integer, and then evaluates whether it is a truthy value. If the entered value is nonzero, it prints "The entered value is an integer." The program includes a debug point for debugging purposes.

## Features
- Reads user input from the console.
- Converts the input into an integer.
- Evaluates the integer as a boolean value.
- Prints a message if the value is nonzero.
- Contains a debug point for analysis.

## Prerequisites
- .NET SDK installed on your system.
- A C#-compatible IDE or a text editor (e.g., Visual Studio, Visual Studio Code).

- # Below is the attached Screenshot for the Debugging Application Output
- ## By entering the integer you will get the below output
- ![image](https://github.com/user-attachments/assets/60992a57-f9c0-4838-b08a-1bd652be2064)

- ## By entering the 0 you will get no output
![image](https://github.com/user-attachments/assets/a04c18b2-0295-4b39-bc7c-c1d4c4ed84df)

## By entering the input as the string you will notice the below exception is been thrown
![image](https://github.com/user-attachments/assets/07381201-d364-47fb-b622-6e510d54fa4b)










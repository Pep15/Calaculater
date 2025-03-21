﻿# Calculator

This project is a simple calculator application developed using C# and Windows Forms. It provides basic arithmetic operations: addition, subtraction, multiplication, and division.

## Features

* User-friendly graphical interface.
* Performs basic arithmetic operations (+, -, *, /).
* Displays results on the application screen.
* "AC" button to reset the calculator.
* Handles division by zero.

## How to Use

1.  Run the application.
2.  Click the numbers to input values.
3.  Select the desired arithmetic operation (+, -, X, ÷).
4.  Enter the second number.
5.  Click the "=" button to display the result.
6.  Click the "AC" button to reset the calculator.

## Requirements

* Visual Studio (or any other C# development environment).
* .NET Framework.

## Architecture

* `Form1.cs`: Contains the application logic and user interface.
* `Form1.Designer.cs`: Contains the user interface design.
* `Program.cs`: Application entry point.

## Implementation Details

* The application uses `struct stCalaculater` to store input numbers.
* `enum EnOperations` is used to define arithmetic operations.
* `enum EnNumbers` is used to determine whether the input number is the first or second number.
* Division by zero is handled by returning 1 in the event that this occurs.
* The display screen (`lbScreen`) is updated to show numbers and results.

## Author

[Moath Aljmaan]


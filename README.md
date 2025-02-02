# Simple Calculator: Visual Basic
A simple calculator application built using Windows Forms in Visual Basic. The calculator supports basic arithmetic operations (addition, subtraction, multiplication, and division), as well as a history feature that keeps track of previous calculations. The application also includes a clear button, backspace functionality, and an exit button.

## Features
- Basic arithmetic operations (+, -, *, /)
- Clear button to reset the display
- Backspace button to remove the last character
- History list to view previous calculations
- Exit button to close the application

## Usage
- Use the number buttons (0-9) to input numbers.
- Use the operator buttons (+, -, *, /) to perform arithmetic operations.
- Press the "=" button to calculate the result.
- Use the "Clear" button to reset the display.
- Use the "←" button to remove the last character.
- The "Exit" button closes the application.
- The history list at the bottom shows previous calculations.

## Code Overview
The main form (Form1) contains the UI elements and event handlers for the calculator. The Button_Click method handles number and operator button clicks, while the btnEquals_Click method evaluates the expression and displays the result. The EvaluateExpression function uses a DataTable to compute the result of the expression.

## License
This project is licensed under the MIT License.

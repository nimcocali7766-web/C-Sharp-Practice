# Processing Data

## Topics

- 3.1 Reading Input with TextBox Controls
- 3.2 A First Look at Variables
- 3.3 Numeric Data Types and Variables
- 3.4 Performing Calculations
- 3.5 Inputting and Outputting Numeric Values
- 3.6 Formatting Numbers with the ToString Method
- 3.7 Simple Exception Handling
- 3.8 Using Named Constants

## 3.1 Reading Input with TextBox Controls

- A TextBox control is a rectangular area that can accept keyboard input from the user.
- It is located in the Common Controls group of the Toolbox. Double-click it to add it to the form.
- The default name is `textBoxn`, where n is 1, 2, 3, ...

### The Text Property

- A TextBox control's Text property stores the user's input.
- The Text property accepts only string values, e.g.:

```csharp
textBox1.Text = "Hello";
```

- To clear the content of a TextBox control, assign an empty string (""):

```csharp
textBox1.Text = "";
textBox1.Text = string.Empty;
textBox1.Clear();
```

## 3.2 A First Look at Variables

- A variable is a storage location in memory. A variable name represents the memory location.
- In C#, you must declare a variable in a program before using it to store data.
- The syntax to declare variables is:

```csharp
DataType VariableName;
```

### Data Types

- A variable must be declared with a proper data type.
- The data type specifies the type of data a variable can hold.
- Many data types are known as primitive data types. In C#, they store fundamental types of data such as strings and integers.
- "Primitive" means basic / simple / built-in. In C#, primitive data types are already defined by the language, not created by you.

### Variable Names

- A variable name identifies a variable. Always choose a meaningful name for variables.
- Basic naming conventions:
  - The first character must be a letter (uppercase or lowercase) or an underscore (\_).
  - The name cannot contain spaces.
  - Do not use C# keywords or reserved words.

### String Variables

- A string is a combination of characters.
- A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers.
- The value of a string variable is assigned on the right of the = operator, surrounded by a pair of double quotes:

```csharp
productDescription = "Jamhuuriya University";
```

- The following assigns the productDescription string to a Label control named productLabel:

```csharp
productLabel = productDescription;
```

- You can also display a string variable in a Message Box:

```csharp
MessageBox.Show(productDescription);
```

### String Concatenation

- Concatenation is the appending of one string to the end of another string.
- The + operator is used for concatenation.
- Concatenation can happen between a string and another data type (int and string, double and string):

```csharp
12 + " apples";
"Total is " + 25.75;
```

### Declaring Variables Before Using Them

- You can declare variables and use them later (see the `showNameButton_Click` example in the chapter slides, which declares a string variable for the full name, combines the first and last names, and displays the result in a Label).

### Local Variables and Scope

- A local variable belongs to the method in which it was declared.
- Only statements inside that method can access the variable.
- Scope describes the part of a program in which a variable may be accessed.
- Lifetime of a variable is the time period during which the variable exists in memory while the program is executing.
- A local variable is created in memory when the method in which it is declared starts executing. When the method ends, all the method's local variables are destroyed.

### Duplicate Variable Names

- You cannot declare two variables with the same name in the same scope.
- You can, however, have variables of the same name declared in different methods.

### Assignment Compatibility

- You can assign a value to a variable only if the value is compatible with the variable's data type.
- Only strings are compatible with the string data type.

### Initializing Variables

- In C#, a variable must be assigned a value before it can be used.
- The C# compiler will not compile code that tries to use an unassigned variable. You will get an error such as: `Use of unassigned local variable 'productDescription'`.

### Declaring Multiple Variables with One Statement

- You can declare multiple variables of the same data type with one declaration statement:

```csharp
string lastName, firstName, middleName;
```

- A long statement can be broken across two or more lines:

```csharp
string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";
```

## 3.3 Numeric Data Types and Variables

- If you need to store a number in a variable and use it in a mathematical operation, the variable must be of a numeric data type.
- Commonly used numeric data types:
  - `int`: whole numbers (up to 2,147,483,647)
  - `double`: real numbers, including numbers with fractional parts
  - `decimal`: real numbers, stored with greater precision than doubles. Typically used in financial applications.

### Numeric Literals

- A numeric literal is a number that is written into a program's code.

```csharp
int hoursWorked = 40;
double temperature = 87.6;
```

- The literal value cannot be surrounded by quotes.
- Integer literals such as 40 and 99 are treated as an int.
- Numeric literals with a decimal point, such as 87.6, 3.14, and 1.0, are treated as a double.
- To create a decimal literal, append the letter M or m to a numeric literal:

```csharp
decimal payRate = 28.75m;
```

### Assignment Compatibility for int Variables

- You can assign int values to int variables, but you cannot assign double or decimal values to int variables.

```csharp
int hoursWorked = 40;    // This works
int unitsSold = 650m;    // ERROR!
int score = -25.5;       // ERROR!
```

### Assignment Compatibility for double Variables

- You can assign either double or int values to double variables, but you cannot assign decimal values to double variables.

```csharp
double distance = 28.75;  // This works
double speed = 75;        // This works
double sales = 6500.0m;   // ERROR!
```

### Assignment Compatibility for decimal Variables

- You can assign either decimal or int values to decimal variables, but you cannot assign double values to decimal variables.

```csharp
decimal balance = 9280.73m;  // This works
decimal price = 50;          // This works
decimal sales = 6500.0;      // ERROR!
```

### Explicit Conversion with Cast Operators

- C# allows you to explicitly convert among types, which is known as type casting.
- You can use the cast operator, which is simply the name of the type enclosed in parentheses.

```csharp
int wholeNumber;
decimal moneyNumber = 4500m;
wholeNumber = (int)moneyNumber;

double realNumber;
decimal moneyNumber = 625.70m;
realNumber = (double)moneyNumber;
```

### Declaring Local Variables with the var Keyword

- `var` is a keyword you can use instead of writing the full type of a variable.
- The compiler automatically figures out the type from the value you assign (this is called type inference).

```csharp
var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;
```

- You must provide an initialization value when declaring a variable with `var`.
- The compiler determines the variable's data type from the initialization value.
- The `var` keyword can be used only to declare local variables (variables declared inside a method).

## 3.4 Performing Calculations

- Basic calculations such as arithmetic can be performed with math operators:

| Operator | Name of the operator | Description                                           |
| -------- | -------------------- | ----------------------------------------------------- |
| +        | Addition             | Adds two numbers                                      |
| -        | Subtraction          | Subtracts one number from another                     |
| \*       | Multiplication       | Multiplies one number by another                      |
| /        | Division             | Divides one number by another and gives the quotient  |
| %        | Modulus              | Divides one number by another and gives the remainder |

### Rules for Performing Calculations

- A math expression performs a calculation and gives a value.

```csharp
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());
```

- Be sure to follow the order of operations and group with parentheses if necessary:

```csharp
result = (a + b) / 4;
```

- In a calculation of mixed data types, the data type of the result is determined by:
  - An int and a double: int is treated as double and the result is double.
  - An int and a decimal: int is treated as decimal and the result is decimal.
  - An operation involving a double and a decimal is not allowed.

### Integer Division

- When you divide an integer by an integer in C#, the result is always given as an integer. The result of the following is 2:

```csharp
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());
```

- This is known as integer division. To avoid it:

```csharp
int x = 7, y = 3;
MessageBox.Show(((double)x / y).ToString());

double x = 7, y = 3;
MessageBox.Show((x / y).ToString());
```

## 3.5 Inputting and Outputting Numeric Values

- Input collected from the keyboard is considered a combination of characters (strings) even if it looks like a number to you.
- A TextBox control reads keyboard input, such as 25.65, but treats it as a string, not a number.
- To assign a TextBox value to a numeric variable, you have to convert the control's Text property to the desired numeric data type. You cannot use a cast operator to convert a string to a numeric type.
- In C#, use the following Parse methods to convert a string to numeric data types:
  - `int.Parse`
  - `double.Parse`
  - `decimal.Parse`

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
```

### Displaying Numeric Values

- The Text property of a control only accepts strings.
- To display a number in a TextBox or Label control, you need to convert the numeric data to string type.
- In C#, all variables work with the ToString method to convert the value of the variable to a string. The general format is `variableName.ToString()`:

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());
```

- Another option is implicit string conversion with the + operator:

```csharp
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

## 3.6 Formatting Numbers with the ToString Method

- The ToString method can optionally format a number to appear in a specific way.

| Format String | Description                   | Number     | ToString()     | Result          |
| ------------- | ----------------------------- | ---------- | -------------- | --------------- |
| "N" or "n"    | Number format                 | 12.3       | ToString("n3") | 12.300          |
| "F" or "f"    | Fixed-point scientific format | 123456.0   | ToString("f2") | 123456.00       |
| "E" or "e"    | Exponential scientific format | 123456.0   | ToString("e3") | 1.235e+005      |
| "C" or "c"    | Currency format               | -1234567.8 | ToString("C")  | ($1,234,567.80) |
| "P" or "p"    | Percentage format             | .234       | ToString("P")  | 23.40%          |

## 3.7 Simple Exception Handling

- An exception is an unexpected error that happens while a program is running (exceptions = runtime errors). Example errors:
  - Dividing by zero
  - Trying to open a file that does not exist
  - Invalid user input
- If an exception is not handled by the program, the program will abruptly halt.
- Exception handling is writing special code that catches errors and tells the program what to do instead of crashing. This code is called an exception handler.

### Handling Exceptions with try-catch

General format of the try-catch statement:

```csharp
try
{
    statement;
    statement;
    etc.
}
catch
{
    statement;
    statement;
    etc.
}
```

- The try block is where you place the statements that can cause an exception.
- The catch block is where you place statements that respond to the exception when it happens.

### Throwing an Exception

- In the MPG example on the slides, if the user enters nonnumeric data into the miles text box, an exception is thrown at the `double.Parse` statement.
- The program then jumps to the catch clause and executes the statements in the catch block (it displays "Invalid data was entered.").

### What is the Difference: Throwing vs. Catching

- Throwing = raising the error (a problem occurs).
- Catching = handling the error (deciding what to do about it).
- Real-life examples:
  - ATM machine: you enter your PIN incorrectly three times.
    - Throwing: the ATM raises an error ("Invalid PIN").
    - Catching: instead of shutting down, the ATM shows a friendly message: "Invalid PIN, please try again."
  - Car driving: your car runs out of fuel while driving.
    - Throwing: the car has a problem (fuel is empty).
    - Catching: the dashboard shows a warning light instead of letting the engine suddenly die without warning.

### Displaying an Exception's Default Message

- Every exception (error) in C# is an object.
- That object has a property called Message which stores a description of the error.
- You can use the following format to display the exception's error message:

```csharp
try
{
    statement;
    statement;
    etc.
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

## 3.8 Using Named Constants

- A named constant is a name that represents a value that cannot be changed during the program's execution.
- In C#, a constant can be declared with the `const` keyword:

```csharp
const double INTEREST_RATE = 0.129;
```

- Writing the name of a constant in uppercase letters is traditional in many programming languages but is not a requirement.

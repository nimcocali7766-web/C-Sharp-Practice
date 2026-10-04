# Introduction to C# - Code Examples

## Topics

-String Concatenation
-Clearing Text Property
-Integer Division and Type Casting
-Inputting and Outputting Numeric Values

## 1. String Concatenation

String concatenation allows combining multiple strings into one using the `+` operator.

The resulting string variable can then be passed to controls or dialogs.

The following screenshot shows the String Concatenation example.

![String Concatenation](Screenshots/StringConcatenation.png)

```csharp

```

## 2. Clearing Text Property

To clear or reset the contents of a `TextBox` control, you can assign an empty string `""`, use `string.Empty`, or call the `.Clear()` method.

The following screenshot shows how to clear a TextBox.

![Clearing Text Property](Screenshots/ClearingTextProperty.png)

```csharp

```

## 3. Integer Division and Type Casting

When dividing integers in C#, fractional parts are truncated unless explicit type casting to `double` or `float` is performed.

The following screenshot shows the Integer Division and Type Casting example.

![Integer Division and Type Casting](Screenshots/IntegerDivision.png)

```csharp

```

## 4. Inputting and Outputting Numeric Values

Text retrieved from controls like `TextBox` is of type `string`.

To perform calculations, these values must be parsed into numeric types using methods like `int.Parse()` or `double.Parse()`.

The following screenshot shows the Inputting and Outputting Numeric Values example.

![Inputting and Outputting Numeric Values](Screenshots/InputingandoutputingNumericValues.png)

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

double temperature = double.Parse(temperatureTextBox.Text);
```

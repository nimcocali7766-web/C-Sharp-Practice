# Introduction to C# - Chapter 3: Making Decisions

## Topics

- 4.1 Decision Structures and the `if` Statement
- 4.2 The `if-else` Statement
- 4.3 Nested Decision Structures
- 4.4 Logical Operators
- 4.5 `bool` Variables and Flags
- 4.6 Comparing Strings
- 4.7 Preventing Data Conversion Exceptions with the `TryParse` Method
- 4.8 Input Validation
- 4.9 Radio Buttons and Check Boxes
- 4.10 The `switch` Statement
- 4.11 Introduction to List Boxes

---

## 4.1 Decision Structures and the `if` Statement

A control structure is a logical design that controls the order in which
statements execute. A sequence structure is a set of statements that
execute in the order that they appear.

A decision structure executes statements only under certain
circumstances. A specific action is performed only if a certain
condition exists. It is also known as a selection structure.

The `if` statement is used to write a single-alternative decision
structure. Its expression is a Boolean expression that can be evaluated
as either `true` or `false`.

### Relational Operators

A relational operator determines whether a specific relationship exists
between two values.

Operator Meaning Example

---

`>` Greater than `x > y`
`<` Less than `x < y`
`>=` Greater than or equal to `x >= y`
`<=` Less than or equal to `x <= y`
`==` Equal to `x == y`
`!=` Not equal to `x != y`

### Example

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

---

## 4.2 The `if-else` Statement

An `if-else` statement executes one block of statements if its Boolean
expression is `true`, or another block if its Boolean expression is
`false`. It has two parts: an `if` clause and an `else` clause.

### General Format

```csharp
if (expression)
{
    statements;
}
else
{
    statements;
}
```

---

## 4.3 Nested Decision Structures

You can create nested decision structures to test more than one
condition. Nested means "one inside another."

### Example

```csharp
if (expression)
{
    if (expression)
    {
        statements;
    }
    else
    {
        statements;
    }
}
else
{
    statements;
}
```

### The `if-else-if` Statement

You can create a decision structure that evaluates multiple conditions
to make the final decision using the `if-else-if` statement.

```csharp
if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else
{
    statements;
}
```

---

## 4.4 Logical Operators

The logical AND operator (`&&`) and logical OR operator (`||`) allow you
to connect multiple Boolean expressions to create a compound expression.
The logical NOT operator (`!`) reverses the truth of a Boolean
expression.

---

Operator Meaning Description

---

`&&` AND Both subexpressions
must be true for the
compound expression to
be true.

`||` OR One or both
subexpressions must be
true for the compound
expression to be true.

`!` NOT Negates (reverses) the
value to its opposite.

---

### Examples

```csharp
// The && operator
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// The || operator
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// The ! operator
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```

---

## 4.5 `bool` Variables and Flags

You can store the values `true` or `false` in `bool` variables, which
are commonly used as flags.

A flag is a variable that signals when some condition exists in the
program.

- `false` indicates the condition does not exist.
- `true` indicates the condition exists.

---

## 4.6 Comparing Strings

You can use certain relational operators and methods to compare strings.

The `==` operator can compare two strings.

```csharp
if (name1 == name2)
{
}
```

You can compare string variables with string literals, too.

```csharp
if (name1 != "bob")
{
}
```

The `String.Compare` method can compare two strings.

```csharp
if (String.Compare(name1, name2) == 0)
{
}
```

---

## 4.7 Preventing Data Conversion Exceptions with the `TryParse` Method

Exceptions should be prevented when possible. The `TryParse` methods can
prevent exceptions caused by users entering invalid data.

Common methods include:

- `int.TryParse`
- `double.TryParse`
- `decimal.TryParse`

The generic syntax is:

```csharp
dataType.TryParse(string input, out targetVariable);
```

The `out` keyword is required; it specifies that the `targetVariable` is
an output variable.

---

## 4.8 Input Validation

Input validation is the process of inspecting data entered into a
program to make sure it is valid before it is used.

`TryParse` methods check whether the user entered data of the correct
data type, but they do not check the integrity of the data.

For example, in a payroll program, we might validate the number of hours
worked:

```csharp
if (hours > 0 && hours <= 168)
{
}
```

In a program that gets test scores, we can make sure the score is in the
range of 0 through 100:

```csharp
if (testScore >= 0 && testScore <= 100)
{
}
```

### Using `TryParse`

```csharp
int hours;

if (int.TryParse(textBox1.Text, out hours))
{
    // Here TryParse() succeeded — it’s a number!
}
```

If the user types `999`, `TryParse()` says it is a valid number.
However, no one can work 999 hours in a week. The value is numeric, but
it is not reasonable for this example. This means the data's integrity
has not been verified.

---

## 4.9 Radio Buttons and Check Boxes

Radio buttons allow users to select one choice from several possible
choices. Clicking on a radio button automatically deselects any others
in the group. This is known as mutually exclusive selection.

Check boxes allow users to select multiple options.

### RadioButton Control

.NET provides the `RadioButton` control for creating a group of radio
buttons.

Common properties:

- `Text`: Holds the text displayed next to the radio button.
- `Checked`: A Boolean property that determines whether the control is
  selected or deselected.

Use a decision structure to determine whether a radio button is
selected:

```csharp
if (choiceRadioButton.Checked)
{
}
else
{
}
```

The following is equivalent:

```csharp
if (choiceRadioButton.Checked == true)
{
}
else
{
}
```

### CheckBox Control

The .NET Framework provides the `CheckBox` control to give the user an
option, such as true/false or yes/no.

Common properties:

- `Text`: Holds the text displayed next to the check box.
- `Checked`: A Boolean property that determines whether the control is
  selected or deselected.

```csharp
if (option1CheckBox.Checked)
{
}
else
{
}
```

### The `CheckedChanged` Event

Whenever a radio button or check box control's `Checked` property
changes, a `CheckedChanged` event is raised. You can create an event
handler and write code to respond to the event.

```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
}
```

---

## 4.10 The `switch` Statement

The `switch` statement lets the value of a variable or an expression
determine which path of execution the program will take. It is a
multiple-alternative decision structure.

It can be used as an alternative to an `if-else-if` statement that tests
the same variable or expression for several different values.

### General Format

```csharp
switch (testExpression)
{
    case value_1:
        statement;
        break;

    case value_2:
        statement;
        break;

    default:
        statement;
        break;
}
```

The `testExpression` is a variable or an expression that gives an `int`,
`string`, or `bool` value. Each `case` is an individual subsection
containing one or more statements, followed by a `break` statement.

The `default` section is optional and is designed for a situation when
the `testExpression` does not match any of the cases.

---

## 4.11 Introduction to List Boxes

A `ListBox` control displays a list of items and allows the user to
select an item from the list.

### Common Properties

- `Text`: Contains the text of the currently selected item in the
  `ListBox`.
- `Items`: Contains the items of the `ListBox`.
- `Items.Count`: Contains the number of items in the `ListBox`.
- `SelectedItem`: Gets or sets the currently selected item in the
  `ListBox`.
- `SelectedIndex`: Gets or sets the zero-based index of the currently
  selected item in a `ListBox`.

You can use the following to get the selected item from a list box:

```csharp
selectedFruit = fruitListBox.SelectedItem.ToString();
```

### Adding Items to a ListBox

The `Items.Add` method allows you to add an item to the `ListBox`.

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

### Checking Whether an Item Is Selected

An exception will occur if you try to get the value of a `ListBox`'s
`SelectedItem` property when no item is selected.

Items in a list box have an index starting with `0`. The first item has
index `0`, and the nth item has index `n - 1`.

The `SelectedIndex` property keeps the index. If no item is selected,
the value of `SelectedIndex` is `-1`.

```csharp
if (fruitListBox.SelectedIndex != -1)
{
    selectedFruit = fruitListBox.SelectedItem.ToString();
}
```

### Difference Between `Text` and `SelectedItem`

---

Feature Text SelectedItem

---

Type `string` `object`

Use case Quick access to Full access to the
selected text selected item

Flexibility Less flexible More flexible

Null-safe? Might return `""` if Might be `null` if
nothing is selected nothing is selected

Best for Simple text-only lists Complex or data-bound
lists

---

### Removing Items from a ListBox

The `Items.Remove` method removes a specific item from a `ListBox`.

```csharp
daysListBox.Items.Remove("Tuesday");
```

The `Items.RemoveAt` method removes an item at a specific index from a
`ListBox`.

```csharp
daysListBox.Items.RemoveAt(2);
```

The specified index must be valid. It cannot be less than `0`, or
greater than or equal to the number of items in the `ListBox`. If the
index is invalid, the `RemoveAt` method will throw an exception.

The `Items.Clear` method erases all the items in the `ListBox`.

```csharp
daysListBox.Items.Clear();
```

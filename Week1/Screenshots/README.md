# Introduction to C# - Code Examples

## Topics

- Message Boxes
- Label Controls
- Writing the Code to Close an Application's Form

---

## 1. Message Boxes

A message box (also called a dialog box) displays a message to the user.

.NET provides a method named `MessageBox.Show()`.

When this method is placed inside a Button Click event, the message box appears after the button is clicked.

![Message Box](Screenshots/MessageBox.png)

### Example

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
```

## 2. Label Controls

A Label control displays text on a form.

By adding a line to a Button's Click event handler, a Label control can display output.

The `.Text` property of the label is used to show the result.

![Label Control](Screenshots/LabelControl.png)

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    answerLabel.Text = "Welcome to C#";
}
```

### 3. Writing the Code to Close an Application's Form

To close an application's form in code, use the `this.Close();` statement.

A commonly used practice is to create an Exit button and add this code to its Click event handler.

![Close Form](Screenshots/CloseForm.png)

```csharp
private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}

```

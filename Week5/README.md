# Introduction to C# - Files, Dialogs, Random Numbers, and the Load Event

## Topics

- Using Files for Data Storage
- The OpenFileDialog and SaveFileDialog Controls
- Random Numbers
- The Load Event

## 1. Using Files for Data Storage

A program saves data for later use by writing it to a file. There are always three steps:

1. **Open** the file: connect the file to the program.
2. **Process** the file: write to it or read from it.
3. **Close** the file: disconnect it from the program.

There are two types of files: **text files** (data encoded as text, such as Unicode) and **binary files** (not viewable in a text editor). This chapter uses text files only.

.NET provides two classes: `StreamWriter` for writing and `StreamReader` for reading.

### Writing data

Use `File.CreateText` or `File.AppendText` to open the file, then `Write` or `WriteLine`, then `Close`.

- `WriteLine` writes the item and then a newline.
- `Write` writes the item without a newline.
- `File.CreateText` creates the file; if it already exists, **its contents are erased**.
- `File.AppendText` keeps the existing contents and adds to the end.

```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();

// Append without erasing

StreamWriter outputFile;
outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");
outputFile.Close();
```

### Specifying the file location

Give a path with the file name, and prefix the string with `@` so backslashes are not treated as escape characters.

```csharp
StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");

// Without @, each backslash must be doubled
outputFile = File.CreateText("D:\\C#\\CA232\\bin\\Debug\\listocurse1.doc");
```

### Reading data

Open the file with `File.OpenText`, then read with one of these:

- `StreamReader.ReadLine()`: reads one line and returns it as a string.
- `StreamReader.Read()`: reads the next character.
- `StreamReader.ReadToEnd()`: reads the whole file.
- `File.ReadAllText(path)`: reads the whole file in one call.

```csharp
// Read one line
StreamReader read;
read = File.OpenText("lstcourse.doc");
string content;
content = read.ReadLine();
read.Close();

// Read one character
StreamReader read;
read = File.OpenText("lstcourse.doc");
char content;
content = (char)read.Read();
listBox1.Items.Add(content);
read.Close();

// Read everything
StreamReader read;
read = File.OpenText("lstcourse.doc");
string content;
content = read.ReadToEnd();
listBox1.Items.Add(content);
read.Close();

// Shortcut
string text;
text = File.ReadAllText("lstcourse.doc");
listBox1.Items.Add(text);
```

### Reading a file with a loop

`StreamReader` has a Boolean property, `EndOfStream`, which tells you whether the end of the file has been reached.

```csharp
while (inputFile.EndOfStream == false)
{
}

// Same thing
while (!inputFile.EndOfStream)
{
}
```

### Example: read all lines with error handling

```csharp
StreamReader reader;
try
{
    reader = File.OpenText("D:\\C#\\CA232\\bin\\Debug\\listocurse1.doc");

    while (reader.EndOfStream == false)
    {
        string line;
        line = reader.ReadLine();
        listBox1.Items.Add(line);
    }
    reader.Close();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

## 2. The OpenFileDialog and SaveFileDialog Controls

These controls show the standard Windows **Open** and **Save As** dialog boxes. Unlike a Label, Button, or TextBox, they are **invisible controls**: when added to a form they appear in the **component tray** at the bottom of the Designer.

### Displaying an Open box

```csharp
private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}
```

### Detecting the user's choice

`ShowDialog` returns a `DialogResult`:

- `DialogResult.OK` if the user clicked **Open** (or **Save**).
- `DialogResult.Cancel` if the user clicked **Cancel**.

```csharp
DialogResult result = openFileDialog.ShowDialog();
if (result == DialogResult.OK)
{
    // user picked a file
}
else if (result == DialogResult.Cancel)
{
    // user cancelled
}
```

### FileName and InitialDirectory

The chosen path and file name are stored in the control's `FileName` property. `InitialDirectory` sets the folder the dialog opens in.

```csharp
openFileDialog.InitialDirectory = @"C:\Data";

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.FileName);
}
```

### Example: open and read

```csharp
StreamReader reader;

if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    reader = File.OpenText(openFileDialog1.FileName);
    while (reader.EndOfStream == false)
    {
        string lines;
        lines = reader.ReadLine();
        listBox1.Items.Add(lines);
    }
    reader.Close();
}
```

### Displaying a Save As box

```csharp
StreamWriter write;

DialogResult result = saveFileDialog1.ShowDialog();

if (result == DialogResult.OK)
{
    // create the file using the selected path
    write = File.CreateText(saveFileDialog1.FileName);
    write.WriteLine("Mohamed");
    write.Close();
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Cancelled");
}
```

> **Note:** The slide for the Save As box uses `openFile.Filename`. For a save dialog it should be `saveFileDialog.FileName`, as shown above.

## 3. Random Numbers

.NET provides the `Random` class. Create an object first, then call its methods.

- `Next()`: a random integer from `0` to `2,147,483,647`.
- `Next(max + 1)`: a random integer from `0` to `max`.
- `NextDouble()`: a random floating-point number from `0.0` up to (but not including) `1.0`.

```csharp
Random rand = new Random();

int number1 = rand.Next();
double number2 = rand.NextDouble();

// 0 to 99
int number = rand.Next(100);
```

## 4. The Load Event

When an application runs, its form is loaded into memory and the **Load** event occurs. Code inside the Load event handler runs when the form launches. To create the handler, double-click the form in the Designer.

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```

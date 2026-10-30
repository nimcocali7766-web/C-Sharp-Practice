# Explain the Function

## 1. Function Using Reading the File

In C#, the `System.IO` namespace provides different functions for reading data from files.

- **File.ReadAllText():** Reads all text from a file and returns it as a single string.
- **File.ReadAllLines():** Reads all lines from a file and returns them as a string array.
- **File.ReadLines():** Reads the lines of a file one at a time when needed.

**Examples:**

```csharp
File.ReadAllText("data.txt");
File.ReadAllLines("data.txt");
File.ReadLines("data.txt");
```

These functions are useful when a program needs to access and process information stored in a text file.

## 2. Function Used to Delete a File

In C#, the `File.Delete()` method is used to delete a specified file from the computer.

**Example:**

```csharp
File.Delete("data.txt");
```

The method takes the file path or file name as an argument and deletes the file if it exists. If the file does not exist, it does not throw an error simply because the file is missing.

**Conclusion**

File-reading functions help programmers access information stored in files, while `File.Delete()` helps remove files that are no longer needed. These functions are part of the `System.IO` namespace in C#.

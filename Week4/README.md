# Introduction to C# - Loops 


## Topics

- The while Loop
- The ++ and -- Operators
- The for Loop
- The do-while Loop

## 1. The while Loop

A `while` loop repeats a statement or a block of statements as long as a Boolean expression is `true`. It has two parts: the Boolean expression, and the body that is repeated.

Key terms:

- **Iteration**: one execution of the loop body.
- **Counter variable**: a variable that tracks how many times the loop has run.
- **Pretest loop**: the condition is tested *before* each iteration, so if it is `false` at the start, the body never runs.
- **Infinite loop**: a loop whose condition never becomes `false`, usually because the counter is never updated.

```csharp
// General format
while (BooleanExpression)
{
    statements
}

// Iterates 5 times
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}

// Never iterates: the condition is false from the start
int count = 5;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}

// Infinite loop: count is never increased
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
}
```

### Example: Ending Balance

Adds monthly interest to a starting balance and lists each month's result in a ListBox.

```csharp
// Constant for the monthly interest rate.
const decimal INTEREST_RATE = 0.005m;

// Add this month's interest to the balance.
balance = balance + (INTEREST_RATE * balance);

// Display this month's ending balance.
detailListBox.Items.Add("The ending balance for month " +
    count + " is " + balance.ToString("c"));
```

## 2. The ++ and -- Operators

To **increment** is to increase a variable's value; to **decrement** is to decrease it.

```csharp
// Add 1: all three are equivalent
count++;
count += 1;
count = count + 1;

// Subtract 1: all three are equivalent
count--;
count -= 1;
count = count - 1;
```

### Postfix vs Prefix

- **Postfix** (`count++`): use the old value, then change it.
- **Prefix** (`++count`): change the value first, then use it.

```csharp
// Postfix: x gets 5, count becomes 6
int count = 5;
int x = 0;
x = count++;

// Prefix: count becomes 6, x gets 6
int count = 5;
int x = 0;
x = ++count;
```

## 3. The for Loop

The `for` loop is designed for loops controlled by a counter. It needs three actions:

- **Initialization**: runs once and sets the counter's starting value.
- **Test**: a Boolean expression; if `true`, the loop iterates.
- **Update**: increases or decreases the counter.

The `for` loop is also a pretest loop.

```csharp
// General format
for (InitializationExpression; TestExpression; UpdateExpression)
{
    statements
}

// Counter declared outside the loop
int count;
for (count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

// Counter declared in the initialization expression
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

### Other forms of the update expression

The counter does not have to go up by 1.

```csharp
// Increment by 10
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

// Counting backward
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

## 4. The do-while Loop

The `do-while` loop is a **posttest loop**: it runs the body once *before* testing the condition, so it always iterates at least once.

```csharp
// General format
do
{
    statements
} while (BooleanExpression);

// Shows the message box once (body runs before the test)
int number = 1;
do
{
    MessageBox.Show(number.ToString());
} while (number < 0);

// Never shows the message box (test happens first)
int number = 1;
while (number < 0)
{
    MessageBox.Show(number.ToString());
}
```

| Loop       | Tests the condition | Minimum iterations |
|------------|---------------------|--------------------|
| `while`    | Before the body     | 0                  |
| `for`      | Before the body     | 0                  |
| `do-while` | After the body      | 1                  |

## Practice Questions and Answers

**Code that shows messages (number++ and number--):**

```csharp
int number = 5;
number++;
MessageBox.Show(number.ToString());  // 6
number--;
MessageBox.Show(number.ToString());  // 5
```

**How many times does this loop iterate?** 4 times (displays 0, 1, 2, 3).

```csharp
int count = 0;
while (count < 4)
{
    MessageBox.Show(count.ToString());
    count++;
}
```

**What is a posttest loop?** A loop that performs an iteration *before* testing its Boolean expression (`do-while`).

**Difference between `while` and `do-while`?** `while` tests first, so it may never run; `do-while` tests last, so it always runs at least once.

**How many times does this loop iterate?** 1 time (the body runs once, then `count < 0` is false).

```csharp
int count = 0;
do
{
    MessageBox.Show(count.ToString());
    count++;
} while (count < 0);
```

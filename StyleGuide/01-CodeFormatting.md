# 01. Code Formatting

Code formatting is how you use braces, line breaks, and blank lines to make code structure clear. Good formatting makes your code easier to follow at a glance. Here are some fundamental formatting rules:

* **Braces on New Lines (Allman Style):** Always put opening `{` and closing `}` braces on their own lines, aligned with the current indentation level. This style clearly separates blocks of code. For example, an `if` statement’s brace should be on a new line below the `if` condition.
* **Always Use Braces:** Even if an `if` or loop has a single statement, include the braces. This prevents errors if someone later adds another line inside the block.
* **One Statement Per Line:** Don’t pack multiple statements on one line. Each statement (like a declaration or an expression) goes on its own line. This improves readability and makes diffs cleaner.
* **One Declaration Per Line:** Similarly, declare only one variable per line (with a type). This way each declaration stands out.
* **Blank Lines Between Blocks:** Use blank lines to separate logical sections of your code. For example, add an empty line between methods, between property definitions, or before a new logical section in a method. Avoid excessive blank lines – usually one blank line is enough to separate sections.
* **Reasonable Line Length:** Avoid very long lines of code. A common guideline is to keep lines under ~120 characters for better readability. If a line is too long, break it into multiple lines.
* **Break Long Expressions Clearly:** If you break a long expression or statement into multiple lines, do so at natural breakpoints. It’s often recommended to break *before* an operator, so the operator sits at the start of the new line. This makes it clear the line is a continuation of the previous one. Also indent the continuation line (usually by one additional indent).
* **Use Parentheses for Clarity:** When an expression has multiple conditions or operations, use parentheses to group and clarify order of evaluation. This isn’t always required by the compiler, but it helps humans understand the logic.

**Good Example:** Formatting with clear braces and spacing

```csharp
if (x > 0)   // Good: 'if' followed by space and condition in parentheses
{
    Console.WriteLine("Positive");
}
else
{
    Console.WriteLine("Non-positive");
}

int count = 5;             // Good: one statement per line
string name = "Alice";     // Good: one declaration per line

// Good: Blank line above to separate this method from the previous code
void ProcessData()
{
    // ... method implementation ...
}
```

**Bad Example:** Poorly formatted code (difficult to read)

```csharp
if(x>0) { Console.WriteLine("Positive"); } else Console.WriteLine("Non-positive");  // Bad: braces on same line and multiple statements in one line

int a=1, b=2; Console.WriteLine(a+b);   // Bad: two statements on one line, and multiple declarations in one line

void DoWork()
{ Console.WriteLine("Doing work"); }    // Bad: Opening brace not on a new line (not Allman style)
```

In the bad example above, the formatting is hard to follow. The good example uses line breaks and braces to clearly show the structure.

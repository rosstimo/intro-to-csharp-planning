# 01. Code Formatting

Consistency and clarity in code make it easier to read and maintain. This section covers the basics of formatting in C#: braces, line breaks, blank lines, and line length. Good formatting makes your code easier to follow at a glance.

* **Braces on New Lines (Allman Style):** Always put opening `{` and closing `}` braces on their own lines, aligned with the current indentation level. This style clearly separates blocks of code. For example, an `if` statement’s brace should be on a new line below the `if` condition.
* **Always Use Braces:** Even if an `if` or loop has a single statement, include the braces. This prevents errors if someone later adds another line inside the block.
* **One Statement Per Line:** Don’t pack multiple statements on one line. Each statement (like a declaration or an expression) goes on its own line. This improves readability and makes diffs cleaner.
* **One Declaration Per Line:** Similarly, declare only one variable per line (with a type). This way each declaration stands out.
* **Blank Lines Between Blocks:** Use blank lines to separate logical sections of your code. For example, add an empty line between methods, between property definitions, or before a new logical section in a method. Avoid excessive blank lines – usually one blank line is enough to separate sections.
* **Reasonable Line Length:** Avoid very long lines of code. A common guideline is to keep lines under ~120 characters for better readability. If a line is too long, break it into multiple lines.
* **Break Long Expressions Clearly:** If you break a long expression or statement into multiple lines, do so at natural breakpoints. It’s often recommended to break *before* an operator, so the operator sits at the start of the new line. This makes it clear the line is a continuation of the previous one. Also indent the continuation line (usually by one additional indent).
* **Use Parentheses for Clarity:** When an expression has multiple conditions or operations, use parentheses to group and clarify order of evaluation. This isn’t always required by the compiler, but it helps humans understand the logic.

**Good Example:**

```csharp
if (x > 0)
{
    Console.WriteLine("Positive");
}
else
{
    Console.WriteLine("Non-positive");
}

int count = 5;
string name = "Alice";

void ProcessData()
{
    // ... method implementation ...
}
```

**Bad Example:**

```csharp
if(x>0) { Console.WriteLine("Positive"); } else Console.WriteLine("Non-positive");
int a=1, b=2; Console.WriteLine(a+b);
void DoWork() { Console.WriteLine("Doing work"); }
```

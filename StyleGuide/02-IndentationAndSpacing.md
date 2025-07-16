# 02. Indentation and Spacing

Indentation organizes code into a visual hierarchy, and spacing (spaces between characters) makes individual statements easier to read. Consistent indentation and spacing are crucial for readability:

* **Use 4 Spaces for Indents:** Indent your code blocks by **4 spaces** per level (this is the default in Visual Studio). Do **not** use tab characters for indentation – configure your editor to insert spaces if you press the Tab key. This ensures code looks the same in all environments.
* **Indent Blocks and Continuation Lines:** Whenever you open a block (after an `{`), increase the indent for the code inside. When the block ends (`}`), decrease the indent back. If a statement wraps to a new line (for example, a long LINQ query or function call), indent the continuation line an extra 4 spaces so it's clear it’s part of the previous line.
* **No Mixed Indentation:** Never mix tabs and spaces. Use spaces consistently to avoid misaligned code in different editors.
* **Space After Keywords:** Put a space between control flow keywords and the following parenthesis. For example, write `if (` not `if(`, and `while (` not `while(`. This tiny space improves readability.
* **No Space After Method Names:** Unlike keywords, do **not** put a space between a function name and its parentheses. For example, use `ComputeSum()` not `ComputeSum ()`.
* **Spaces Around Operators:** Surround binary operators with a single space on each side for readability. For instance, use `x + y` instead of `x+y`, and `i < 10` instead of `i<10`. Spaces make it clear what the operands are. An exception is unary operators (like the `!` in `!flag` or a type cast) – no space is needed there.
* **Space After Commas:** In argument lists, array initializers, or enums, put a space after each comma. Example: `Console.WriteLine(firstName, lastName)` should be written as `Console.WriteLine(firstName, lastName)`. This helps separate items in a list.
* **No Extra Spaces Inside Parentheses/Brackets:** Don’t pad inside parentheses or square brackets. For example, write `if (x == 10)` not `if ( x == 10 )`, and `int[] nums = new int[5]` not `int[ ] nums = new int [ 5 ]`. The only time you might see a space inside parentheses is for type casts, e.g. `(int)x`, which is fine (no space after the `(` or before the `)`).
* **No Trailing Whitespace:** Avoid leaving spaces at the end of a line. It’s invisible and can cause noise in diffs. Most editors can trim this automatically.
* **Align Multiline Parameters/Arguments (optional):** If you break a long parameter list or argument list onto multiple lines, indent the subsequent lines once. There are various acceptable styles, but the key is to make it clear those lines are a continuation of the previous line and not a new statement.

**Good Example:** Proper indentation and spacing

```csharp
public void CalculateSum(int a, int b, int c)
{
    // Indented 4 spaces inside the method
    if (a > 0 && b > 0)   // Good: space after 'if', and around operators
    {
        int sum = a + b + c;    // Good: spaces around '+' 
        Console.WriteLine(sum);
    }

    var numbers = new int[3] { 1, 2, 3 };  // Good: no extra space around brackets, space after commas
    DoSomething(numbers);                 // Good: no space between method name and ()

    // Long condition broken into multiple lines:
    if (a > 1000 && 
        b > 1000 &&                // indented +4, operator at line start for clarity
        (c % 2 == 0))
    {
        Console.WriteLine("Large even numbers");
    }
}
```

**Bad Example:** Inconsistent indentation and spacing

```csharp
public void CalculateSum ( int a,int b,int c )
{
 // Bad: Indent is 1 space, not 4
 if(a>0&&b>0){
     int sum=a+b+c; Console.WriteLine(sum);
     // Bad: no spaces around operators, multiple statements on one line
 }

 var numbers = new int [3] {1,2,3};   // Bad: space before [3], no space after commas
 DoSomething ( numbers );            // Bad: space before parentheses in function call

 if (a > 1000 
     && b > 1000 && (c%2==0)) {
     Console.WriteLine("Large even numbers"); }
 // Bad: unclear line break and spacing, braces not on new lines
}
```

In the bad example, inconsistent spacing makes the code hard to read: there are missing spaces around operators, misaligned indentations, and stray spaces inside brackets/parentheses. Always aim for the clean style shown in the good example – consistent 4-space indents and well-placed spaces for readability.

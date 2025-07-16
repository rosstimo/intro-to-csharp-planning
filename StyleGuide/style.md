# C# Coding Style Guide for Beginners

Consistency and clarity in code make it easier to read and maintain. This guide covers the basics of C# coding style – **formatting**, **indentation**, **naming**, **structure**, and **commenting** – based on Microsoft’s official conventions and best practices. Each section explains the guidelines in simple terms, with examples of **Good** and **Bad** code.

## Code Formatting

Code formatting is how you use braces, line breaks, and blank lines to make code structure clear. Good formatting makes your code easier to follow at a glance. Here are some fundamental formatting rules:

* **Braces on New Lines (Allman Style):** Always put opening `{` and closing `}` braces on their own lines, aligned with the current indentation level. This style clearly separates blocks of code. For example, an `if` statement’s brace should be on a new line below the `if` condition.
* **Always Use Braces:** Even if an `if` or loop has a single statement, include the braces. This prevents errors if someone later adds another line inside the block.
* **One Statement Per Line:** Don’t pack multiple statements on one line. Each statement (like a declaration or an expression) goes on its own line. This improves readability and makes diffs cleaner.
* **One Declaration Per Line:** Similarly, declare only one variable per line (with a type). This way each declaration stands out.
* **Blank Lines Between Blocks:** Use blank lines to separate logical sections of your code. For example, add an empty line between methods, between property definitions, or before a new logical section in a method. Avoid excessive blank lines – usually one blank line is enough to separate sections.
* **Reasonable Line Length:** Avoid very long lines of code. A common guideline is to keep lines under \~120 characters for better readability. If a line is too long, break it into multiple lines.
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

## Indentation and Spacing

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

## Naming Conventions

Using consistent naming conventions in your code makes it intuitive and self-documenting. C# and .NET have well-established naming guidelines (part of the Framework Design Guidelines). Here are the key rules:

* **PascalCase for Types and Public Members:** Use PascalCase (also known as **Pascal Casing**) for **classes**, **interfaces**, **structs**, **enums**, **delegates**, and **public members** (methods, properties, events). In PascalCase, each word is capitalized with no separators (e.g. `CustomerAccount`, `CalculateTotal`). For interfaces, always start the name with an **`I`** (e.g. `IStream`, `ILogger`) to indicate it’s an interface. For attribute classes, end the name with **`Attribute`** (e.g. `SerializableAttribute`) by convention. Enum type names are PascalCase; use a **singular** name for normal enums (e.g. `Color`), and a **plural** name for flags enums that allow combination of values (e.g. `FileAccessModes`).
* **camelCase for Locals and Parameters:** Use camelCase for **variables**, **fields**, and **parameters** that are not public. In camelCase, the first letter is lowercase and following words are capitalized (e.g. `firstName`, `totalAmount`). Method parameters and local variables are typically camelCase. This rule helps distinguish local variables from Types, which start with capital letters.
* **Private Fields:** For private member fields inside classes, use camelCase **with a leading underscore** `_` by convention. Example: `_currentIndex` or `_logger`. This clearly differentiates fields from local variables in code. (Some teams omit the underscore, but the .NET Runtime style uses it, so we’ll use it here.)
* **Static Fields:** A common convention (used in the .NET runtime) is to prefix private **static** fields with `s_` and thread-static fields with `t_`. For example: `private static int s_cacheSize;`. This prefix is not required by the language, but it follows the pattern that static members are prefixed differently. If you find it confusing, you can omit the `s_` prefix, but be consistent.
* **Constants:** For `const` values or `readonly` static fields, use PascalCase as well (they are essentially static variables). Do **not** use ALL\_CAPS with underscores for constants (e.g. use `MaxRetries` not `MAX_RETRIES`); all-caps is not the C# convention for constants. PascalCase makes constants look like regular variables, which in C# is acceptable.
* **Meaningful Names:** Choose clear, descriptive names that indicate the purpose of the variable or method. For example, `GetCustomerOrders` is more informative than `GetData`. Avoid vague names like `Tmp`, `Data`, or `Value` that don’t convey intent. A good name reduces the need for comments.
* **Avoid Abbreviations:** Don’t abbreviate words arbitrarily. For instance, use `ComputeAverage`, not `CompAvg`. Only use acronyms or abbreviations that are widely known and accepted (e.g. `HTML`, `Id` for identifier, `Http`). When using acronyms in PascalCase, capitalize them normally (e.g. `XmlParser`, not `XMLParser`, except two-letter acronyms can be all caps like `IOStream` – but this is an advanced nuance). When in doubt, just treat the acronym as a word (e.g. `JsonWriter`).
* **Booleans as Questions:** Name boolean variables and properties like a question or affirmative statement. Common prefixes are `is`, `has`, `can`, `should` (e.g. `isFinished`, `hasItems`, `canExecute`). This makes it clear that the value represents a true/false condition.
* **No Hungarians or Prefixes for Scope:** Do not add prefixes like `tbl_` or `m_` or Hungarian notation (encoding type in the name, e.g. `strName` for string). C# code should be clean of type or scope prefixes – the type system and good naming make that information clear. The only prefix in common use is `I` for interfaces as mentioned, and `_` for private fields.
* **Avoid Single Letter Names:** Single-letter variables (like `x` or `i`) should generally only be used for *very short-lived loop indices* or similar tiny scopes. Even then, prefer `i`, `j` for loop counters rather than something like `a` or `b` which may be less clear. For anything that carries meaning or is used outside a few lines, use a descriptive name. (One exception: in LINQ expressions or lambda expressions, single-letter like `x` is sometimes used for a generic object, but you can still choose a meaningful name in those contexts for clarity.)
* **Consistent Naming:** Don’t use names that differ only in capitalization in the same context. C# is case-sensitive, but having `product` and `Product` as separate variables is confusing. Also avoid names that sound too similar.
* **Namespaces and Assemblies:** This is more advanced, but if you create namespaces, use PascalCase and typically a dot-separated hierarchy (often starting with your company or project name). Example: `MyProject.Services.Logging`. Assembly names (project names) should also be PascalCase and reflect the content (e.g. `MyProject.Utilities`).

Here are some examples of good and bad naming:

**Good Example:** Descriptive, conventional names

```csharp
public class OrderProcessor    // Class in PascalCase
{
    private readonly int _maxOrderSize = 100;   // Private constant field in PascalCase with underscore

    private int _currentCount;   // Private field with underscore in camelCase

    public int CurrentCount     // Public property in PascalCase
    {
        get { return _currentCount; }
    }

    public void ProcessOrder(string customerName, int itemCount)   // Method in PascalCase, parameters in camelCase
    {
        bool isValid = itemCount <= _maxOrderSize;   // Boolean variable as question (isValid)
        if (!isValid)
        {
            Console.WriteLine($"Order too large for {customerName}");
        }
        // ...
    }
}

interface IShape    // Interface with 'I' prefix
{
    void Draw();
}
```

**Bad Example:** Unclear or unconventional names

```csharp
public class order_processor   // Bad: uses snake_case or lower-case, not PascalCase
{
    private int currentCount;   // Bad: private field not prefixed with _ (in this convention guide)
    private static int cacheSize;   // Bad: static field without s_ prefix (if following that convention)

    public int curCnt   // Bad: unclear abbreviation, not PascalCase
    {
        get { return currentCount; }
    }

    public void Process_Order(string CustomerName, int ItemCount)   // Bad: underscores in name, parameters should be camelCase
    {
        bool valid = ItemCount <= 100;   // Bad: boolean not clearly named (could be isValid), parameter name capitalized wrongly
        if (!valid)
        {
            Console.WriteLine($"Order too large for {CustomerName}");
        }
    }
}

class shapeInterface { }   // Bad: interface without 'I' prefix and not PascalCase
```

In the bad example, the naming is inconsistent and non-standard: class name is not in PascalCase, `_` is missing on the private field, abbreviations like `curCnt` are used, and parameter naming is wrong. Following the **Good** naming conventions makes the code far more understandable at a glance.

## Code Layout and Structure

Code layout refers to how you organize your code within files and projects. A consistent structure helps others (and your future self) navigate the code. Here are guidelines for organizing C# code:

* **One Type per File:** Define only one top-level **public class** (or struct, interface, enum) per file, and name the file after the class. For example, `Customer.cs` contains the `Customer` class. This is the standard in .NET and makes things easy to find. You can have inner classes or private supporting types in the same file if needed, but if a class is public (or would make sense on its own) give it its own file.
* **Order of Members:** Inside a class, order members in a logical way. A common order is: **fields** (and constants) first, then **properties**, then **constructors**, then **methods**. Another approach is to group by functionality. The key is to be consistent. Also, group related things together (for example, put private helper methods together at the bottom, or all event-handling methods in one region). Consistent ordering helps readers know where to look for something.
* **Consistent Access Modifiers:** Consider ordering by accessibility – for example, all public members before private ones – or the reverse. There’s no one correct order, but don’t scatter public and private members randomly. One common convention is: public methods at top, then internal, then protected, then private. Within each group, you might order by their purpose. Find an approach that makes sense and stick to it.
* **Always Specify Access Level:** Explicitly mark members with `public`, `private`, etc., rather than relying on defaults. For instance, top-level classes without a modifier default to internal, but you should still write `internal class MyClass` or `public class MyClass` for clarity. Likewise, explicitly mark class members `private` if they are private. This makes the code’s intent clear.
* **Keep Methods Focused:** Each method should generally do one logical task. If a method is very long or does too many things, consider splitting it into smaller methods. Not only is this good design, it also means each method can have a clear name and purpose, which is part of style. A rule of thumb: if you feel you need extensive comments to explain a method, it might be too complex. Break it down if possible.
* **Use Regions Sparingly:** C# allows `#region` to collapse code blocks. Beginners often overuse them. You usually don’t need regions in simple classes – the structure should be evident by good ordering and small size. Regions can be handy to hide boilerplate or for very large classes, but in well-factored code they are rarely needed. Use them only when they truly help.
* **Spacing in Code Structure:** We touched on blank lines between methods – definitely do that. Also consider adding a blank line between logical sections inside a method if it helps readability (for example, a block of code preparing data, then a block processing it). But don’t overdo blank lines – use them to create paragraphs of code logically.
* **Project Structure:** At a higher level, place classes in appropriate namespaces that reflect their functionality. For example, `Models`, `Services`, etc. This might be beyond a beginner’s immediate concern, but understand that as projects grow, organizing files into folders/namespaces is also a part of style (though more about architecture).
* **File-Scoped Namespace:** If using C# 10 or later, you can use file-scoped namespaces (`namespace MyApp.Models;` at the top) to avoid an extra brace level and keep code less indented. This is recommended for a cleaner file structure, with everything in that file under the declared namespace.
* **Example Layout:** Below is an example showing good file structure and a bad one:

**Good Example:** Each public type in its own file, clear member ordering
*File: `Product.cs`*

```csharp
namespace MyStore.Models;

public class Product
{
    // Fields (private) at top
    private static int s_totalProducts = 0;   // static field
    private readonly int _id;                // instance field

    // Properties
    public int Id => _id;
    public string Name { get; set; }

    // Constructor
    public Product(string name)
    {
        _id = ++s_totalProducts;
        Name = name;
    }

    // Public method
    public void PrintDetails()
    {
        Console.WriteLine($"Product {_id}: {Name}");
    }

    // Private helper method (grouped at bottom)
    private string GetLabel() 
    {
        return $"ID={_id}, Name={Name}";
    }
}
```

*File: `Order.cs`*

```csharp
namespace MyStore.Models;

public class Order
{
    // ... definition of Order class ...
}
```

In the good example, `Product` and `Order` are in separate files, making each file focused. Inside `Product`, members are organized clearly: fields, then properties, then constructor, then methods. This structure is easy to navigate and maintain.

**Bad Example:** Multiple classes in one file, disorganized members
*File: `Stuff.cs`*

```csharp
namespace MyStore.Models;

public class Product 
{
    public string Name;
    private int _id;
    public Product(string name) { Name = name; }
    public void PrintDetails() { Console.WriteLine($"Product {_id}: {Name}"); }
    // Bad: Fields, constructor, and methods are mixed without clear order
}

public class Order 
{
    public Product[] items;
    public int total;
    // ... (class continues) ...
}
public class OrderManager 
{
    // Three public classes in one file – bad practice, each should be separate.
}
```

*File: `Mixed.cs`*

```csharp
public class Mixed
{
    public int Data;
    private string GetData() { return Data.ToString(); }
    public string Info;
    // Bad: Member order is nonsensical; fields and methods interleaved,
    // and the class is doing too many things perhaps.
    // Also no access modifier on class (defaults to internal, but should be stated).
}
```

In the bad examples, multiple classes share one file (making it hard to locate `Order` or `OrderManager` quickly), and the members inside classes are not in a logical order. Following the good practices helps ensure each file and class has a clear purpose and structure.

## Commenting

Comments are an important part of code, but they should be used wisely. The goal is to write code that is mostly self-explanatory, using comments to clarify intent or important details. Here are best practices for commenting in C#:

* **Use `//` for Brief Comments:** For short explanations or notes, use single-line comments that start with `//`. Place the comment on its own line above the code it describes (or at least on a separate line). This makes it stand out.
* **Avoid Block Comments (`/* ... */`):** The C-style `/* multi-line */` comments can technically span multiple lines, but they are less common in C# coding. It’s usually clearer to use multiple `//` lines for long comments. Block comments can also accidentally comment out code if not used carefully. Reserve them for temporarily disabling code (debugging) or for specifically formatting a comment, but generally prefer `//`.
* **Comment the Why, Not the What:** This is crucial. Don’t write comments that simply restate what the code does – the code itself shows that. Instead, comment **why** something is done, or any context that’s not obvious from the code. For example, instead of `// increment i by 1` for `i++` (which is obvious), you might write `// move to the next index` if it adds a bit of intent, or even better, use a well-named variable so that might not need a comment at all.
* **Keep Comments Relevant and Updated:** A bad (and common) practice is leaving outdated comments that no longer match the code. Always update or remove comments if the code changes. Stale comments can mislead readers more than no comment.
* **XML Documentation Comments for Public APIs:** When you have public classes or public methods in libraries or larger projects, use XML comments (`/// <summary> ... </summary>`) to document their purpose. These comments appear in IntelliSense and official docs. For a beginner learning in small projects, you might not use these heavily, but it’s good to know the convention. **Example:**

  ```csharp
  /// <summary>
  /// Calculates the average of an array of numbers.
  /// </summary>
  public double CalculateAverage(int[] numbers) { ... }
  ```

  This provides a description of the method’s behavior. XML comments can also include `<param>` and `<returns>` tags to describe parameters and return values. Use these for any code that others will consume as a library or any non-trivial public method.
* **Style of Comments:** When writing sentence-style comments, start with a capital letter and end with a period. Example: `// Validate input parameters.`. This gives comments a consistent, professional style. Also, put a single space after the `//` before the text starts (the IDE usually does this by default when you start a `//` comment).
* **Don’t Postpone with Comments:** Avoid leaving “to-do” or “fix me” notes in comments for long periods. It’s okay to jot a short-term `// TODO: handle error cases` as a reminder, but don’t let these accumulate and become permanent. They’re not actually informing the reader about the current code’s function; they’re just notes. If something needs fixing, create a work item or fix it soon.
* **No Commented-Out Code in Releases:** If you need to remove code, remove it rather than commenting it out, especially in committed code. Source control history is a better way to retrieve old code when needed. Large blocks of commented-out code in a file can be confusing and cluttering.
* **Frequency of Comments:** You do **not** need a comment on every line. Well-named variables and methods reduce the need for many comments. A common beginner mistake is over-commenting trivial code. Aim for self-documenting code and use comments to clarify **why** something is done or to highlight important details or tricky parts of the code.

Let’s look at examples of bad and good commenting practices:

**Bad Example:** Misusing comments

```csharp
int x = 10; // set x to 10 (Bad: this comment is redundant)
int y = 20; // set y to 20 (Bad: the code is obvious without these)

// calculate sum of x and y (Bad: this comment is unnecessary)
int sum = x + y; 

/* Check if sum is greater than 20 */ if (sum > 20) {
    Console.WriteLine("Large sum");
} /* end if */  // Bad: block comment and end-of-line comment clutter

// TODO: fix this later (Bad: left a to-do without context or plan)
```

In the bad example, comments either state the obvious or clutter the code. The inline comments “set x to 10” are not adding any new information. The block comment style and commenting `end if` is not idiomatic in C#. These comments don’t help a future reader.

**Good Example:** Useful, clear comments

```csharp
// If the sum is over 20, we consider it a "large sum" for reporting.
if (sum > 20)
{
    Console.WriteLine("Large sum");
}

// Initialize the cache with default values (necessary to avoid null later).
Cache.InitializeDefaults();

/// <summary>
/// Retrieves a customer by ID from the database.
/// Returns null if the customer is not found.
/// </summary>
public Customer GetCustomerById(int id)
{
    // Using a dictionary lookup for O(1) retrieval.
    return _customerById.TryGetValue(id, out Customer result) ? result : null;
}
```

In the good example, the first comment explains *why* we check `sum > 20` – providing context that this triggers special reporting. The second comment notes why we call `InitializeDefaults()`. These add information not obvious from the code itself. The XML comment on `GetCustomerById` gives a clear description of what the method does and its behavior (returning null if not found). Inside that method, there’s also an inline comment explaining the choice of data structure (dictionary for O(1) lookup), which is a helpful insight for maintainers. None of these comments repeat the code; they add context.

---

Following these conventions will make your C# code clean, professional, and easy for others (and you!) to understand. At first it’s a lot to remember, but over time it becomes second nature. Consistent style is about communication – your code should clearly convey its purpose without requiring guesswork. Stick to these guidelines, and you'll be writing C# code that looks like the work of an experienced developer, even if you’re just starting out. Happy coding!&#x20;

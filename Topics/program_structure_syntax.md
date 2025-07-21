## 2. Program Structure & Syntax

- **Anatomy of a C# Program:**

  - **Namespace:**
    - The “folder” for your code. Prevents name collisions, organizes big projects.
    - You’ll see `namespace ProjectName { ... }` at the top of nearly every file.
  - **Class:**
    - Every C# program is built out of classes. Your code lives in classes, even if you’re just writing `Main`.
    - Example:
      ```csharp
      namespace HelloWorld {
          class Program {
              static void Main(string[] args) {
                  // code here
              }
          }
      }
      ```
  - **Main Method:**
    - The entry point—where your program starts.
    - Signature: `static void Main(string[] args)` (or just `static void Main()`)
    - For GUIs, entry is handled for you, but still lives inside a class.

- **Comments:**

  - `//` for single-line.
    - Good:
      ```csharp
      // Print a welcome message to the user.
      Console.WriteLine("Welcome!");
      ```
    - Bad:
      ```csharp
      Console.WriteLine("Welcome!"); // Print welcome (obvious, not needed)
      ```
  - `/* ... */` for multi-line.
    - Good:
      ```csharp
      /*
       * Loop through all students and print their names.
       * This is a multi-line comment explaining a block of code.
       */
      for (int i = 0; i < students.Length; i++)
      {
          Console.WriteLine(students[i]);
      }
      ```
    - Bad:
      ```csharp
      /* increment i by 1 */ for (int i = 0; i < 10; i++)
      {
          // ...
      }
      // (Don't use block comments for single lines or obvious code)
      ```
  - Why? To explain the “why” and “what,” not just the “how.”
    - Good:
      ```csharp
      // Use a dictionary for fast lookups (O(1) access).
      var lookup = new Dictionary<string, int>();
      ```
    - Bad:
      ```csharp
      // Add x and y
      int sum = x + y;
      ```
  - Doc comments for methods: `/// <summary>Does something</summary>`
    - Good:
      ```csharp
      /// <summary>
      /// Calculates the area of a rectangle.
      /// </summary>
      public int Area(int width, int height)
      {
          return width * height;
      }
      ```
    - Bad:
      ```csharp
      /// <summary>
      /// Area
      /// </summary>
      public int Area(int width, int height)
      {
          return width * height;
      }
      ```

- **Code Style & Organization:**

  - Indentation: four spaces per level. Never mix tabs and spaces. Make code readable for anyone.
    - Good:
      ```csharp
      if (score > 90)
      {
          Console.WriteLine("Excellent!");
      }
      ```
    - Bad:
      ```csharp
      if (score > 90){Console.WriteLine("Excellent!");}
      ```
  - Naming conventions:
    - Classes: `PascalCase` (`MyClass`)
      - Good:
        ```csharp
        class StudentRecord
        {
        }
        ```
      - Bad:
        ```csharp
        class studentrecord
        {
        }
        ```
    - Methods: `PascalCase` (`DoSomething`)
      - Good:
        ```csharp
        void CalculateGrade()
        {
        }
        ```
      - Bad:
        ```csharp
        void calculategrade()
        {
        }
        ```
    - Variables: `camelCase` (`totalScore`)
      - Good:
        ```csharp
        int totalScore = 0;
        ```
      - Bad:
        ```csharp
        int TotalScore = 0;
        ```
    - Constants: `ALL_CAPS` (always use ALL_CAPS for constants)
      - Good:
        ```csharp
        const int MAX_STUDENTS = 30;
        const double PI = 3.14159;
        ```
      - Bad:
        ```csharp
        const int maxstudents = 30;
        const double pi = 3.14159;
        const int MaxStudents = 30;
        ```
  - Information headers: At the top of every file: your name, course, date, assignment, etc.
    - Good:
      ```csharp
      // -----------------------------------------------------------------------------
      // Name:        Your Name
      // Class:       RCET 2265
      // Assignment:  01-HelloWorld
      // Date:        2025-07-16
      // Description: Prints Hello, World! to the console.
      // -----------------------------------------------------------------------------
      ```
    - Bad:
      ```csharp
      // Hello World program
      ```

- **RCET C# Style Guide:**

  - Every student follows it. No exceptions. Points off for style violations.
  - See the [StyleGuide/README.md](../StyleGuide/README.md) for the full style guide and table of contents.

- ** Statements:**

  - Ignore at first.
  - When you start importing libraries (File I/O, GUI, etc.), explain:
    - `using System;` gives access to Console, Math, etc.
    - Not critical until you add extra libraries.

- **Braces, Brackets, Parentheses, and Semicolons:**

  - **Braces `{ }`:**
    - Used to define the start and end of code blocks (classes, methods, loops, conditionals, etc.).
    - Example:
      ```csharp
      if (x > 0) {
          Console.WriteLine("Positive");
      }
      ```
    - Every opening `{` must have a matching closing `}`.
  - **Parentheses `( )`:**
    - Used for method calls, method definitions, and controlling order of operations in expressions.
    - Example: `Main(string[] args)`, `Console.WriteLine("Hello")`, `if (a + b > 10)`
  - **Brackets `[ ]`:**
    - Used for arrays and attributes.
    - Example: `int[] numbers = new int[5];`, `[Obsolete]`
  - **Semicolons `;`:**
    - End every statement with a semicolon. This tells C# where one command stops and the next begins.
    - Example: `int x = 5;`

- **C# vs. Python (or other whitespace-based languages):**

  - In C#, code blocks are defined by braces `{ }`, not by indentation. Indentation is for readability, but the braces are what the compiler cares about.
  - In Python, indentation (tabs/spaces) is required to define code blocks. There are no braces or semicolons.
  - Example comparison:
    - **C#:**
      ```csharp
      if (x > 0) {
          Console.WriteLine("Positive");
      }
      ```
    - **Python:**
      ```python
      if x > 0:
          print("Positive")
      ```
  - In C#, forgetting a brace or semicolon will cause a compiler error. In Python, inconsistent indentation will cause an error.


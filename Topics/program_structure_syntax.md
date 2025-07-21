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
  - `/* ... */` for multi-line.
  - Why? To explain the “why” and “what,” not just the “how.”
  - Doc comments for methods: `/// <summary>Does something</summary>`

- **Code Style & Organization:**

  - Indentation: four spaces per level. Never mix tabs and spaces. Make code readable for anyone.
  - Naming conventions:
    - Classes: `PascalCase` (`MyClass`)
    - Methods: `PascalCase` (`DoSomething`)
    - Variables: `camelCase` (`totalScore`)
    - Constants: `ALL_CAPS` or `PascalCase` (your pick, just be consistent)
  - Information headers: At the top of every file: your name, course, date, assignment, etc.

- **RCET C# Style Guide:**

  - Every student follows it. No exceptions. Points off for style violations.

- ``** Statements:**

  - Ignore at first.
  - When you start importing libraries (File I/O, GUI, etc.), explain:
    - `using System;` gives access to Console, Math, etc.
    - Not critical until you add extra libraries.


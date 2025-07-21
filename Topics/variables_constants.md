## 5. Variables & Constants

- **Declaring Variables:**
  - Syntax: `type variableName = value;`
    - Examples: `int count = 0;`, `string name = "Sheila";`
  - Always use a clear, descriptive name. Avoid: `x`, `tmp`, `a1` (unless it’s a loop index).

- **Variable Initialization:**
  - Always initialize if possible. Uninitialized = unpredictable bugs.

- **Scope:**
  - Local: Only lives inside `{}` where declared.
  - Class-level (fields): Declared in a class, used by any method in that class.
  - Shadowing: Never reuse a variable name in nested scopes.

- **Explicit Typing:**
  - For beginners, always use the actual type (`int`, `string`, etc.), not `var`.
  - `var` is for advanced/when the type is obvious.

- **Constants:**
  - `const type NAME = value;` Example: `const int MaxScore = 100;`
  - All caps or PascalCase for names (pick a convention, stick with it).
  - Use for values that never change—“magic numbers” are forbidden.

- **Good Habits:**
  - Use variables for meaning, not just to store a number.
  - Delete dead code and unused variables.
  - If you’re not sure what a variable is for, fix your code until it’s obvious.

- **Why it Matters:**
  - Good variables = easy to read, easy to debug, easy to upgrade later.
  - Constants = less pain when requirements change.


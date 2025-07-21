## 13. Methods & Functions

- **Subroutines (`void`):**
  - Methods that do something but return nothing
  - Syntax: `void SayHello() { ... }`

- **Functions (Return):**
  - Methods that return values
  - Syntax: `int Add(int x, int y) { return x + y; }`
  - Used for calculations, logic, transformations

- **Scope & Lifetime:**
  - Local variables: Exist only inside method/block
  - Class variables (fields): Exist as long as object exists
  - Static variables: Belong to the class, not instances

- **Argument Passing:**
  - By value: default (makes a copy)
  - By reference: use `ref`/`out` (changes original); demo, but don’t overuse

- **Overloading:**
  - Same method name, different parameter list (C# picks the right one)
  - Makes APIs more flexible and code more readable

- **Recursion:**
  - Method calls itself (with a base case, or you’ll crash)
  - Classic example: factorial, Fibonacci, sum array

- **Why it Matters:**
  - Methods keep code organized, reusable, and readable
  - Understanding arguments, scope, and return values is core to all coding


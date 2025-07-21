## 10. Try/Catch & Debugging

- **Exception Handling (try/catch):**

  - Catch errors so your program doesn’t crash—especially for user input and file I/O
  - Syntax:
    ```csharp
    try {
        // risky code
    } catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
    ```
  - Always explain: Don’t catch exceptions just to hide them—tell the user or fix it!

- **Reading Error Messages:**

  - Read the whole message and stack trace (the breadcrumbs to your bug)
  - Copy error, paste in Google/MSDN, *then* ask for help

- **Debugging Tools:**

  - Breakpoints: Pause execution, inspect state
  - Step Over (F10), Step Into (F11): Watch code in action
  - Use “Watches,” “Locals,” and “Autos” windows in VS
  - Use debugging from Day 1—don’t just run and pray

- **Why it Matters:**

  - Fixing bugs is programming. Debugging is not a crime, it’s a superpower
  - Professional devs debug constantly, not just when they’re desperate


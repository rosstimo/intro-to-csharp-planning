# RCET C# Style Guide (Beginner-Focused)

Welcome, human. This guide is for complete beginners. No prior programming experience needed. Everything in here is about making code **clear, readable, and dead simple**. Performance? We'll care later. Right now, it's all about understanding WTF is going on.

---

## 1. Formatting & Layout

- **Indent with 4 spaces.** No tabs. Every code block should look clean and lined up.
- **One statement per line.**
- **Braces on their own lines** (Allman style):
  ```csharp
  if (condition)
  {
      DoSomething();
  }
  ```
- **Keep lines short.** Aim for 80 characters or less so you don't have to scroll sideways.

---

## 2. Naming Conventions

- **PascalCase** for class names, method names, properties, constants.
  - Example: `StudentName`, `CalculateSum()`
- **camelCase** for variables and method parameters.
  - Example: `userInput`, `totalScore`
- **Interface names** start with I (like `IShape`)
- **Use real words.** No dumb abbreviations. `firstName`, not `fn`.

---

## 3. Comments

- Write comments for **why**, not what. (We can read code. Tell us what's not obvious.)
- Comments go above the code they describe.
- Make it short, clear, and don't overdo it.
  ```csharp
  // Ask the user for their name and greet them.
  Console.WriteLine("What is your name?");
  ```

---

## 4. Code Structure & Organization

- **One job per function.** If a method does more than one thing, split it up.
- **Short methods** are better. If it's getting long (\~20-30 lines), break it down.
- Avoid "magic numbers". Use constants with real names:
  ```csharp
  const int MaxAttempts = 3;
  ```

---

## 5. Readability > Cleverness

- If a clever trick makes the code harder to read, **don't use it**.
- Prefer simple, straightforward code. Break up long/complicated logic into smaller pieces.
- If you have to stop and think, it's too complicated for a beginner. Fix it.

---

## 6. Error Handling

- Use basic error handling. Show clear messages.
- Never crash on user input. If input is wrong, prompt again.
- Keep error messages polite and helpful.

---

## 7. Automation & Tools

- Use Visual Studio or VSCode's built-in formatters.
- Stick to the rules in this guide even if the tool "suggests" something fancier.

---

## 8. Example Code (Beginner Level)

```csharp
using System;

namespace HelloWorldExample
{
    // Program to say hello and greet the user
    class Program
    {
        static void Main()
        {
            // Ask the user for their name
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            // Greet the user
            Console.WriteLine($"Hello, {userName}!");

            // Wait for Enter before closing
            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();
        }
    }
}
```

**Notice:**

- 4 spaces everywhere, braces on their own lines
- Variable names make sense
- Comments explain *why*, not *what*
- Nothing tricky or fancy

---

## 9. Things to Avoid

- No abbreviations, no single-letter variables (except `i` in loops)
- No nesting code too deep (keep it flat when possible)
- No unnecessary performance tricks
- No copy-paste code (reuse with functions)

---

## 10. Ask for Help!

- If you don't know what a line of code means, **ask**. No shame in that.
- Google is your friend. So is your instructor. So is the doc string above every function.

---

## TL;DR

- 4 spaces
- PascalCase for types and methods, camelCase for variables
- Braces on their own lines
- Short, clear comments (why, not what)
- Keep code readable and simple
- Don't be a smartass. Clarity wins every time.

---

That's it. Follow this and your code will look clean, be easy to read, and not melt your brain. Rock on, rookie coder.


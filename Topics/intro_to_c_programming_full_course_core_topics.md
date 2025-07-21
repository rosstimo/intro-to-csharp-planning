# **Intro to C# Programming – Full Course Core Topics**

---

## **1. Tools, Setup & Workflow**

- Visual Studio: installation, setup, using the IDE
- Creating Console and WinForms projects
- Git/GitHub: local repo, remote, commits, pushes, pulls (habits start now)
- Running/debugging basics, breakpoints, step in/out, watches
- Navigating the IDE, using F1 and documentation

---

## **2. Program Structure & Syntax**

- Anatomy of a C# program: `namespace`, `class`, `Main` method
- Comments: single-line, multi-line, why you use them
- Code style: indentation, naming, info headers, RCET C# Style Guide
- `using` statements: **skip until File I/O/WinForms**

---

## **3. Primitive Data Types**

- `int`, `double`, `float`, `char`, `string`, `bool`
- Literals, real-world usage
- Type conversion, parsing, validation

---

## **4. Basic Operators**

- Arithmetic: `+`, `-`, `*`, `/`, `%`
- Assignment: `=`, `+=`, etc.
- Comparison: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Logical: `&&`, `||`, `!`
- String concatenation, interpolation
- Operator precedence

---

## **5. Variables & Constants**

- Declaring/initializing variables
- Explicit typing (`int score = 0;`)
- Naming conventions (no “x1” or “a”)
- Variable shadowing warning
- **Scope:** local, class-level (basics)
- `const` keyword, constant naming, why not use “magic numbers”

---

## **6. Getting Started & Console Fundamentals**

- Console methods: `WriteLine`, `Write`, `ReadLine`, `Beep`, `Clear`
- Fun with the console (make it sing, “Close Encounters” demo)
- Using documentation and searching MSDN
- Don’t panic at auto-generated code

---

## **7. String Manipulation & Formatting**

- Creating and combining strings
- String interpolation: `$"Hello, {name}!"`
- Common methods: `ToUpper`, `ToLower`, `Substring`, `IndexOf`, `Contains`, `Split`, `Join`
- Formatting/alignment, padding
- Parsing input (with `int.Parse`, `int.TryParse`)
- String validation

---

## **8. Math & The Math Class**

- Math operations, order of operations, PEMDAS for code
- `Math` class: `Abs`, `Sqrt`, `Pow`, `Round`, etc.
- Random numbers: `Random` class
- Practical applications: tables, dice rolls, etc.

---

## **9. Control Flow & Error Types**

- Conditionals: `if`, `else if`, `else` (keep flat, avoid crazy nesting)
- `switch` (simple, optional)
- Boolean logic: `&&`, `||`, `!`
- Ternary operator (optional/advanced)
- **Error Types:**
  - Compiler errors (won’t build)
  - Exceptions (runtime crash)
  - Logic errors (wrong output, sneaky bugs)
  - Style/convention violations (works, but ugly as hell)

---

## **10. Try/Catch & Debugging**

- Why programs crash (exceptions)
- How to read exception messages/stack trace
- Using `try/catch` to keep programs from dying (input validation, file I/O)
- Reading docs/error messages (Google is your friend)
- Debugging: breakpoints, step through, watches (taught everywhere, not a one-off lesson)

---

## **11. Loops**

- `for`, `while`, `do-while`
- Loop control: `break`, `continue`
- Nested loops (warn, don’t require)
- Classic errors: off-by-one, infinite loop
- Real tasks: tables, searching, simple games

---

## **12. Collections & Data Structures**

- **Arrays:**
  - Declare, initialize, iterate, access, common bugs (zero-based)
- **Lists (********`List<T>`********):**
  - Add, remove, access, loop, `.Count`, converting arrays/lists
- **Dictionaries:**
  - Key/value, `.ContainsKey`, `.TryGetValue`, lookup basics
- **Stack & Queue:**
  - LIFO/FIFO, `Push`, `Pop`, `Enqueue`, `Dequeue` (simple demos)
- Mention other collections for curiosity, not for main assignments

---

## **13. Methods & Functions**

- **Subroutines (********`void`********):**
  - Methods that just “do stuff”
- **Scope & Lifetime:**
  - Local, class-level, static fields
- **Functions (return):**
  - Methods that give back values, “black box” logic
- **Argument passing:**
  - By value (default, like VB ByVal)
  - By reference (`ref`, `out`, like VB ByRef)—demo, not focus
- **Overloading:**
  - Same method name, different parameters
- **Recursion:**
  - Self-calling methods, base case, classic examples (factorial, sum)

---

## **14. Object-Oriented Programming (OOP)**

- **Classes/Objects:**
  - Blueprint vs. instance, fields, properties, methods
- **Constructors:**
  - Default, parameterized
- **Static vs. instance:**
  - Shared/class vs. per object
- **Namespaces & Fully Qualified Names:**
  - Why, when, how; relates to project file/folder structure
- **File/project structure:**
  - One class per file, folders=namespaces, solution/project/files hierarchy
- **Access Modifiers:**
  - `public`, `private`, `protected`, `internal`, (explain, focus on public/private)
  - Table/analogy: who gets in your “house”?
- **Inheritance:**
  - Simple `: BaseClass`, override with `virtual`/`override`, base/derived class logic
- **Class Libraries:**
  - What, why, how to use/reference
- **Partial Classes:**
  - Why designer and code files are split, don’t touch designer unless you want pain
- **NOT IN BEGINNER:**
  - Interfaces, abstract classes (mention for the curious, full coverage advanced)

---

## **15. File I/O**

| Concept              | Beginner          | Advanced     |
| -------------------- | ----------------- | ------------ |
| Read/Write text      | ✔️                |              |
| Append               | ✔️                |              |
| StreamReader/Writer  | ✔️                |              |
| Dialogs (Open/Save)  | ✔️ (WinForms GUI) |              |
| try/catch for I/O    | ✔️                | ✔️           |
| Path handling        | ✔️ (basics)       | ✔️ (complex) |
| Binary file I/O      | Mention/demo      | ✔️           |
| Random access/seek   | Mention/demo      | ✔️           |
| Serialization (JSON) | Demo              | ✔️           |
| Async file I/O       | Demo/tease        | ✔️           |
| FileSystemWatcher    | Tease             | ✔️           |

---

## **16. WinForms GUI (Real Apps, Not Baby Demos)**

- Basic controls: labels, buttons, textboxes, checkboxes, radios, combos, list boxes
- **Menus:** MenuStrip, proper menu setup (File/Edit/Help, etc.)
- **Context menus:** Right-click menus for context actions
- **ToolTips:** Hover help for controls
- **Access keys:** Keyboard shortcuts (Alt + Key), using `&` in text
- **Accept/Cancel buttons:** Enter/Esc activation
- **Tab order:** Setting tab stops for logical keyboard navigation
- **Multiple forms:**
  - Splash screen form, dialogs vs main window, hiding/showing forms
- **Dialogs:**
  - OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, PrintDialog
  - How to use and get results back
- **Naming conventions:**
  - Files/forms: `MainForm.cs`, `SplashScreenForm.cs`
  - Controls: `ExitButton`, `DisplayLabel`, etc.
- **OOP structure:**
  - Every form is a class, controls are objects, code-behind is methods/properties
  - Partial classes: designer vs logic code
- **Good habits:**
  - Keep event handler code short, UI-only in forms, real logic in separate classes
- **Events:**
  - Event-driven model, handlers, why GUIs don’t work without them

---

## **17. GDI+ Graphics (for Etch-O-Sketch and Beyond)**

- What is GDI+: painting on controls, Graphics object
- Paint event: how/why to draw in response to UI updates
- Drawing methods: DrawLine, DrawRectangle, DrawEllipse, DrawString
- Pens, Brushes, Colors
- Using PictureBox/Panel as drawing surface
- Mouse events for interactive drawing
- Double buffering (flicker-free drawing)
- Color dialog for picking colors
- Timers for animation (e.g., shake to erase)
- Sound feedback (bonus: Beep/SoundPlayer)
- How all this fits into partial classes, designer/code split

---

## **18. Professionalism, Documentation & Habits**

- Commenting and documenting code (don’t be an asshole to future you)
- Frequent, meaningful commits to GitHub
- Submitting assignments (Canvas, GitHub link, etc.)
- Rubric adherence, following assignment specs
- Using documentation (MSDN, StackOverflow, etc.)

---

## **19. What’s NOT in This Class (But You’ll See Later)**

- Raising exceptions (`throw`)
- Interfaces, abstract classes
- LINQ, async/await, advanced OOP, design patterns
- Networking, database access, web APIs
- Serialization (beyond basic JSON demo)
- Live file system monitoring, custom controls, MVVM, advanced graphics

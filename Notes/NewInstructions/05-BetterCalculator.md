# Better Calculator

## Project Setup

1. Create a new C# project named **BetterCalculator**.
2. Initialize a new git repository in your project directory.
3. Create a remote repository on GitHub and link it to your local repository.
4. Make an initial commit with your project files and push to GitHub.
5. Add the standard program information header to your code. For example, your header should include:
   - Your name
   - Course number
   - Semester
   - Program name
   - Repository URL
6. Commit the header addition and push to GitHub.
7. Commit your changes periodically and at appropriate milestones as you work on your code.

---

## Assignment Instructions

Extend the capability of your simple calculator program. Your program should:

1. Ask the user for two numbers. Allow the user to enter "Q" at any time to quit.
2. Validate user input. If the input is not a whole number or "Q", prompt the user again.
3. Present a menu to choose an arithmetic operation:
    - 1. Add
    - 2. Subtract
    - 3. Multiply
    - 4. Divide
4. If the user enters an invalid menu option, prompt them again.
5. Display the result of the chosen operation in a clear format (e.g., `4 + 3 = 7`).
6. After each calculation, prompt the user to enter two numbers again or "Q" to quit.
7. If the user enters "Q" at any prompt, display a goodbye message and exit.
8. Wait for the user to press Enter before closing the console window.
9. Remember to include the standard program information header in your code.

---

**Example Output:**

```console
Please enter two numbers. Enter "Q" at any time to quit.
Choose a Number: t
You entered "t", please enter a whole number.
Choose a Number: 4
You entered "4"
Choose a Number: 3
You entered "3"
Choose one of the following options:
1. Add
2. Subtract
3. Multiply
4. Divide
7
You entered "7"
Choose one of the following options:
1. Add
2. Subtract
3. Multiply
4. Divide
1
You entered "1"
4 + 3 = 7
Please enter two numbers. Enter "Q" at any time to quit.
Choose a Number: q
You entered "q"
Have a nice day
Press enter to close this window
```

---

When complete, push your code to your GitHub repository and submit the link as instructed.

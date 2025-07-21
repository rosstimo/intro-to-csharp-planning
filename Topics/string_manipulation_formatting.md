## 7. String Manipulation & Formatting

- **String Creation:**
  - Literal: `string name = "Sheila";`
  - Concatenation: `string full = first + " " + last;`
  - Interpolation: `$"Hi {name}, your score is {score}!"`

- **Common Methods:**
  - `ToUpper()`, `ToLower()`, `Substring()`, `IndexOf()`, `Contains()`, `Split()`, `Join()`
  - Example: `if (input.ToLower().Contains("yes")) { ... }`

- **Formatting and Padding:**
  - Align numbers/strings: `String.Format()`, `PadLeft()`, `PadRight()`, interpolation

- **Parsing and Conversion:**
  - `int.Parse()`, `double.Parse()`, `TryParse()` for safe conversions
  - Always check for invalid input, use `TryParse` inside a `try/catch` or if statement

- **Why it Matters:**
  - Strings are everywhere—files, input, output
  - Learn to manipulate strings early = less pain later

- **Fun Assignments:**
  - Ask for their name and do something custom with it
  - Build a silly MadLib or string reverser


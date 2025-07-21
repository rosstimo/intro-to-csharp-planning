## 3. Primitive Data Types

- **Core Types:**
  - `int` – whole numbers (e.g. 0, -5, 42)
  - `double` – floating-point numbers (e.g. 3.14, -0.5, 1.0)
  - `float` – less-precise decimal (rare in intro class, but know it exists)
  - `char` – a single character (e.g. 'A', '7', '#')
  - `string` – text (e.g. "Hello, World!", "42")
  - `bool` – `true` or `false` only

- **Literal Syntax:**
  - `123`, `-5`, `3.14`, `'C'`, `"dog"`, `true`
  - Type suffixes: `1.5f` for float, `123L` for long (rare, but show a demo)

- **Usage & Examples:**
  - `int age = 21;`
  - `double price = 19.99;`
  - `char grade = 'A';`
  - `string name = "Sheila";`
  - `bool isOn = false;`

- **When to Use Which:**
  - Use `int` for things you count (age, score, number of dogs)
  - Use `double` for money, averages, math that needs decimals
  - Use `string` for anything with text, names, user input
  - Use `bool` for on/off, yes/no, true/false

- **Data Conversion:**
  - Converting between types: `int.Parse("42")`, `double.Parse("3.14")`, `ToString()`
  - Common bugs: parsing fails if string is not a number (try/catch or `TryParse`)

- **Why it Matters:**
  - Wrong type = bugs, errors, or WTF results
  - Memory usage: Don’t use a `double` to count to 10
  - Strong typing in C#: compiler catches mistakes before you run


## 4. Basic Operators

- **Arithmetic Operators:**
  - `+` (addition), `-` (subtraction), `*` (multiplication), `/` (division), `%` (modulus, remainder)
  - Examples:
    ```csharp
    int sum = 5 + 3;      // 8
    double result = 7.0 / 2; // 3.5
    int rem = 9 % 4;      // 1
    ```

- **Assignment Operators:**
  - `=` (assign), `+=`, `-=`, `*=`, `/=`, `%=` (shorthand for changing value)
  - Examples:
    ```csharp
    int count = 1;
    count += 5; // count is now 6
    count *= 2; // count is now 12
    ```

- **Comparison Operators:**
  - `==` (equal), `!=` (not equal), `<`, `>`, `<=`, `>=`
  - Used in conditions, returns bool.
    ```csharp
    bool isSame = (score == 10);
    bool isHigh = (score >= 90);
    ```

- **Logical Operators:**
  - `&&` (and), `||` (or), `!` (not)
  - Used to combine or invert boolean values.
    ```csharp
    bool canVote = (age >= 18) && isCitizen;
    bool notReady = !isReady;
    ```

- **String Concatenation:**
  - `+` to join strings: `"Sheila" + " " + "Rocks!"`
  - Use interpolation for readable code: `$"Name: {name}, Age: {age}"`

- **Operator Precedence:**
  - Order matters! Use parentheses to group calculations if unsure.
  - Example: `3 + 4 * 2` is 11, not 14.
  - Cheat code: `(3 + 4) * 2` is 14.

- **Why it Matters:**
  - Know your operators = less debugging hell, fewer “why is this wrong?!” moments.
  - Good code reads like math you actually understand.


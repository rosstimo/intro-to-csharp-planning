## Static Variables in C#: Best Practice (Beginner Level)

- **Only use **``** at the class level.**

  - Declare static variables (fields) at the top of your class, outside of any method.
  - Example:
    ```csharp
    public class Example {
        private static int counter = 0;
        public void Increment() {
            counter++;
            Console.WriteLine(counter);
        }
    }
    ```

- **When to use:**

  - When you need a value to be shared by all instances of a class (ex: a counter, a cache, a shared constant).
  - For utility/helper methods (like `Math.Abs()`) that don’t rely on object state.

- **When NOT to use:**

  - If each object/instance should have its *own* value, use a regular (non-static) field instead.
  - Don’t try to create static local variables inside methods—use class-level static fields only.

- **Naming:**

  - Use `camelCase` for private static fields (`private static int callCount`)
  - Use `PascalCase` for public static fields/properties (`public static int MaxValue`)

- **Access:**

  - Access static members using the class name: `Example.counter`
  - Static members can be accessed even if no objects are created.

- **TL;DR:**

  - C# does NOT support static local variables inside methods (unlike VB.NET).
  - For persistent, method-shared state, use a private static field at the class level.
  - Keep it simple. If you’re not sure if it should be static, it probably shouldn’t be!


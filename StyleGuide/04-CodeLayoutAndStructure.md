# 04. Code Layout and Structure

Code layout refers to how you organize your code within files and projects. A consistent structure helps others (and your future self) navigate the code. Here are guidelines for organizing C# code:

* **One Type per File:** Define only one top-level **public class** (or struct, interface, enum) per file, and name the file after the class. For example, `Customer.cs` contains the `Customer` class. This is the standard in .NET and makes things easy to find. You can have inner classes or private supporting types in the same file if needed, but if a class is public (or would make sense on its own) give it its own file.
* **Order of Members:** Inside a class, order members in a logical way. A common order is: **fields** (and constants) first, then **properties**, then **constructors**, then **methods**. Another approach is to group by functionality. The key is to be consistent. Also, group related things together (for example, put private helper methods together at the bottom, or all event-handling methods in one region). Consistent ordering helps readers know where to look for something.
* **Consistent Access Modifiers:** Consider ordering by accessibility – for example, all public members before private ones – or the reverse. There’s no one correct order, but don’t scatter public and private members randomly. One common convention is: public methods at top, then internal, then protected, then private. Within each group, you might order by their purpose. Find an approach that makes sense and stick to it.
* **Always Specify Access Level:** Explicitly mark members with `public`, `private`, etc., rather than relying on defaults. For instance, top-level classes without a modifier default to internal, but you should still write `internal class MyClass` or `public class MyClass` for clarity. Likewise, explicitly mark class members `private` if they are private. This makes the code’s intent clear.
* **Keep Methods Focused:** Each method should generally do one logical task. If a method is very long or does too many things, consider splitting it into smaller methods. Not only is this good design, it also means each method can have a clear name and purpose, which is part of style. A rule of thumb: if you feel you need extensive comments to explain a method, it might be too complex. Break it down if possible.
* **Use Regions Sparingly:** C# allows `#region` to collapse code blocks. Beginners often overuse them. You usually don’t need regions in simple classes – the structure should be evident by good ordering and small size. Regions can be handy to hide boilerplate or for very large classes, but in well-factored code they are rarely needed. Use them only when they truly help.
* **Spacing in Code Structure:** We touched on blank lines between methods – definitely do that. Also consider adding a blank line between logical sections inside a method if it helps readability (for example, a block of code preparing data, then a block processing it). But don’t overdo blank lines – use them to create paragraphs of code logically.
* **Project Structure:** At a higher level, place classes in appropriate namespaces that reflect their functionality. For example, `Models`, `Services`, etc. This might be beyond a beginner’s immediate concern, but understand that as projects grow, organizing files into folders/namespaces is also a part of style (though more about architecture).
* **File-Scoped Namespace:** If using C# 10 or later, you can use file-scoped namespaces (`namespace MyApp.Models;` at the top) to avoid an extra brace level and keep code less indented. This is recommended for a cleaner file structure, with everything in that file under the declared namespace.

**Good Example:** Each public type in its own file, clear member ordering
*File: `Product.cs`*

```csharp
namespace MyStore.Models;

public class Product
{
    // Fields (private) at top
    private static int s_totalProducts = 0;   // static field
    private readonly int _id;                // instance field

    // Properties
    public int Id => _id;
    public string Name { get; set; }

    // Constructor
    public Product(string name)
    {
        _id = ++s_totalProducts;
        Name = name;
    }

    // Public method
    public void PrintDetails()
    {
        Console.WriteLine($"Product {_id}: {Name}");
    }

    // Private helper method (grouped at bottom)
    private string GetLabel() 
    {
        return $"ID={_id}, Name={Name}";
    }
}
```

*File: `Order.cs`*

```csharp
namespace MyStore.Models;

public class Order
{
    // ... definition of Order class ...
}
```

In the good example, `Product` and `Order` are in separate files, making each file focused. Inside `Product`, members are organized clearly: fields, then properties, then constructor, then methods. This structure is easy to navigate and maintain.

**Bad Example:** Multiple classes in one file, disorganized members
*File: `Stuff.cs`*

```csharp
namespace MyStore.Models;

public class Product 
{
    public string Name;
    private int _id;
    public Product(string name) { Name = name; }
    public void PrintDetails() { Console.WriteLine($"Product {_id}: {Name}"); }
    // Bad: Fields, constructor, and methods are mixed without clear order
}

public class Order 
{
    public Product[] items;
    public int total;
    // ... (class continues) ...
}
public class OrderManager 
{
    // Three public classes in one file – bad practice, each should be separate.
}
```

*File: `Mixed.cs`*

```csharp
public class Mixed
{
    public int Data;
    private string GetData() { return Data.ToString(); }
    public string Info;
    // Bad: Member order is nonsensical; fields and methods interleaved,
    // and the class is doing too many things perhaps.
    // Also no access modifier on class (defaults to internal, but should be stated).
}
```

In the bad examples, multiple classes share one file (making it hard to locate `Order` or `OrderManager` quickly), and the members inside classes are not in a logical order. Following the good practices helps ensure each file and class has a clear purpose and structure.

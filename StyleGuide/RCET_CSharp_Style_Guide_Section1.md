
# RCET C# Style Guide  
*Based on the Microsoft and .NET Runtime Team’s official conventions*  
*For students learning C# for the first time*

---

## Section 1: File and Project Organization

---

### 1.1 GitHub Repository Naming

Use **lowercase-with-dashes** for repository names. This is the most readable and widely accepted format on GitHub.

✅ **Do:**
- `intro-to-csharp`
- `rcet-student-projects`
- `robot-control-app`

🚫 **Don't:**
- `IntroToCSharp`
- `StudentProjects2025`
- `robot_control_project_ver3`

---

💡 **Best Practice Tip**

Visual Studio defaults to using your **Solution name** (e.g., `StudentManager`) as the GitHub repository name.  
This is fine for private repos or internal projects.  
But for public-facing repositories on GitHub:

✅ **Change the name to use lowercase-with-dashes** before creating/pushing.

📘 **Why?**
- Easier to read in URLs
- Standard across GitHub projects
- Matches conventions used by Microsoft (.NET repos use this style)

🛠️ **How to fix it in Visual Studio:**
When adding your project to source control:
1. Go to **"Create Git Repository"**
2. Change the **Repository Name** to `lowercase-with-dashes`
3. Push to GitHub

---

### 1.2 Solution Naming (`.sln` File)

Use **PascalCase** and match the main project name.

✅ **Do:**
- `StudentManager.sln`
- `WeatherApp.sln`

🚫 **Don't:**
- `studentmanagerfinal.sln`
- `weather_app_v2.sln`

---

### 1.3 Project Naming (`.csproj`)

Each project should:
- Use **PascalCase**
- Match its purpose (e.g., `StudentManager.UI`, `StudentManager.Core`)
- Be kept short but specific

✅ **Do:**
- `RobotController.csproj`
- `StudentManager.Core.csproj`

🚫 **Don't:**
- `robotcontrollerfinalv3project.csproj`

---

### 1.4 File Naming

Each file:
- Should contain one class or struct only
- Should use **PascalCase**
- Must match the class name exactly (case-sensitive on some systems)

✅ **Do:**
- `Student.cs` → `public class Student { }`
- `GradeCalculator.cs` → `public class GradeCalculator { }`

🚫 **Don't:**
- `student.cs`
- `grades.cs` → `public class GradeCalculator { }`

---

### 1.5 Folder Structure (Basic)

Organize by feature or layer. Use **PascalCase** for folders too.

✅ Example:
```
/StudentManager
│
├── StudentManager.sln
├── StudentManager.Core/
│   ├── Models/
│   │   ├── Student.cs
│   │   └── Course.cs
│   └── Services/
│       └── GradeCalculator.cs
├── StudentManager.UI/
│   └── Program.cs
```

---

✅ Summary Table

| Item                  | Naming Rule         | Example                      |
|-----------------------|---------------------|------------------------------|
| GitHub Repository     | lowercase-dashes    | `intro-to-csharp`            |
| Solution (`.sln`)     | PascalCase          | `StudentManager.sln`         |
| Project (`.csproj`)   | PascalCase          | `RobotController.csproj`     |
| File Names            | PascalCase          | `Student.cs`, `Dog.cs`       |
| Folders               | PascalCase          | `Models/`, `Services/`       |

---

### 1.6 What Belongs in `Program.cs`

Your `Program.cs` file should be short and only contain the code needed to start your app.

---

1. **The `Main` method**
   Every console program needs a `Main` method. It’s the starting point of your application.

   ```csharp
   class Program
   {
       static void Main(string[] args)
       {
           // Program starts here
       }
   }
   ```

---

2. **Very Basic App Flow**
   Keep this file simple. Use it to greet the user and hand control off to other classes.

   ✅ Good:
   ```csharp
   static void Main(string[] args)
   {
       Console.WriteLine("Welcome!");
       var app = new StudentApp();
       app.Run();
   }
   ```

---

3. **Top-Level Error Handling**
   You can catch unexpected errors here so they don’t crash your app.

   ```csharp
   static void Main(string[] args)
   {
       try
       {
           new StudentApp().Run();
       }
       catch (Exception ex)
       {
           Console.WriteLine("Something went wrong: " + ex.Message);
       }
   }
   ```

---

4. **No Business Logic**
   Do not put logic like input, calculations, file access, or decision-making in `Program.cs`. Move that logic into other classes.

   ❌ Bad:
   ```csharp
   static void Main(string[] args)
   {
       Console.WriteLine("Enter a number:");
       int num = int.Parse(Console.ReadLine());
       Console.WriteLine("Square: " + (num * num));
   }
   ```

---

✳️ **Tip:** If `Program.cs` starts getting longer than 10–15 lines (excluding blank lines), it’s time to move that logic into a new class.

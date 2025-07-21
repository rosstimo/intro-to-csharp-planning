# How to Create and Run a C# Project in VS Code (Absolute Beginner Guide)

This guide will help you create and run cross-platform C# Console projects in Visual Studio Code (VS Code), and add your project to source control using GitHub. No prior experience is required!

---

## 1. Install Prerequisites

- **VS Code:** Download and install from [code.visualstudio.com](https://code.visualstudio.com/)
- **.NET SDK:** Download and install from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- **C# Extension:** In VS Code, go to Extensions (Ctrl+Shift+X), search for "C#" (by Microsoft), and install it.
- **Git:** Install from [git-scm.com](https://git-scm.com/) if not already installed.

---

## 2. Create a New Console App Project (Cross-Platform)

1. Open VS Code.
2. Open a folder where you want your project (File > Open Folder...).
3. Open a new terminal in VS Code (Terminal > New Terminal).
4. Run:
   ```zsh
   dotnet new console -n HelloWorld
   cd HelloWorld
   code .
   ```
5. Edit `Program.cs` as needed.
6. To run your program, use the terminal:
   ```zsh
   dotnet run
   ```
7. The output will appear in the terminal.

---

## 3. Add Your Project to Source Control with GitHub

1. In the terminal, initialize git:
   ```zsh
   git init
   git add .
   git commit -m "Initial commit"
   ```
2. Create a new repository on [github.com](https://github.com/).
3. Follow the instructions GitHub gives you to add the remote and push:
   ```zsh
   git remote add origin https://github.com/yourusername/your-repo-name.git
   git branch -M main
   git push -u origin main
   ```
4. In VS Code, you can use the Source Control tab (left sidebar) to make future commits and pushes.

---

## 4. Tips for Beginners

- Save your work often (`Ctrl+S`).
- Use the Explorer (left sidebar) to see your files.
- If you get stuck, right-click files for more options.
- You can always delete a project and start over if needed.

---

## 5. More Help

- [Microsoft C# Beginner Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [VS Code C# Docs](https://code.visualstudio.com/docs/languages/csharp)
- [GitHub Docs: Get started with Git and VS Code](https://docs.github.com/en/get-started/getting-started-with-git/getting-started-with-git-and-visual-studio-code)

---

You are ready to start coding in C# and using GitHub with VS Code!

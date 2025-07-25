# How to Create and Run a C# Project in Visual Studio (Absolute Beginner Guide)

This guide will help you create and run both Console and Windows Forms (WinForms) C# projects in Visual Studio, and add your project to source control using GitHub. No prior experience is required!

---

## 1. Install Visual Studio

- Download Visual Studio Community Edition from [visualstudio.microsoft.com](https://visualstudio.microsoft.com/).
- Run the installer and select the "+ .NET desktop development" workload.
- Complete the installation.

---

## 2. Create a New Console App Project

1. Open Visual Studio.
2. Click **File > New > Project...**
3. In the search box, type `console` and select **Console App (.NET Core or .NET 6/7/8)**.
4. Click **Next**.
5. Enter a project name (e.g., `HelloWorld`).
6. Choose a location to save your project.
7. Click **Create**.
8. Visual Studio will create a simple program for you. You can edit the code in `Program.cs`.
9. To run your program, click the green **Start** button or press `F5`.
10. The output will appear in a console window.

---

## 3. Create a New Windows Forms (WinForms) App Project

1. Open Visual Studio.
2. Click **File > New > Project...**
3. In the search box, type `winforms` and select **Windows Forms App (.NET)**.
4. Click **Next**.
5. Enter a project name (e.g., `MyWinFormsApp`).
6. Choose a location to save your project.
7. Click **Create**.
8. The designer will open. You can drag and drop controls (buttons, labels, etc.) from the Toolbox onto the form.
9. Double-click a control (like a button) to add code for its events (like `button1_Click`).
10. To run your app, click the green **Start** button or press `F5`.
11. Your Windows app will appear. Try clicking your buttons!

---

## 4. Add Your Project to Source Control with GitHub

1. In Visual Studio, open your project.
2. Go to **View > Git Changes** (or **View > Other Windows > Git Changes**).
3. Click **Create Git Repository** (if prompted).
4. Enter a name for your repository and select **GitHub** as the host.
5. Sign in to your GitHub account if needed.
6. Click **Create and Push** to upload your project to GitHub.
7. After setup, you can make changes, write a commit message in the Git Changes window, and click **Commit All and Push** to save your work to GitHub.

> If you don't see GitHub options, you can also create a repository on [github.com](https://github.com/), then use the **Git** menu in Visual Studio to add a remote and push your code.

---

## 5. Tips for Beginners

- Save your work often (`Ctrl+S`).
- Use the **Solution Explorer** (right side) to see your files.
- If you get stuck, right-click and choose **Properties** or **Go to Definition** for help.
- You can always delete a project and start over if needed.

---

## 6. More Help

- [Microsoft C# Beginner Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Visual Studio Getting Started](https://learn.microsoft.com/en-us/visualstudio/get-started/)
- [GitHub Docs: Get started with Git and Visual Studio](https://docs.github.com/en/get-started/getting-started-with-git/getting-started-with-git-and-visual-studio)

---

You are ready to start coding in C# and using GitHub!

# 🧪 Course Content Creation Workflow (Top-Level)

This file describes the **overall workflow** for planning, creating, and maintaining content in the `intro-to-csharp-planning` repository. It is meant for **course developers, instructors, and AI agents** working on the RCET C# course. Assume high intelligence but zero common sense—**every step is explicit**. No guessing, no vibes-based edits.

---

## 🚧 Prerequisites

- Understand this repo is **not for students**. It’s where we build everything before it goes live.
- You should have:
  - A basic understanding of C#
  - Familiarity with Markdown and Git
  - A working dev environment (Visual Studio or VS Code w/ .NET SDK)
  - Access to the [RCET C# Style Guide](StyleGuide/README.md)
  - A GitHub account (if collaborating)
- Never work in isolation—**check planning docs first**, then update them when changes are made.

---

## 🔁 Standard Workflow for Content Development

### 1. Review the Plan

✅ Go to `Notes/Schedule.md` and `Notes/Planning.md`  
- Figure out what topic or assignment you're working on  
- Check where it falls in the 16-week course  
- Double-check what already exists before starting anything new  
- If the task isn’t listed in `Planning.md`, **add it**

---

### 2. Use the Right Directory

Depending on what you're building, follow the appropriate sub-workflow:

| You're Creating...       | Go To…                      |
|--------------------------|-----------------------------|
| A concept explanation    | `Topics/`                   |
| A coding assignment      | `Assignments/`              |
| Student-facing instructions | `Assignments/00-AssignmentInstructions/` |
| A runnable code snippet  | `Examples/`                 |
| A quiz or test           | `Quizzes/` *(planned)*      |
| A grading rubric         | `Rubrics/` *(planned)*      |
| Anything else            | `Notes/` or ask in `Planning.md` |

---

### 3. Follow the Directory Workflow

Every content directory has its own `workflow.md` file.
- Read it **start to finish** before touching anything
- Follow the steps **exactly**
- Don’t skip “obvious” steps
- If something is unclear or missing, update the workflow after you figure it out

---

### 4. Follow the Style Guide

Always:
- Format and name code according to `StyleGuide/`
- Use consistent examples, formatting, comments
- Copy/paste patterns if needed—**don’t invent new style**
- Reference the official Microsoft C# docs when explaining language features:
  - `https://learn.microsoft.com/en-us/dotnet/csharp/`

---

### 5. Verify Everything

Before committing anything:
- ✅ Run all code samples (they must compile and behave as described)
- ✅ Preview all Markdown (headings, lists, links, code blocks)
- ✅ Spell-check it (VS Code has plugins, use 'em)
- ✅ Click all links (external and internal) to verify they're not broken
- ✅ Make sure you didn’t leave any TODOs or placeholders

---

### 6. Document Your Work

If you made changes:
- Add or update entries in `Notes/Planning.md`
- If you changed the schedule (e.g. added a new assignment), update `Notes/Schedule.md`
- If you created a new assignment, add it to the instruction directory and assign a proper number/title

---

### 7. Commit & Push

Each commit should be:
- Small and focused: *“Add loop examples for topic 05”*
- Pushed to GitHub regularly
- Never include compiled binaries, IDE configs, or `.vs`, `bin/`, `obj/` folders

If you’re making major changes:
- Consider working on a branch and making a pull request for review

---

### 8. Keep It Clean

- One source of truth per item. No duplicate instructions.
- Obsolete stuff should be marked as deprecated or deleted.
- Flag broken links, outdated examples, or bad explanations for revision.

---

## 📌 Reminders

- 🔍 **Double-check the style guide** before submitting anything with code
- 📚 **Link to official Microsoft Docs** for any C# concept you mention
- 🔗 **Test all URLs**
- 🧠 **Assume your future self is sleep-deprived and confused**—write clearly

---

## 💀 Shit to Never Do

- Don’t edit files without reading the related workflow
- Don’t leave broken examples or half-finished assignments in the repo
- Don’t change filenames or assignment numbers casually—it’ll break everything
- Don’t skip testing your code
- Don’t assume someone else will fix your mess. Clean up as you go.

---

## 🔥 Final Word

This repo is your forge. Everything students see later starts here. If it's garbage here, it'll be garbage in class. Treat this like the control room for a rocket launch: no fuckups, no confusion, no “oops.”

Build it right, or don't build it at all.

# RCET C# Style Guide

This directory contains the official style guide for RCET C# coursework. Use this README as a quick reference for the most important style rules. For full explanations and examples, follow the links in the table of contents below.

---

## Quick Reference Cheat Sheet

**Formatting & Braces:**
- Always put opening and closing braces `{}` on their own lines (Allman style).
- Always use braces, even for single-line `if` or loop bodies.
- One statement and one declaration per line.
- Use blank lines to separate logical sections (e.g. between methods).
- See: [01-CodeFormatting.md](01-CodeFormatting.md)

**Indentation & Spacing:**
- Indent code blocks by 4 spaces (never tabs).
- Put a space after keywords (e.g. `if (` not `if(`).
- Never mix tabs and spaces.
- See: [02-IndentationAndSpacing.md](02-IndentationAndSpacing.md)

**Naming Conventions:**
- Use PascalCase for types, classes, public members, and methods.
- Use camelCase for local variables and parameters.
- Private fields: camelCase with a leading underscore (e.g. `_count`).
- Constants: ALL_CAPS (e.g. `MAX_SIZE`).
- Boolean names should read like questions (e.g. `isReady`, `hasItems`).
- See: [03-NamingConventions.md](03-NamingConventions.md)

**Commenting:**
- Use `//` for short comments above the code they describe.
- Comment the "why" not the "what"—explain intent, not obvious code.
- Keep comments up to date; remove stale or misleading comments.
- Use XML comments (`/// <summary>...</summary>`) for public APIs.
- See: [05-Commenting.md](05-Commenting.md)

**File & Project Structure:**
- One public type per file; file name matches the type.
- Folders mirror namespaces; avoid dumping files at the root.
- Use PascalCase for all file and folder names; no spaces or underscores.
- Use plural folder names for collections (e.g. `Models`, `Assignments`).
- See: [06-ProjectStructure.md](06-ProjectStructure.md)

**Git & GitHub:**
- Commit often with clear messages.
- Don’t commit commented-out code or temporary files.
- See: [07-GitBestPractices.md](07-GitBestPractices.md)

---

## Table of Contents

1. [01-CodeFormatting.md](01-CodeFormatting.md) — Code Formatting
2. [02-IndentationAndSpacing.md](02-IndentationAndSpacing.md) — Indentation and Spacing
3. [03-NamingConventions.md](03-NamingConventions.md) — Naming Conventions
4. [04-CodeLayoutAndStructure.md](04-CodeLayoutAndStructure.md) — Code Layout and Structure
5. [05-Commenting.md](05-Commenting.md) — Commenting
6. [06-ProjectStructure.md](06-ProjectStructure.md) — Project Structure
7. [07-GitBestPractices.md](07-GitBestPractices.md) — Git & GitHub Best Practices
8. [RCET_CSharp_Style_Guide_Section1.md](RCET_CSharp_Style_Guide_Section1.md) — Legacy/Reference Section
9. [style.md](style.md) — Additional Style Notes

---

For comprehensive explanations and more examples, follow the links above. All RCET C# assignments must follow these style rules.

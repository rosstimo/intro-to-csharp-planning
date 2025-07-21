## 15. File I/O

- **Text Files (Beginner Focus):**
  - `File.ReadAllText`, `File.ReadAllLines`: read file contents into string/array
  - `File.WriteAllText`, `File.WriteAllLines`: write (overwrite) a file
  - `File.AppendAllText`, `File.AppendAllLines`: add to the end of a file
  - `StreamReader` / `StreamWriter`: read/write line-by-line (with `using` block)
  - Always wrap file access in `try/catch`

- **Dialogs (WinForms):**
  - OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, PrintDialog for GUIs
  - How to use, get results, basic error handling

- **Path Handling:**
  - Use `Path.Combine` to avoid “it works on my computer but not theirs” syndrome

- **Demo Only (Save for Advanced):**
  - Binary file read/write (`File.ReadAllBytes`, `File.WriteAllBytes`)
  - Random access with `FileStream` and `Seek`
  - Serialization (JSON, XML), async file I/O, FileSystemWatcher

- **Why it Matters:**
  - Reading/writing files = saving/loading data, config, user input
  - 99% of practical programming touches a file at some point


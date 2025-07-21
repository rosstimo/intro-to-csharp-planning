## 16. WinForms GUI

- **Basic Controls:**
  - Labels, buttons, textboxes, checkboxes, radio buttons, combo boxes, list boxes

- **Menus & Context Menus:**
  - Main menu (MenuStrip), context menu (ContextMenuStrip) for right-click actions
  - Standard layout: File/Edit/Help, with appropriate commands

- **ToolTips & Access Keys:**
  - ToolTips for all controls (hover help)
  - Access keys (`&` in text for Alt+key shortcuts)
  - Accept button (Enter), Cancel button (Esc)
  - Set tab order for good keyboard navigation

- **Multiple Forms:**
  - Show/hide multiple forms (Show, ShowDialog)
  - Splash screen, dialog boxes vs main window

- **Dialog Boxes:**
  - OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, PrintDialog
  - Use results, error handling

- **Naming Conventions:**
  - Files/forms: `MainForm.cs`, `SplashScreenForm.cs`
  - Controls: `SubmitButton`, `NameTextBox`, etc.

- **OOP Structure:**
  - Each form is a class; controls are objects
  - Event handlers: wire up, keep logic short, call other methods for real work
  - Partial classes: designer-generated code vs your logic

- **Events:**
  - Event-driven model: what, why, how; buttons, input, timers

- **Good Habits:**
  - Layout for readability and usability
  - Separate logic from UI (don’t cram everything into a button click)
  - Test with both mouse and keyboard


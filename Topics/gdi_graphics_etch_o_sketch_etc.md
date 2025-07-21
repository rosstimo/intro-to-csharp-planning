## 17. GDI+ Graphics (Etch-O-Sketch, etc)

- **What is GDI+?**
  - Windows’ graphics engine for drawing on controls
  - Used for custom UI, games, drawing apps

- **Drawing Basics:**
  - Paint event: where custom drawing lives
  - `Graphics` object: `e.Graphics` in Paint event
  - Methods: `DrawLine`, `DrawRectangle`, `DrawEllipse`, `DrawString`
  - Pen and Brush: set color, thickness, fill

- **Drawing Surface:**
  - PictureBox or Panel for custom drawing area
  - Store “drawing state” (list of points, lines, or bitmap for persistence)
  - Double-buffering for smooth, flicker-free drawing

- **User Interaction:**
  - Mouse events: `MouseDown`, `MouseMove`, `MouseUp` for drawing
  - Color picker: `ColorDialog` to let user select pen color

- **Animation & Sound:**
  - Use Timer for simple animations (e.g., “shake to erase”)
  - `Console.Beep` or SoundPlayer for feedback

- **Integration:**
  - Menus, context menus, tooltips, keyboard shortcuts for drawing actions
  - Partial classes: GUI designer code split from logic

- **Why it Matters:**
  - Unleash creativity, real interactive programming, fun as hell
  - Teaches UI, graphics, and event handling skills


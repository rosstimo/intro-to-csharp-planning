# Etch-O-Sketch

## Project Setup

1. Create a new C# Windows Forms project named **EtchOSketch**.
2. Initialize a new git repository in your project directory.
3. Create a remote repository on GitHub and link it to your local repository.
4. Make an initial commit with your project files and push to GitHub.
5. Add the standard program information header to your code. For example, your header should include:
   - Your name
   - Course number
   - Semester
   - Program name
   - Repository URL
6. Commit the header addition and push to GitHub.
7. Commit your changes periodically and at appropriate milestones as you work on your code.

---

## Assignment Instructions

Create a Windows Forms application that simulates an Etch-A-Sketch. Your form must include:

- A DisplayPictureBox for drawing (drawing only occurs within this box)
- Buttons: SelectColor, DrawWaveforms, Clear, Exit
- Top menu and context menu with:
  - File: Exit
  - Edit: Select Color, Draw Waveforms, Clear
  - Help: About
- Tooltips on the picture box and all buttons
- Proper tab order for all user input and controls
- Access keys for each button and/or menu item
- DrawWaveformsButton as the accept button (Enter)
- Clear button as the cancel button (Esc)

### Drawing and User Interaction

- Drawing occurs when the left mouse button is held and moved over the picture box.
- Present the color dialog for the user to select a new color for drawing on these events:
  - Select Color button
  - Select Color top menu item
  - Select Color context menu item
  - Mouse middle click on the picture box
- When the Erase button is clicked, the picture box should "shake" and be erased. (include a sound for extra street cred)
- When the Draw Waveforms button is clicked:
  - The picture box is erased
  - A 10x10 scope graticule is drawn evenly spaced within the picture box
  - Sine, Cosine, and Tangent waves are drawn in different colors, filling the picture box top to bottom, one cycle wide

---

## Example Form

(Include a screenshot or diagram of the expected form layout if available.)

---


When complete, push your code to your GitHub repository and submit the link as instructed.

# Workflow for Maintaining Course Notes

This workflow guides content creators through updating and utilizing the planning documents in the **Notes** directory. Follow these steps whenever the course plan changes or when you create new content, to ensure all high-level documents stay consistent and useful.

1. **Review the Current Plan:** Before making any changes, open **Schedule.md** and **Planning.md** to understand the existing course structure and pending tasks. Ensure you know the course’s learning outcomes and weekly objectives. (If the course has formal learning outcomes, keep those in mind as you work, even though they may not be explicitly listed here.)

2. **Update the Course Schedule (Schedule.md) as Needed:** If you add, remove, or reorder topics or assignments:
   - Open `Notes/Schedule.md` in a text editor.
   - Locate the week that needs changes. Maintain the same format (use bullet points under the correct week).
   - **Insert or modify entries** to reflect the new plan. For example, if Week 5 is now adding a “File I/O” topic, add a bullet like `- File I/O basics (reading/writing files)` under Week 5. Include any new assignment names or activities under the appropriate week.
   - Double-check consistency: The week’s topics in Schedule.md should match the content in the Topics directory and the assignments in the Assignments directory. For instance, if you added "File I/O basics" to Week 5 here, ensure a corresponding topic file (e.g. `Topics/file_i_o.md`) exists or is being created, and that an assignment on File I/O (if planned) is accounted for in Assignments.
   - **Save** the file and verify the Markdown formatting is correct (e.g. each week is a heading, sub-items are indented properly).

3. **Align Other Materials with Schedule Changes:** If Schedule.md was updated:
   - Go to the **Topics** directory and confirm that any topic files mentioned in the updated schedule exist and cover the intended material. If not, create a placeholder topic file (or note in Planning.md to create it).
   - Go to the **Assignments** directory and ensure any assignment referenced in the schedule (by name or number) is present. If you moved an assignment to a different week, its numbering might stay the same but check that the timing still makes sense (e.g. students have learned the required concepts by that week).
   - Check cross-references: if other planning documents or instructions mention the old sequence (for example, an assignment instruction saying “as you learned last week”), update those if the schedule shifted.

4. **Add or Update Planning Notes (Planning.md):** Use *Planning.md* to log any new tasks or mark completed tasks:
   - If you decided to create a new quiz, assignment, or topic, add a bullet under *Objectives* (or an appropriate section) describing that task. For example, “- create Week 5 File I/O lesson materials”.
   - If a task is finished, you may mark it as done (if using checkboxes in Markdown) or remove it if the list is purely for active tasks. For example, once the style guide is completed, you might update the line from “create a style guide” to “✅ style guide created (needs periodic updates)”.
   - Keep the list tidy: remove or refine tasks that are no longer relevant. For instance, if the plan to use a `NewInstructions` folder was changed in favor of keeping instructions in the Assignments directory, update or annotate that in the planning notes to avoid confusion.
   - **Save** changes to Planning.md.

5. **Leverage Legacy References (OldCourseContent.md & OldInstructions):** When developing a new piece of content (like a lesson or assignment), consult these references for inspiration or to avoid past pitfalls:
   - Open the relevant old instruction file if one exists (e.g., if creating a C# “Better Calculator” assignment, read `OldInstructions/05-BetterCalculator.md` to see what was expected in the VB version).
   - Extract useful details (like what the program should do) but **do not copy text verbatim** – rewrite it in C# context and in a fresh way for the new course.
   - If OldCourseContent.md has related links or resources (many are placeholders marked “(URL)”), find updated C# equivalents for those resources if you need to include similar references in new materials. (For example, if it mentions “Arithmetic Operators in Visual Basic (URL)”, you would find the C# documentation for arithmetic operators to use in your new topic file.)

6. **Avoid Modifying Legacy Files:** Do not edit files in *OldInstructions/* or the content of *OldCourseContent.md* except for minor annotation:
   - These are preserved for historical reference. Changing them might cause confusion about what was originally in the old course.
   - If you must note something (e.g., “see C# equivalent in ...”), add a clearly marked note or comment rather than removing the old info.
   - If you determine a legacy file is no longer needed at all (e.g., you’ve converted all its information and it’s not useful anymore), you can propose removing it from the repository. If you do, ensure nothing else is still referencing it.

7. **Maintain Alignment with Course Objectives:** Whenever you update these notes, think about backward design:
   - Ask yourself: “Does this change still ensure students will achieve the intended outcomes?” For example, if you’re adding a new assignment, does it test skills from recent topics (and are those topics adequately covered before the assignment)?
   - Make a habit of cross-checking *Schedule.md* against any formal course outcome list (if available). If the course outcome says “students will be able to use arrays,” ensure the schedule has a week on arrays (it does in Week 6, for example) and perhaps an assignment or exercise on arrays around that time.

8. **Double-Check Links and References:** If you add any links in these planning documents (to external resources or to files within the repo):
   - Verify that each link is correct. For local files, use relative paths and ensure the spelling and case match the actual file names (GitHub is case-sensitive in links).
   - For external URLs (like Microsoft Docs links in OldCourseContent), make sure they are current and accessible. Update the URL if the resource moved.
   - If you introduce a new document, update any “Additional Resources” or table of contents in the root README or elsewhere if needed.

9. **Save and Commit:** After making changes to any Notes files:
   - Save your edits and preview them in a Markdown viewer to confirm formatting.
   - Commit your changes with a clear message, e.g., “Update Week 5 schedule and add File I/O topic plan” or “Mark assignment 3 as completed in Planning.md”.
   - Push the commit so the team has the updated plan.

By following this workflow, you ensure the **Notes** remain a reliable single source of truth for the course structure. This helps all content creators stay on the same page and keeps the course materials aligned with the overall plan and learning goals.

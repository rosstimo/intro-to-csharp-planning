# Workflow for Creating and Updating Assignments

This workflow ensures that all assignments are consistent, beginner-friendly, and aligned with the course objectives. Follow these steps when creating or updating assignments.

## 1. Review the Course Schedule

- Open `Notes/Schedule.md` to identify the week and topic for the assignment.
- Ensure the assignment aligns with the topics and learning objectives for that week.

## 2. Create or Update Assignment Files

- Navigate to the `Assignments/` directory.
- If creating a new assignment:
  - Create a new folder named `XX-AssignmentName/`, where `XX` is the week number and `AssignmentName` is a brief, descriptive name.
  - Add a subfolder for the project files (e.g., `Assignments/05-BetterCalculator/BetterCalculator/`).
  - Add a Markdown file to `00-AssignmentInstructions/` with detailed instructions for the assignment.
  - Develop a rubric alongside the instructions to ensure consistent grading criteria.
- If updating an existing assignment:
  - Open the relevant folder and files.
  - Make necessary changes to the project files, instructions, and rubric.

## 3. Write Clear Instructions and Validate Code

- Use the `00-AssignmentInstructions/` folder for all assignment instructions.
- Include the following sections in each instruction file:
  - **Objective:** What students will learn or achieve by completing the assignment.
  - **Requirements:** Any specific requirements or constraints (e.g., "Use a `for` loop").
  - **Steps:** A step-by-step guide to completing the assignment.
  - **Sample Input/Output:** Provide examples to clarify expectations.
  - **Hints/Tips:** Optional section with helpful advice or common pitfalls to avoid.
- Write and test all code to ensure it compiles and runs without errors.
- Validate that the code reflects the skills and concepts students have learned up to that point in the course.
- Revise instructions if the code cannot be written based on them, ensuring clarity and comprehensiveness.

## 4. Test the Assignment

- Verify that the assignment meets the learning objectives and is appropriate for beginners.
- Include sample input and output in the instructions to demonstrate expected behavior.
- Check that the code follows the style and formatting rules in the `StyleGuide/` directory.
- If discrepancies or challenges arise while adhering to the style guide, evaluate whether the guide needs updates or clarifications.
- If it seems like the style guide needs updates, consult with the team or ask for input to ensure changes align with course objectives and maintain consistency.

## 5. Align with Style Guide

- Follow the coding and formatting rules in the `StyleGuide/` directory.
- Cite specific style guide files in the instructions where applicable.

## 6. Update Related Materials

- Check the `Topics/` directory to ensure the relevant topic file covers the concepts needed for the assignment.
- Update `Notes/Schedule.md` if the assignment introduces new topics or changes the course plan.

## 7. Save and Commit Changes

- Save all changes and preview Markdown files to ensure proper formatting.
- Commit changes with a clear message, e.g., "Add Week 5 Better Calculator assignment."
- Push the commit to the repository.

---

By following this workflow, you ensure that assignments are clear, consistent, and effective learning tools for students.

# CC-APPSDEV22 — Semi-Final Week 9 Documentation

**Activity:** Building a Component-Based UI with Blazor WebAssembly  
**Name:** [Your Full Name]  
**Attempt:** Attempt 2  
**GitHub URL:** [Paste your repository URL]  
**Google Drive PDF URL:** [Paste your viewable Google Drive URL]

## 1. Objectives
- Scaffold and run a Blazor WebAssembly project using the .NET CLI.
- Apply Razor syntax to combine C# logic and HTML markup.
- Create reusable components and pass data through `[Parameter]`.
- Customize the layout and implement routing with route parameters.
- Handle user interactions through Blazor event handlers.
- Apply CSS isolation and loading-state UI.

## 2. Source Code Snippets
Include screenshots or copied excerpts from:
- `Components/StudentCard.razor` — component parameters and `EventCallback<int>`.
- `Pages/Students.razor` — `@onclick`-driven add action, `@onkeydown`, `@oninput`, and `ViewDetails`.
- `Components/StudentCard.razor.css` — scoped card styling and hover effect.
- `Layout/MainLayout.razor` — custom navigation and layout.
- `Pages/StudentDetails.razor` — route parameter.

## 3. Application Screenshots
Insert your own screenshots after running the project:
1. Running application with custom layout and navigation.
2. Loading state before the student list appears.
3. StudentCard rendering with visible CSS-isolation hover effect.
4. Adding a student dynamically without page reload.
5. Student details page after clicking View details.

## 4. Explanation of Concepts
**[Parameter]:** The `[Parameter]` attribute allows a parent component to pass values to a child component. In this project, `StudentCard` receives the student's ID, name, course, and year level from `Students.razor`.

**@onclick:** The `@onclick` directive connects a click action in the interface to a C# method. In this project, clicking Add student calls `AddStudent`, which adds a new student to the list without reloading the page.

## 5. Problems Encountered and Solutions
One issue can occur when a child component uses `EventCallback<int>` but the parent passes a zero-argument lambda. The callback types must match. This project uses the direct method reference `OnDetailsClick="ViewDetails"`, where `ViewDetails(int id)` receives the student's ID. The first-name input also uses `@oninput` to capitalize the updated text because `@onkeydown` fires before the new character is entered.

## 6. Git Commit History
Paste the output of:

```bash
git log --oneline
```

## 7. Honor Code
I certify that this submission represents my own work. I understand the code and can explain the components, parameters, routing, event handling, and CSS isolation used in this project.

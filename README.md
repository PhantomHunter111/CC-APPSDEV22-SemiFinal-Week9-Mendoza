# StudentPortalUI — CC-APPSDEV22 Semi-Final Week 9

A complete Blazor WebAssembly student portal implementation based on the uploaded Week 9 laboratory guide. It demonstrates reusable components, `[Parameter]`, custom layout/navigation, routing, `NavigationManager`, event handling, a loading state, and CSS isolation.

## Requirements
- .NET 8 SDK
- Visual Studio Code
- C# Dev Kit extension (recommended)

## Run the project
Open a terminal in this folder and run:

```bash
dotnet restore
dotnet watch run
```

Open the localhost URL printed by the terminal.

## Features included
- Custom `MainLayout.razor` with Home, Students, and Counter navigation.
- Reusable `Components/StudentCard.razor` with `[Parameter]` properties and `EventCallback<int>`.
- `Pages/Students.razor` with sample students, loading indicator, form validation, and dynamic add action without a page reload.
- `@onclick` event handlers in the student card and counter page.
- `NavigationManager` programmatic navigation to `/student/{id}`.
- `Pages/StudentDetails.razor` with `@page "/student/{id:int}"` and `[Parameter] public int Id`.
- `@onkeydown` handling for the first-name input, with `@oninput` performing capitalization after the typed value changes.
- `StudentCard.razor.css` scoped component styles and hover effect.
- Responsive layout and clean UI styling.

## Important note about first-name capitalization
A keyboard `keydown` event occurs before the browser updates the input's text. For that reason, the page includes the required `@onkeydown` handler and uses `@oninput` to capitalize the actual updated value. This avoids unreliable character insertion behavior.

## Suggested screenshots for your PDF documentation
Run the application and capture these yourself:
1. Home page showing the custom sidebar/navigation.
2. Students page while the `Loading students...` indicator is visible (refresh the page and capture quickly).
3. Student cards, including a card while its hover effect is visible.
4. Add a new student and show the new card in the list without refreshing.
5. Click `View details` and show the `/student/{id}` page.
6. Counter page after clicking Increment.

## GitHub submission preparation
Initialize and commit the project:

```bash
git init
git add .
git commit -m "Complete Week 9 Blazor Student Portal"
git tag attempt-2
```

Create a GitHub repository named `CC-APPSDEV22-SemiFinal-Week9-Lastname`, then add its remote and push:

```bash
git remote add origin YOUR_GITHUB_REPOSITORY_URL
git branch -M main
git push -u origin main
git push origin attempt-2
```

Replace `Lastname` and the remote URL with your own details. Do not submit placeholder links. The Google Drive PDF and screenshots must be created/uploaded by you after running the application.

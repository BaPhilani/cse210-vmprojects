# Copilot / AI agent instructions — cse210-vmprojects

Purpose: help an AI coding agent become productive immediately in this repo.

Overview
- Root solution: `cse210-ww-student-template.sln` — contains many small console projects organized by week.
- Each subproject is a standalone .NET console app located under `weekNN/<ProjectName>/` or `sandbox/`.

Build & run (concrete examples)
- Build entire solution: `dotnet build cse210-ww-student-template.sln` from repository root.
- Build one project: `dotnet build week01/Exercise1/Exercise1.csproj`.
- Run one project: `dotnet run --project week01/Exercise1/Exercise1.csproj`.
- The repository already has VS Code tasks for many projects (see `.vscode/launch.json` and workspace tasks generated in the environment); use them when debugging in the editor.

Project structure & patterns
- Each project is a simple console app with an entrypoint in `Program.cs` and a corresponding `*.csproj`.
- There are no shared libraries — changes are normally confined to a single week/project.
- Build artifacts live under `bin/` and `obj/` inside each project folder — do not modify those files.

Conventions to follow
- Keep edits within a single project when possible (e.g., change `week03/Fractions/Program.cs` only when the exercise requires it).
- Use explicit project paths in build/run commands to avoid ambiguity across many small projects.
- Preserve the console-app style (interactive console I/O) — tests and harnesses are not present in the repo.

Debugging notes
- Use `dotnet run --project <path>` for quick manual verification.
- For step-through debugging, open the project folder in VS Code and launch via the existing `launch.json` configuration.
- VS Code launch configs: open the **Run & Debug** panel, select a configuration (for example `Week 01: C# Exercise 3`) and press **F5**. If VS Code indicates `launch.json` is invalid, validate it with PowerShell:

  ```powershell
  Get-Content .vscode/launch.json | ConvertFrom-Json
  ```

  Common causes: missing commas between objects or a trailing comma after the last object.

Integration & external dependencies
- Dependencies are NuGet-based and declared in each `*.csproj`. Check `obj/project.assets.json` for resolved package details when needed.
- There are no web services, databases, or external APIs referenced by the bulk of projects — treat projects as isolated console apps unless a specific `csproj` shows otherwise.

What an AI should do first (priority checklist)
- Open `cse210-ww-student-template.sln` to see project list.
- Locate the target project under `weekNN/<Name>/` and inspect `Program.cs` and its `*.csproj`.
- Run the project locally with `dotnet run --project <path>` to observe behavior before changes.

Examples of quick edits
- To change a behavior in Exercise1: edit `week01/Exercise1/Program.cs`, then run `dotnet run --project week01/Exercise1/Exercise1.csproj`.
- To add a helper class for an exercise, create a new `.cs` file under that project directory and add it to the project via the `*.csproj` if needed (IDE usually includes new files automatically).

Restrictions & guardrails
- Do not modify `bin/`, `obj/`, or generated NuGet commit artifacts.
- Avoid global refactors that touch multiple projects unless the change is required across all projects and you run a full solution build.

When in doubt
- Run `dotnet build` on the single project first. If multiple projects fail, build the solution with `dotnet build cse210-ww-student-template.sln`.
- If a change affects project structure, run the build and report exact compiler errors and file/line references.

Contact/next step
- After making edits, run the target project and paste the console output and any compiler diagnostics for follow-up.

— end —

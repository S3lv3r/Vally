# Vally | Interactive Desktop Math App

Vally is a native Windows desktop application built with C# and Windows Forms, originally designed as a practical, gamified tool to help my younger sister practice basic arithmetic. 

Rather than aiming to be a complex LMS (Learning Management System), Vally is a focused, local execution tool. It drops the user into rapid-fire exercise blocks with visual feedback, session timers, and a scoring system. From an engineering perspective, this project serves as a foundational exploration of WinForms event handling, UI state management, input validation, and basic local persistence.

## Core Flow & Features

* **Local State & Onboarding:** On first launch, `Program.cs` checks `UsernameDB.txt`. If empty, it routes to `FrmUser` to validate and register the player's name.
* **Dynamic Session Generation:** Four dedicated practice modes (Addition, Subtraction, Multiplication, Division). Each session dynamically generates 10 randomized exercises using the `MathOperation.cs` engine.
* **Real-time Validation Engine:** Immediate visual state changes (Correct/Incorrect/Review Procedure) upon submitting an answer.
* **Gamification Mechanics:** Tracks session time, provides contextual daily greetings, and features custom hover animations on UI elements.
* **Scoring Algorithm:** Scores are calculated per session using a base correct-answer multiplier plus a time-based bonus or penalty system.
* **Local High Scores:** The application reads and writes top scores per category into a flat `ScoreDB.txt` file.

## Tech Stack & Architecture

* **Language:** C#
* **UI Framework:** .NET Framework 4.7.2 (WinForms)
* **Rendering:** Native WinForms controls (`PictureBox`, `Label`, `TextBox`), `.resx` resources, and runtime loading of custom typography (Fredoka).
* **Persistence:** Local flat `.txt` files (No external databases, ORMs, or NuGet dependencies).
* **Distribution:** Configured for ClickOnce deployment.

### Key Modules
* `MathOperation.cs`: The core logic engine handling the generation and mathematical verification of the exercises.
* `ScoreControl.cs`: File I/O handler for reading/writing highest achievements.
* `MainMenu.cs` & `Frm[Operation].cs`: The presentation layer handling user input and timer loops.

## Known Limitations & Technical Debt

This project represents an early, functional prototype. As a snapshot of my learning curve, it contains technical debt that I am fully aware of and serves as a baseline for my architectural growth:

* **Mixed Responsibilities:** Business logic (scoring, validation) is tightly coupled with the UI layer (Forms) instead of being isolated in a Domain layer.
* **Fragile Persistence:** Relying on `.txt` files without robust error handling makes the app susceptible to I/O exceptions if files are missing or lack write permissions.
* **Code Duplication:** The timer and validation loops are largely duplicated across the four operation forms instead of inheriting from a unified base class.
* **Repository Hygiene:** The repository currently tracks compilation artifacts (`bin/`, `obj/`) and has historical naming inconsistencies due to a lack of an initial `.gitignore`.
* **Testing:** Lack of automated unit testing for the `MathOperation` generation and validation logic.

## How to Run

**Requirements:** Windows OS, Visual Studio (with .NET Desktop Development workload), .NET Framework 4.7.2.

1. Clone the repository.
2. Open `Jungle Math.csproj` in Visual Studio.
3. Build the solution in `Debug` or `Release` mode.
4. Run directly from Visual Studio or execute via MSBuild.

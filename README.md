# Yard Management System (YMS) — VTI Reconciliation Prototype
 
A Blazor Server prototype demonstrating a proposed VTI (Virtual To Inventory) reconciliation feature for warehouse yard management systems.
 
## The Problem
 
In most yard management systems, trailers have a **virtual location** — where the system thinks the trailer is. But physical reality doesn't always match. Trailers get moved without being scanned, dropped in the wrong slip, or show up in a spot the system says is empty.
 
Many TCs (Terminal Computers) already have a button that asks the driver *"Is a trailer already there?"* — but it doesn't actually do anything. This project demonstrates what that button **should** do.
 
## The Solution
 
This prototype adds a full driver-facing reconciliation flow on the TC page:
 
1. A dispatcher queues a move on the YMS page (from slip → to slip)
2. The driver accepts the move on their TC
3. The driver picks up the trailer and confirms VTI
4. At the drop-off slip, the driver either:
   - **Completes the move** — slip is physically empty, system updates
   - **Hits "Trailer Already There"** — types the trailer number physically occupying the slip
     - If that trailer exists elsewhere in the system → it's virtually relocated to reflect reality
     - If it's unknown → it's automatically checked in to that slip
     - The driver then selects a new destination and the flow repeats until the move is complete
## Features
 
- **YMS Page** — Full yard grid showing DD and PS dock slips with trailer info, check-in/check-out, and move queue
- **TC Page** — Simulated terminal computer interface with step-by-step driver move flow
- **VTI Reconciliation** — Resolves virtual vs physical location conflicts in real time
- **Live filtering** — Trailer search narrows as the driver types on the conflict screen
- **Persistent storage** — All slip state and move history saved to SQLite via EF Core
## Tech Stack
 
- [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/) (.NET 8)
- Entity Framework Core with SQLite
- CSS Grid layout with scoped component styles
## Running Locally
 
### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
### Steps
 
```bash
git clone https://github.com/Stephenhall03/yard-management-simulator-v2.git
cd yard-management-simulator-v2
dotnet run
```
 
Then open your browser to `https://localhost:5001`.
 
The database is created automatically on first run — no migration step needed.
 
## Pages
 
| Route | Description |
|-------|-------------|
| `/` | YMS — full yard grid, check-in/out, move queue |
| `/tc` | TC — driver terminal, move acceptance and VTI flow |
 
 
## Notes
 
This is a prototype built to demonstrate the feature concept, not a production system. The SQLite database resets if the `.db` file is deleted, which can be useful for demo purposes.
 

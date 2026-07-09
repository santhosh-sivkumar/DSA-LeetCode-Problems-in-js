OOP and SOLID Principles

Overview

- This folder contains OOP and SOLID notes and example projects, now consolidated to avoid duplicates and nested repos.

Structure

- OOP/
  - Topic folders (e.g., Abstraction, Encapsulation, Composition, Inheritance, Polymorphism).
  - Each topic contains example projects and source files.
  - `Examples` or `Extras` may contain files that didn't map cleanly to a single topic.

- SOLID/
  - Principles/
    - 1. Single Responsibility Principle/
      - Bad/Good (examples)
    - 2. Open-Closed Principle/
      - Bad/Good (examples)
    - 3. Liskov Substitution Principle/
      - Bad/Good (examples)
    - 4. Interface Segregation Principle/
      - Bad/Good (examples)
    - 5. Dependency Inversion Principle/
      - Bad/Good (examples)
  - `Examples` (misc files moved here for review)
  - `Principles/Extras` (files that need review or mapping)

Notes about duplicates

- Some filenames appear in multiple example folders intentionally (different variations or 'bad' vs 'good' implementations). Where a filename was duplicated at the folder root it has been moved into `SOLID/Principles/Extras` or the appropriate principle folder to reduce confusion.
- If you want aggressive deduplication (keep one copy and delete others), tell me your preference (keep 'Good' versions, keep latest, or move duplicates to a `duplicates/` folder for manual review).

Next actions (choose one)

- I can commit the workspace changes now.
- I can move remaining extras into more specific principle folders based on naming heuristics.
- I can create a `duplicates/` folder and move all files that have exact-name duplicates there for manual inspection.

If you want a commit, I will run `git add` and `git commit` with a clear message.

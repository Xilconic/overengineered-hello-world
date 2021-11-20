# Hello world - SOLID Principles
One of the common set of Object Oriented Design principles are called SOLID. It's an acronym for:
1. Single Responsibility Principle
2. Open/Close Principle
3. Liskov Substitution Principle
4. Interface Segregation Principle
5. Dependency Inversion Principle

## Architectural Design Decisions

### 0001 - Separate out responsibilities out of Main function
#### Status
Implemented
#### Context
The `Main` function is implemented in a way that exposes it to too many reasons it needs to change.
This makes the `Main` function a highly volatile class. We identify the following reasons the `Main` function needs to change:
1. Client would like to have a different text.
2. Client would like the text to be formatted differently.
3. Client would like the output channel to be different.

The `Main` function should be implemented in a way that it aggregates these different responsibilities in 1 place,
and that should be it's only responsibility.
#### Decision
Extract methods for each responsibility.
#### Consequences
Each function in the program now has 1 reason, and only 1 reason, to change.
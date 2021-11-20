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

### 0002 - Move formatting responsibilities out of GetText function
#### Status
Implemented
#### Context
The `GetText` function is implemented in a way that contains both the raw text to be displayed as well as some formatting business rules.
The formatting business rules should be moved out of `GetText` and into `FormatText`.
#### Decision
Implicit formatting business rules should be extracted from the hard-coded text in `GetText`, and moved into `FormatText`.
#### Consequences
`GetText` implementation is now purely about determining the text that needs to be displayed.

### 0003 - Extract methods for responsibilities in FormatText
#### Status
Implemented
#### Context
The `FormatText` function has code responsible for different behaviors.
#### Decision
Extract methods for each separate behavior in `FormatText` such that `FormatText` only has the responsibility of aggregating the individual operations.
Each operation should be it's own method.
#### Consequences
`FormatText` implementation has it's behaviors better separated out.

### 0004 - Define class for dealing with sentences
#### Status
Implemented
#### Context
`Program.GetWordsFromText` and `Program.CombineWordsIntoSentence` both contain the magic value of `" "`.
It's clear that these are intentionally coupled because of the concept they share.
#### Decision
Extract class for dealing with sentences.
#### Consequences
This encapsulated the dependency on the business logic into a new class, splitting that off from `Program`.

### 0005 - Define class for formatting the text
#### Status
Implemented
#### Context
`Program` contains a lot of methods related to formatting. 
Also the dependency on `TextTokenizer` only is needed within the context for formatting, while irrelevant for determining which text to visualize or how to visualize it.
#### Decision
Extract class for formatting text.
#### Consequences
This will help localize the scope of certain objects to when they are relevant (and when no longer).
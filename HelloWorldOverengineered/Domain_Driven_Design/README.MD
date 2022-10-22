# Hello world - Domain Driven Design
The practice of Domain Driven Design is an industry wide well accepted practice to use in software engineering.
It focusses at putting the problem domain first, identifying and establishing the language used within the problem domain (referred to as the ubiquitous language).
Typically multiple problem domains are interacting with each other in order to add value to a business.
These might have their own language, where a Bounded Context can be identified where a ubiquitous language applies for a certain set of problems.

## Architectural Design Decisions

### 0001 - Define Bounded Contexts as separate projects
#### Status
Implemented
#### Context
A 'Hello World' program consists out of 2 problem domains:
1. Linguistics
2. Display
#### Decision
Separate out the relevant Bounded Contexts for the application.
#### Consequences
Start of more clear deliniation of problem domains and their separate responsibilities and ubiquitous languages.

### 0002 - Introduce 'Sentence' concept
#### Status
Implemented
#### Context
In linguistics, we talk about sentences instead of 'string'.
#### Decision
Refactor code by introducing classes that map to the ubiquitous language of Linguistics.
#### Consequences
Less confusion when talking about the code with linguistic experts.
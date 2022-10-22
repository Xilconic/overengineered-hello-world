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

### 0003 - Introduce Anti Corruption Layer towards Linguistics Bounded Context
#### Status
Implemented
#### Context
People who start implementing their very first Hello World application probably are used to only seeing a couple of lines of code in order to make the application write the text 'Hello World!' to console output.
They may not be used to the ubiquitous language of the Linguistics world and probably get confused by it.
Especially if they never need to deal with those details themselves.
#### Decision
Introduce an Anti Corruption Layer towards the Linguistics Bounded Context.
#### Consequences
People familiar to Hello World applications can inspect the Program.cs and find it doesn't look very suprising to them.
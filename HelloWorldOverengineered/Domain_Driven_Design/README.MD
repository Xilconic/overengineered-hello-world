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

### 0004 - Introduce Anti Corruption Layer towards Display Bounded Context
#### Status
Implemented
#### Context
People who start implementing their very first Hello World application probably are used to only seeing a couple of lines of code in order to make the application write the text 'Hello World!' to console output.
They may not be used to the ubiquitous language of the Display world and probably get confused by it.
Especially if they never need to deal with those details themselves.
#### Decision
Introduce an Anti Corruption Layer towards the Display Bounded Context.
#### Consequences
People familiar to Hello World applications can inspect the Program.cs and find it doesn't look very suprising to them.

### 0005 - Introduce 'minor sentence' and 'major sentence' concepts
#### Status
Implemented
#### Context
In English linguistics, a sentence is either a 'major sentence' or a 'minor sentence'. A major sentence is defined as consisting out of at least 1 clause, while a minor sentence does not.
#### Decision
Use polymorphism to capture these 2 categorial behavioral rules for sentenes. To keep the scope small for now, only support constructing major sentences out of a single clause.
#### Consequences
Less confusion when talking about the code with linguistic experts.

### 0006 - Allow for sentence expression types
#### Status
Implemented
#### Context
In English linguistics, a sentence can have various 'expression types': statement, exclamation, command, question, request or suggestion.
#### Decision
Implement these linguistic restrictions into the construction logic of minor sentences.
#### Consequences
Less risk on invalid MinorSentence instances.

### 0007 - Implement domain restrictions for greetings-based minor sentences
#### Status
Implemented
#### Context
In English linguistics, greetings are a form of minor sentences and have particular restrictions applied to them.
#### Decision
Implement these linguistic restrictions into the construction logic of minor sentences.
#### Consequences
Less risk on invalid MinorSentence instances.
# Hello world - LINQ to the max!
One of the 'killer apps' within C# is LINQ. And surely a 'hello world' program would be better if LINQ was used to it's maximal potential!

## Architectural Design Decisions

### 0001 - Strings can be iterated over
#### Status
Implemented
#### Context
The `string` type in C# is basically a collection of characters.
#### Decision
Loop over all characters in the text when displaying.
#### Consequences
Start to unleash the true power of LINQ.

### 0002 - Define method that returns all relevant characters to be printed
#### Status
Implemented
#### Context
The application was using a hardcoded 'Console.WriteLine()'.
#### Decision
As we're already looping over all characters of a piece of text, we should refactor to also capture the intended new-line in the text.
#### Consequences
Start to unleash the true power of LINQ.

### 0003 - Remove string concatenation
#### Status
Implemented
#### Context
We were postfixing the `Environment.NewLine` text using string concatenation.
#### Decision
Remove string concatenation by refactoring the method using yield return statement, eliminating the need to do string concatenation.
#### Consequences
Eliminate needless string manipulation.
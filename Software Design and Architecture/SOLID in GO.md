# SOLID in GO

## Single Responsibility Principle:
- Functions, structs and methods should serve a _single purpose_.
- Packages should also serve a single purpose and this should be well indicated by their names.

## Open/Closed Principal:
- Open for extension: By embedding simple types to compose more complex types
- Open for extension: By using decorators to extend responsibilities of functions.

## Liskov Substitution Principle:
LSP can be achieved by doing the following:
1. Interfaces with single methods. 
2. Interface method signature is _liberal in what it receives and conservative in what it sends_.
    - Rule of thumb for this: _Accept interfaces, return structs._

Adhering to above guidelines results in implementing types being substitutable.

## Interface Segregation Principle: 
Principle says _Client should not be forced to depend on methods they do not use_. This adds further clarification to LSP guidelines. 

`func Save(f *os.File, doc *Document) error` -> `func Save(rwc io.ReadWriteCloser, doc *Document) error` -> `func Save(wc io.WriteCloser, doc *Document) error`. First being the worst, last the best.

The best example, does not accept concrete type. It also accepts only the interface it truly needs.

We can update our understanding of _liberal in what methods/functions receive_ to mean:
1. Accept interfaces.
2. Accept interface at the right level. Not concretes type and not the most generic interface. But the interface the method truly requires.

## Dependency Inversion Principle:
- High level module take responsibility of specific types, low level modules define abstractions. 
- Think of it as dependencies being passed from higher/outer level to lower/ inner levels.
- The above are true for types as well as package imports.



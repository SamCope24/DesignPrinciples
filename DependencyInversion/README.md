## Dependency Inversion Principle

- High level modules should not depend on low level modules
- Instead, both should depend on abstractions
- Those abstractions should not depend on details
- A high level module is anything that is calling something else
- Dependency Injection is one way of implementing the Dependency Inversion principle (But not the only way!)
- DI allows us to easily swap out areas of our application
- Whenever you see the 'new' keyword, that is an indication of tight coupling
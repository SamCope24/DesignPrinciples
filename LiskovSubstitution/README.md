## Liskov Substitution Principle

- if S is a subtype of T then object of T may be replaced with object of type S without breaking the program
- covariance is the return type of a method, if you have a return type, that type can't change
- contravariance is about the input type of a method, if you have an input type, that type can't change
- better to gravitate towards interfaces, rather than inheritance
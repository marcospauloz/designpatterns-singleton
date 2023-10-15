# Creational Pattern: Abstract Factory Method

## Introduction
The intent of the abstract factory pattern is to provide an interface for creating families of related or dependent objects without specifying their concrete classes

## Use cases for the Abstract Factory
- When a system should be independent of how its products are created, composed and represented
- When you want to provide a class library of things and you only want to reveal their interfaces, not their implementations
- When a system should be configured with one of multiple families of things
- When a family of related things objects is designed to be used together and you want to enforce this constraint

## Pattern Consequences
_ It isolates concrete classes, because it encapsulates the responsability and the process of creating objects
- New objects can easily be introduced without braking client code: open/closed principle
- Code to create object it contained in one place: single responsibility principle
- It makes exchanging objects families easy
- It promotes consistency among objects
- Supporting new kinds of products is rather difficult

## Related Patterns
- Factory method: Abstract factory can be implemented using factory methods
- Prodotype: Abstract factory can be implemented using prototypes
- Singleton: A concrete factory is often implemented as a singleton
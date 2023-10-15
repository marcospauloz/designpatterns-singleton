# Creational Pattern: Builder Method

## Introduction
The intent of the builder pattern is to separate the construction of a complex object from its representation.
By doing so, the same construction process can create different representations.

## Use cases for the Builder Method
Builder specifies an abstract interface for creating parts of a Car object

Concrete builder constructs and assemble parts of the Car by implementing the Builder interface.
It keeps track of the representation it creates, and provides an interface for retrieving the Car.

When you want to make the algorithm for creating a complex object independent of the parts that
make up the object and how they're assembled.

Whe you want to construction process to allow different representation for the object that's constructed

## Pattern Consequences
It lets us vary a Car internal representation

It isolates code for construction and representation;
it thus improves modularity by encapsulating the way a complex object is constructed and represented: Single Responsibility Principle

It give us finer control over the construction process

Complexity of you code base increases

## Related Patterns
Abstract factory: Both can be used to construct complex objects, but the builder constructs the complex objects step by step

Singleton: A builder can be implemented as a singleton

Composite: Composites are often built by builders
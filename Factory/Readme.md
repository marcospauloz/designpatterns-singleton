# Creational Pattern: Factory Method

## Use Case for the Factory Method

* When a class can't anticipate the class of objects it must create
* When a class wants its subclasses to specify the objects it creates
* When classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate
* As a way to enable reusing of existing objects

## Pattern consequences
* Factory methods eliminate the need to bind application-specific classes to your code
* New types of a object can be added without breaking client code: <b>Open/Closed principle</b>
* Creating objects is moved to one specific place in your code, the creator: <b>Single responsibility principle</b>
* Clients might need to create subclasses of the creator class just to create a particular concret object

## Related Patterns
* Abstract Factory: Often implemented with factory methods
* Prototype: No subclassing is needed (not based on inheritance), but an initialize action on object is often required
* Template: Factory methods are often called from within template methods
# Principles used:

## 1. The principle of "DRY" (Don't Repeat Yourself):
Code should avoid repetition by encapsulating logic in functions, classes, or other structures. The class [Product](./ClassLibrary/Product.cs#L40-L49) and [Warehouse](./ClassLibrary/Warehouse.cs#L36-L48) used the SetItemDetails constructor and method to avoid repeating code when initializing objects.

## 2. The "KISS" principle (Keep It Simple, Stupid):
The code should be simple and easy to understand. For example, the [DisplayItemDetails](./ClassLibrary/Warehouse.cs#L18-L23) and [UpdateQuantity](./ClassLibrary/Warehouse.cs#L25-L34) methods in the Warehouse class are implemented simply and clearly without unnecessary complications.

## 3. "SOLID" principles (Single Responsibility Principle):
* ### Single Responsibility Principle:
Classes [Money](./ClassLibrary/Money.cs#L3), [Product](./ClassLibrary/Product.cs#L3), [Warehouse](./ClassLibrary/Warehouse.cs#L3), and [Reporting](./ClassLibrary/Reporting.cs#L3) perform only one responsibility.
* ### Open/Closed Principle:
It is possible to expand the functionality without changing the existing code, for example, adding new types of goods or methods to the class [Reporting](./ClassLibrary/Reporting.cs#L3).

## 4. The principle of "YAGNI" (You Ain't Gonna Need It):
The code should include only the functionality that is actually needed, not that which may be needed in the future. The [Reporting](./ClassLibrary/Reporting.cs#L3) class code does not include unnecessary functionality.

## 5. Composition Over Inheritance:
The class [Warehouse](./ClassLibrary/Warehouse.cs#L7) instantiates the class [Money](./ClassLibrary/Money.cs#L3) to get functionality instead of inheritance.

## 6. Fail Fast:
Using exception handling in methods [SetMoneyParts](./ClassLibrary/Money.cs#L28-L37), [SetProduct](./ClassLibrary/Product.cs#L40-L49), [UpdateQuantity](./ClassLibrary/Warehouse.cs#L25-L34), and others for quick error detection.

Each of these principles helps to create more understandable, maintainable and scalable code, improving its quality and maintainability.

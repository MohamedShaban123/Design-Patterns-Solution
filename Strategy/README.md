# Strategy Design Pattern

## Overview

The **Strategy Design Pattern** is a behavioral design pattern that enables selecting an algorithm's behavior at runtime. Instead of implementing a single algorithm directly, the code receives runtime instructions as to which algorithm to use from a family of algorithms.

## Problem Statement

In the "Before" implementation, the `PaymentService` class contains conditional logic (if-else statements) to determine which payment method to use. This approach has several drawbacks:

- **Violates Open/Closed Principle**: Adding a new payment method requires modifying the `PaymentService` class
- **Poor Maintainability**: The class becomes harder to maintain as more payment methods are added
- **Tight Coupling**: The service is tightly coupled to concrete payment implementations
- **Difficult Testing**: Hard to test individual payment strategies in isolation

## Solution

The Strategy Pattern solves these problems by:

1. Defining a family of algorithms (payment methods)
2. Encapsulating each algorithm in separate classes
3. Making them interchangeable through a common interface
4. Allowing the algorithm to vary independently from clients that use it

---

## Code Comparison

### Before (Without Strategy Pattern)

**Problems:**
- String-based type checking (error-prone)
- If-else chain grows with each new payment method
- PaymentService must know about all payment types
- Creating new instances inside the method
- Violates Open/Closed Principle

---

### After (With Strategy Pattern)

**Benefits:**
- Type-safe (no string comparisons)
- Easy to add new payment methods (just implement IPayment interface)
- PaymentService doesn't need to change when adding new strategies
- Follows Dependency Inversion Principle
- Better testability with dependency injection
- Follows Open/Closed Principle

---

## Pattern Components

### 1. Strategy Interface (`IPayment`)
Defines the common interface for all supported algorithms. All concrete strategies must implement this interface.

### 2. Concrete Strategies (`CreditCard`, `Paypall`)
Implement the strategy interface with specific algorithm implementations. Each class encapsulates a different payment method.

### 3. Context (`PaymentService`)
Maintains a reference to a strategy object and delegates the algorithm execution to the strategy. The context is independent of concrete strategies.

---

## UML Diagram

```
┌─────────────────┐
│ PaymentService  │
│   (Context)     │
├─────────────────┤
│ - payment       │
├─────────────────┤
│ + pay()         │
└────────┬────────┘
         │ uses
         │
         ▼
    ┌─────────┐
    │IPayment │◄─────────────┐
    │(Strategy)│              │
    ├─────────┤              │
    │+ pay()  │              │
    └────▲────┘              │
         │                   │
         │ implements        │ implements
    ┌────┴────────┐     ┌────┴──────┐
    │ CreditCard  │     │  Paypall  │
    ├─────────────┤     ├───────────┤
    │+ pay()      │     │+ pay()    │
    └─────────────┘     └───────────┘
```

---

## When to Use Strategy Pattern

✅ **Use Strategy Pattern when:**
- You have multiple algorithms for a specific task and want to switch between them at runtime
- You want to isolate the implementation details of an algorithm from the code that uses it
- You have conditional statements that select different variants of the same algorithm
- You want to avoid exposing complex, algorithm-specific data structures

❌ **Don't use Strategy Pattern when:**
- You only have a couple of algorithms that rarely change
- The algorithms are simple and don't justify the additional complexity
- Clients need to know the differences between strategies to select the appropriate one

---

## Advantages

1. **Open/Closed Principle**: Open for extension (add new strategies), closed for modification (no changes to existing code)
2. **Single Responsibility Principle**: Each strategy class has one reason to change
3. **Runtime Flexibility**: Switch algorithms dynamically at runtime
4. **Eliminates Conditional Statements**: Replaces complex if-else or switch statements
5. **Better Testability**: Each strategy can be tested independently
6. **Code Reusability**: Strategies can be reused across different contexts

---

## Disadvantages

1. **Increased Number of Classes**: More classes to maintain
2. **Client Awareness**: Clients must understand different strategies to choose appropriately
3. **Communication Overhead**: Additional indirection between context and strategy

---

## Real-World Examples

- **Compression Algorithms**: ZIP, RAR, 7Z
- **Sorting Algorithms**: QuickSort, MergeSort, BubbleSort
- **Payment Methods**: Credit Card, PayPal, Bitcoin, Bank Transfer
- **Shipping Methods**: Ground, Air, Express
- **Authentication Strategies**: OAuth, JWT, Basic Auth
- **Validation Rules**: Email validation, phone validation, password validation

---

## Adding a New Payment Method

With the Strategy Pattern, adding a new payment method is straightforward - simply create a new class that implements the IPayment interface.

**No changes needed to:**
- IPayment interface
- PaymentService class
- Existing strategy implementations

---

## Best Practices

1. **Use Dependency Injection**: Inject strategies through constructor or setter methods
2. **Immutable Strategies**: Make strategy objects immutable when possible
3. **Strategy Factory**: Use a factory pattern to create strategies based on configuration
4. **Combine with Other Patterns**: Often used with Factory, Decorator, or Template Method patterns
5. **Naming Conventions**: Use clear, descriptive names for strategy classes

---

## Related Design Patterns

- **State Pattern**: Similar structure, but state pattern allows the object to change behavior when its internal state changes
- **Template Method Pattern**: Defines the skeleton of an algorithm, with subclasses providing specific steps
- **Factory Pattern**: Often used together to create strategy objects
- **Decorator Pattern**: Can be used to add responsibilities to strategies dynamically

---

## Conclusion

The Strategy Design Pattern is a powerful tool for writing flexible, maintainable code. By encapsulating algorithms in separate classes and using a common interface, you can easily extend your application with new behaviors without modifying existing code. This promotes better code organization, testability, and adherence to SOLID principles.
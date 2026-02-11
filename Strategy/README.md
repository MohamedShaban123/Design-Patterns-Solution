# Strategy Design Pattern

<<<<<<< HEAD
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
=======
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Design Pattern](https://img.shields.io/badge/Design_Pattern-Behavioral-blue?style=for-the-badge)](https://en.wikipedia.org/wiki/Design_pattern)

## 📋 Table of Contents
- [Definition](#-definition)
- [Key Components](#-key-components)
- [UML Diagram](#-uml-diagram)
- [Advantages](#-advantages)
- [Disadvantages](#-disadvantages)
- [When to Use](#-when-to-use)
- [When NOT to Use](#-when-not-to-use)
- [Real-World Use Cases](#-real-world-use-cases)
- [Code Example](#-code-example)
- [Usage](#-usage)
- [Output](#-output)
- [Comparison with Other Patterns](#-comparison-with-other-patterns)
- [Best Practices](#-best-practices)
- [Contributing](#-contributing)
- [License](#-license)

## 📖 Definition

The **Strategy Design Pattern** is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

> **In simpler terms:** It allows you to select an algorithm's behavior at runtime without using conditional statements.

## 🧩 Key Components

1. **Strategy Interface** (`IPaymentStrategy`) - Defines a common interface for all supported algorithms
2. **Concrete Strategies** (`CreditCardPayment`, `PayPalPayment`, `CashPayment`) - Implement different variations of the algorithm
3. **Context** (`ShoppingCart`) - Maintains a reference to a Strategy object and delegates algorithm execution to it

## 📐 UML Diagram

```
┌─────────────────────┐
│      Context        │
│   (ShoppingCart)    │
├─────────────────────┤
│ - strategy          │──────────► IPaymentStrategy
├─────────────────────┤                   ▲
│ + SetPaymentStrategy()│                  │
│ + Checkout()        │                    │
└─────────────────────┘                    │
                                           │
                    ┌──────────────────────┼──────────────────────┐
                    │                      │                      │
            ┌───────────────┐    ┌─────────────────┐    ┌────────────────┐
            │CreditCard     │    │PayPal           │    │Cash            │
            │Payment        │    │Payment          │    │Payment         │
            ├───────────────┤    ├─────────────────┤    ├────────────────┤
            │+ Pay()        │    │+ Pay()          │    │+ Pay()         │
            └───────────────┘    └─────────────────┘    └────────────────┘
```

## ✅ Advantages

| Advantage | Description |
|-----------|-------------|
| **Open/Closed Principle** | You can introduce new strategies without changing the context |
| **Eliminates Conditionals** | Replaces complex if-else or switch statements |
| **Runtime Flexibility** | Algorithms can be switched at runtime |
| **Encapsulation** | Each algorithm is isolated in its own class |
| **Testability** | Each strategy can be tested independently |
| **Code Reusability** | Strategies can be reused across different contexts |

## ❌ Disadvantages

| Disadvantage | Description |
|--------------|-------------|
| **Increased Classes** | Each strategy requires a separate class |
| **Client Awareness** | Clients must be aware of different strategies to select the appropriate one |
| **Communication Overhead** | Context and Strategy must share data, which can be inefficient |
| **Overkill for Simple Cases** | If you have only a few algorithms that rarely change, the pattern may be unnecessary |

## 🎯 When to Use

- ✔️ When you have multiple related classes that differ only in their behavior
- ✔️ When you need different variants of an algorithm
- ✔️ When you want to avoid exposing complex, algorithm-specific data structures
- ✔️ When a class has massive conditional statements that switch between different variants of the same algorithm

## 🚫 When NOT to Use

- ❌ When you have only one or two algorithms that rarely change
- ❌ When algorithms don't share a common interface
- ❌ When the cost of communication between Strategy and Context is too high

## 🌍 Real-World Use Cases

- 💳 **Payment Processing** - Credit card, PayPal, cryptocurrency, bank transfer
- 🔢 **Sorting Algorithms** - QuickSort, MergeSort, BubbleSort
- 📦 **Compression** - ZIP, RAR, 7Z formats
- 🗺️ **Route Planning** - Fastest route, shortest route, scenic route
- 🔐 **Authentication** - OAuth, JWT, Basic Auth, API Key
- 🚚 **Shipping Calculators** - Standard, express, overnight shipping

## 💡 Practical Example: Payment Processing System

### Scenario
Imagine you're building an e-commerce platform where customers can pay using different payment methods. Instead of writing complex if-else statements for each payment type, you use the Strategy Pattern.

### Components Breakdown

#### 1️⃣ **Strategy Interface** (IPaymentStrategy)
- Defines a contract that all payment methods must follow
- Contains a `Pay()` method that accepts an amount

#### 2️⃣ **Concrete Strategies** (Payment Methods)

**CreditCardPayment**
- Implements the payment interface
- Handles credit card payment processing
- Displays: "Paid {amount} using Credit Card"

**PayPalPayment**
- Implements the payment interface
- Handles PayPal payment processing
- Displays: "Paid {amount} using PayPal"

**CashPayment**
- Implements the payment interface
- Handles cash payment processing
- Displays: "Paid {amount} using Cash"

#### 3️⃣ **Context Class** (ShoppingCart)
- Maintains a reference to the current payment strategy
- Provides a method to set/change the payment strategy
- Executes the checkout process using the selected strategy

### How It Works

1. **Customer selects items** → Shopping cart is created
2. **Customer chooses payment method** → Appropriate strategy is set
3. **Customer clicks checkout** → Context executes the selected strategy
4. **Payment is processed** → Strategy-specific logic is executed

### Flow Example

```
Customer Total: $250.00

Scenario 1: Pay with Credit Card
→ ShoppingCart.SetPaymentStrategy(CreditCardPayment)
→ ShoppingCart.Checkout($250.00)
→ Result: "Paid 250.00 using Credit Card."

Scenario 2: Pay with PayPal
→ ShoppingCart.SetPaymentStrategy(PayPalPayment)
→ ShoppingCart.Checkout($250.00)
→ Result: "Paid 250.00 using PayPal."

Scenario 3: Pay with Cash
→ ShoppingCart.SetPaymentStrategy(CashPayment)
→ ShoppingCart.Checkout($250.00)
→ Result: "Paid 250.

## 🔄 Comparison with Other Patterns

| Pattern | Purpose | Key Difference |
|---------|---------|----------------|
| **Strategy** | Select algorithm at runtime | Focuses on interchangeable algorithms |
| **State** | Change behavior based on state | Object's behavior changes with internal state |
| **Command** | Encapsulate a request | Focuses on action/request rather than algorithm |
| **Template Method** | Define algorithm skeleton | Uses inheritance, not composition |

## 💡 Best Practices

### 1. **Use Dependency Injection**
Pass strategies through constructor or setter methods instead of creating them directly inside the context. This makes your code more flexible and testable.

### 2. **Keep Strategies Stateless**
Strategies should ideally not maintain state. If they need data, pass it through method parameters. This prevents unexpected behavior when strategies are reused.

### 3. **Consider Factory Pattern**
Use a factory to create appropriate strategies based on user input or configuration. This centralizes the strategy creation logic and makes it easier to manage.

**Example:** A PaymentStrategyFactory that creates the right payment strategy based on the user's selection (credit card, PayPal, cash, etc.)

### 4. **Document Strategy Selection**
Clearly document when and why to use each strategy. This helps other developers (and future you) understand the purpose of each strategy.

### 5. **Provide Defaults**
Consider having a default strategy if appropriate for your use case. This prevents null reference errors and provides fallback behavior.

### 6. **Validate Strategy Before Use**
Always check if a strategy has been set before trying to use it. Provide clear error messages if no strategy is configured.

### 7. **Single Responsibility**
Each strategy should do one thing well. Don't try to handle multiple unrelated behaviors in a single strategy class.

## 📊 Pattern Information

| Property | Value |
|----------|-------|
| **Pattern Type** | Behavioral |
| **Complexity** | ⭐⭐☆☆☆ (Medium) |
| **Popularity** | ⭐⭐⭐⭐⭐ (Very High) |
| **Use Frequency** | Common in enterprise applications |

## 📝 Summary

The Strategy Pattern is ideal when you need to dynamically select from a family of algorithms. It promotes clean, maintainable code by encapsulating algorithms and eliminating conditional logic. While it does increase the number of classes, the benefits of flexibility and maintainability usually outweigh this cost in complex systems.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

<div align="center">

**Made with ❤️ for better software design**

⭐ Star this repository if you found it helpful!

</div>
>>>>>>> e0afb4346430e7a6b5ed5099e33cdab4472f87f1

# Strategy Design Pattern

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
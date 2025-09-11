# Factory Method Design Pattern

## 📖 Definition
The Factory Method is a **creational design pattern** that provides an interface for creating objects in a superclass, but allows subclasses or factories to decide which class to instantiate. This makes the system more flexible and decouples the client from concrete implementations.

## 🎯 Intent
- Define an interface for creating objects, but let subclasses decide which object to create.  
- Encapsulate the object creation process.  
- Promote loose coupling between client code and concrete classes.  

## 🏗️ Structure
- **Product**: The common interface or abstract class that declares the operations all products must implement.  
- **Concrete Products**: Specific implementations of the product interface.  
- **Creator**: Declares the factory method which returns product objects.  
- **Concrete Creators**: Override the factory method to create and return a specific product.  
- **Client**: Uses the factory method to get objects, but only works with the product interface rather than concrete classes.  

## ✅ Benefits
- Removes tight coupling between client code and concrete implementations.  
- Follows the Open/Closed Principle (new products can be introduced without changing existing client code).  
- Centralizes and organizes object creation in one place.  

## ⚠️ Drawbacks
- Introduces more classes into the system, which can increase complexity.  
- Sometimes may be overkill for simple object creation.  

## 📌 Use Cases
- When the exact type of the object to create isn’t known until runtime.  
- When a class wants its subclasses to specify the objects it creates.  
- When you want to avoid coupling code to specific concrete classes.  

## 🔄 Real-World Examples
- Database connection drivers (different databases, same interface).  
- Payment systems (PayPal, Stripe, Bank Transfer – all implementing the same payment interface).  
- UI frameworks (creating buttons, checkboxes, or windows depending on the operating system).  

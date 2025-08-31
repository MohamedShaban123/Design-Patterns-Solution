# 🧩 Prototype Design Pattern

## 📖 Definition
The **Prototype Pattern** is a creational design pattern that allows you to create new objects by copying existing ones (called prototypes), instead of creating them from scratch.

---

## ✅ When to Use
- When object creation is expensive or time-consuming.
- When you want to avoid rebuilding complex objects repeatedly.
- When you need new objects with the same state as existing ones.
- When instances should be created dynamically at runtime.

---

## 🔑 Key Concepts
- **Prototype** → Declares the cloning method.
- **Concrete Prototype** → Implements the cloning method.
- **Client** → Creates new objects by copying a prototype.

---

## 🌍 Types of Copy
- **Shallow Copy** → Creates a new object but reuses references of nested objects.
- **Deep Copy** → Creates a completely independent object with new copies of nested objects.

---

## 🎯 Advantages
- Reduces the cost of creating objects.
- Avoids complex initialization code.
- Simplifies object creation logic.
- Provides flexibility by creating objects dynamically.

---

## ⚠️ Disadvantages
- Deep copy can be difficult to implement for complex objects.
- If the object has circular references, cloning becomes challenging.
- Maintaining the prototype hierarchy can increase complexity.

---


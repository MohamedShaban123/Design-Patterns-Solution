# 📌 Observer Design Pattern (Using Events in C#)

## 🔹 Overview
The **Observer Pattern** is a behavioral design pattern where an object (called the **Subject**) maintains a list of dependents (called **Observers**) and automatically notifies them of any state changes.

In C#, this pattern is commonly implemented using **events**, which provide a natural publish/subscribe mechanism.

---

## 🔹 Key Concepts
- **Subject (Publisher):** The object that declares and raises an event when something happens.  
- **Observer (Subscriber):** The object(s) that subscribe to the event and react when the Subject notifies them.  
- **Event:** The mechanism through which the Subject communicates changes to its Observers.  

---

## 🔹 How It Works
1. The **Subject** exposes an event.  
2. **Observers** subscribe to this event.  
3. When something important happens, the **Subject raises the event**.  
4. All **Observers automatically receive the notification** and react accordingly.  

---

## 🔹 Benefits
- Promotes **loose coupling** between Subject and Observers.  
- Supports **multiple subscribers** that can dynamically join or leave.  
- Built-in event system in C# makes it **safe, clean, and easy to implement**.  

---

## 🔹 Real-World Examples
- **UI Programming:** Button click events notify event handlers in applications.  
- **Notification Systems:** Multiple users can subscribe to get alerts when a new update occurs.  
- **Messaging Systems:** Publish/subscribe patterns in communication and event-driven applications.  

---

## 🔹 Diagram (Mermaid)
```mermaid
classDiagram
    class Subject {
        +event Occurred
        +Notify()
    }

    class Observer {
        +Update()
    }

    Subject --> Observer : notifies

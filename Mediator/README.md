# Mediator Design Pattern - Complete Guide

## Table of Contents
- [Overview](#overview)
- [Problem Statement](#problem-statement)
- [Solution](#solution)
- [Structure Diagram](#structure-diagram)
- [Complete Implementation](#complete-implementation)
- [How It Works](#how-it-works)
- [Advantages vs Disadvantages](#advantages-vs-disadvantages)
- [When to Use](#when-to-use)
- [Real-World Examples](#real-world-examples)
- [Comparison Table](#comparison-table)
- [Best Practices](#best-practices)

---

## Overview

**Mediator Pattern** is a behavioral design pattern that reduces coupling between components by making them communicate through a central mediator object instead of directly with each other.

**Key Concept:** Objects don't communicate directly; they communicate through a mediator.

**Definition:** Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly.

---

## Problem Statement

### Without Mediator Pattern

When components communicate directly with each other, they become tightly coupled:
```
┌──────────┐
│  Button  │────────────┐
└──────────┘            │
     │                  ▼
     │            ┌──────────┐
     │            │ TextBox  │
     │            └──────────┘
     │
     └──────────────────────┐
                            ▼
                      ┌──────────┐
                      │  Dialog  │
                      └──────────┘
```

**Problems:**
- ❌ **Tight Coupling:** Button depends directly on TextBox and Dialog
- ❌ **Hard to Maintain:** Changes in one component affect others
- ❌ **Hard to Test:** Cannot test components in isolation
- ❌ **Not Scalable:** Adding new components (Label, Logger) requires modifying existing ones (Button)
- ❌ **Violates Single Responsibility:** Button has too many responsibilities
- ❌ **Code Duplication:** Same interaction logic repeated across components

---

## Solution

### With Mediator Pattern

Components communicate through a central mediator:
```
┌──────────┐
│  Button  │─────┐
└──────────┘     │
                 │
┌──────────┐     │      ┌────────────────┐
│ TextBox  │─────┼─────►│    Mediator    │
└──────────┘     │      └────────────────┘
                 │
┌──────────┐     │
│  Dialog  │─────┘
└──────────┘
```

**Benefits:**
- ✅ **Loose Coupling:** Components don't know about each other
- ✅ **Easy to Maintain:** Changes are localized in mediator
- ✅ **Easy to Test:** Components can be tested independently
- ✅ **Scalable:** Add new components without changing existing ones
- ✅ **Follows Single Responsibility Principle:** Each component has one responsibility
- ✅ **Centralized Logic:** All interaction logic in one place

---

## Structure Diagram
```
┌─────────────────────────────────────────────────┐
│              <<interface>>                       │
│                IMediator                         │
│  + Notify(object source, string eventName)      │
└─────────────────────────────────────────────────┘
                      △
                      │ implements
                      │
┌─────────────────────────────────────────────────┐
│         Mediator (Concrete Mediator)            │
│  - _textBox: TextBox                            │
│  - _dialog: Dialog                              │
│  + Notify(object source, string eventName)      │
└─────────────────────────────────────────────────┘
          │                    │
          │ uses               │ uses
          ▼                    ▼
┌──────────────┐      ┌──────────────┐
│   TextBox    │      │    Dialog    │
│  + Clear()   │      │  + Show()    │
└──────────────┘      └──────────────┘
          △
          │ notifies
          │
┌──────────────────────┐
│       Button         │
│  - _mediator         │
│  + Click()           │
└──────────────────────┘
```

**Participants:**
1. **IMediator (Interface):** Defines communication interface
2. **Mediator (Concrete Mediator):** Implements coordination logic
3. **Components (Button, TextBox, Dialog):** Communicate through mediator

---

## Complete Implementation

### Before Mediator (Tightly Coupled)

#### ❌ Problem Code - Direct Dependencies

**Button.cs**
```csharp
namespace Mediator.Before
{
    // Button depends directly on TextBox and Dialog
    internal class Button
    {
        private readonly TextBox _textBox;
        private readonly Dialog _dialog;
        
        public Button(TextBox textBox, Dialog dialog)
        {
            this._textBox = textBox;
            this._dialog = dialog;
        }
        
        public void Click(string message)
        {
            // Button knows HOW to interact with other components
            _textBox.Clear();
            _dialog.Show(message);
        }
    }
}
```

**TextBox.cs**
```csharp
namespace Mediator.Before
{
    internal class TextBox
    {
        public void Clear()
        {
            Console.WriteLine("TextBox Cleared Successfully");
        }
    }
}
```

**Dialog.cs**
```csharp
namespace Mediator.Before
{
    internal class Dialog
    {
        public void Show(string message)
        {
            Console.WriteLine($"Dialog Message: {message}");
        }
    }
}
```

**Usage:**
```csharp
// Create components
Before.TextBox textBox = new Before.TextBox();
Before.Dialog dialog = new Before.Dialog();

// Button needs to know about both components
Before.Button button = new Before.Button(textBox, dialog);

button.Click("Button Clicked Successfully");

// Output:
// TextBox Cleared Successfully
// Dialog Message: Button Clicked Successfully
```

**Problems with this approach:**
```
⚠️ Issues:
1. Button is tightly coupled to TextBox and Dialog
2. Button knows WHAT to do (clear textbox, show dialog) and HOW to do it
3. If you add a Label or Logger, Button class must be modified
4. Cannot test Button without creating TextBox and Dialog instances
5. Violates Open/Closed Principle (not open for extension, must modify for changes)
6. Violates Single Responsibility Principle (Button has multiple responsibilities)

📌 Even with interfaces:
✅ Better than direct dependency
❌ Still problematic - Button still knows WHO to call and WHEN
❌ Adding new components still requires modifying Button
```

---

### After Mediator (Loosely Coupled)

#### ✅ Solution Code - Using Mediator Pattern

**Step 1: Define Mediator Interface**

**IMediator.cs**
```csharp
namespace Mediator.After
{
    internal interface IMediator
    {
        void Notify(object source, string eventName);
    }
}
```

**Step 2: Create Independent Components**

**Button.cs**
```csharp
namespace Mediator.After
{
    internal class Button
    {
        private readonly IMediator _mediator;
        
        public Button(IMediator mediator)
        {
            this._mediator = mediator;
        }
        
        public void Click()
        {
            // Button only notifies the mediator
            // It doesn't know what happens next
            // It doesn't know about TextBox or Dialog
            _mediator.Notify(this, "Click");
        }
    }
}
```

**TextBox.cs**
```csharp
namespace Mediator.After
{
    internal class TextBox
    {
        public void Clear()
        {
            Console.WriteLine("TextBox Cleared Successfully");
        }
    }
}
```

**Dialog.cs**
```csharp
namespace Mediator.After
{
    internal class Dialog
    {
        public void Show(string message)
        {
            Console.WriteLine($"Dialog Message: {message}");
        }
    }
}
```

**Step 3: Implement Concrete Mediator**

**Mediator.cs**
```csharp
namespace Mediator.After
{
    internal class Mediator : IMediator
    {
        private readonly TextBox _textBox;
        private readonly Dialog _dialog;
        
        public Mediator(TextBox textBox, Dialog dialog)
        {
            this._textBox = textBox;
            this._dialog = dialog;
        }
        
        public void Notify(object source, string eventName)
        {
            // Mediator orchestrates the interaction
            // All coordination logic is centralized here
            if (source is Button && eventName == "Click")
            {
                _textBox.Clear();
                _dialog.Show("Button Clicked Successfully");
            }
            
            // Easy to add new behaviors without modifying Button
            // if (source is Button && eventName == "DoubleClick")
            // {
            //     _textBox.Clear();
            //     _dialog.Show("Button Double Clicked");
            //     _logger.Log("Double click event");
            // }
        }
    }
}
```

**Step 4: Usage**

**Program.cs**
```csharp
namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before using Mediator (Tightly Coupled)
            Console.WriteLine("=== BEFORE Mediator Pattern ===\n");
            
            Before.TextBox textBox1 = new Before.TextBox();
            Before.Dialog dialog1 = new Before.Dialog();
            Before.Button button1 = new Before.Button(textBox1, dialog1);
            
            button1.Click("Button Clicked Successfully");
            
            Console.WriteLine("\n⚠️ Problems:");
            Console.WriteLine("- Button knows about TextBox and Dialog");
            Console.WriteLine("- Adding Label or Logger requires modifying Button");
            Console.WriteLine("- Hard to test Button in isolation");
            Console.WriteLine("- Tight coupling between components\n");
            #endregion
            
            #region After Using Mediator (Loosely Coupled)
            Console.WriteLine("=== AFTER Mediator Pattern ===\n");
            
            // Create components
            After.TextBox textBox = new After.TextBox();
            After.Dialog dialog = new After.Dialog();
            
            // Create mediator with components
            After.Mediator mediator = new After.Mediator(textBox, dialog);
            
            // Button only knows about mediator
            After.Button button = new After.Button(mediator);
            
            // Trigger interaction
            button.Click();
            
            Console.WriteLine("\n✅ Benefits:");
            Console.WriteLine("- Button doesn't know about TextBox or Dialog");
            Console.WriteLine("- Adding Label or Logger doesn't require changing Button");
            Console.WriteLine("- Easy to test Button with mock mediator");
            Console.WriteLine("- Loose coupling between components");
            Console.WriteLine("- Centralized coordination logic");
            #endregion
        }
    }
}
```

**Output:**
```
=== BEFORE Mediator Pattern ===

TextBox Cleared Successfully
Dialog Message: Button Clicked Successfully

⚠️ Problems:
- Button knows about TextBox and Dialog
- Adding Label or Logger requires modifying Button
- Hard to test Button in isolation
- Tight coupling between components

=== AFTER Mediator Pattern ===

TextBox Cleared Successfully
Dialog Message: Button Clicked Successfully

✅ Benefits:
- Button doesn't know about TextBox or Dialog
- Adding Label or Logger doesn't require changing Button
- Easy to test Button with mock mediator
- Loose coupling between components
- Centralized coordination logic
```

---

## How It Works

### Flow Diagram
```
1. User clicks Button
         │
         ▼
2. Button calls: mediator.Notify(this, "Click")
         │
         ▼
3. Mediator receives notification
         │
         ▼
4. Mediator checks: source is Button && event is "Click"
         │
         ▼
5. Mediator orchestrates:
         ├──> textBox.Clear()
         └──> dialog.Show("Message")
         │
         ▼
6. Components execute their actions
```

### Key Points

1. **Button** doesn't know about TextBox or Dialog
2. **Mediator** knows about all components
3. **Components** only communicate through Mediator
4. **Adding new components** doesn't require changing existing ones

---

## Advantages vs Disadvantages

### ✅ Advantages

| Advantage | Explanation | Example |
|-----------|-------------|---------|
| **Loose Coupling** | Components don't depend on each other | Button doesn't know about TextBox or Dialog |
| **Single Responsibility** | Components only handle their own logic | Button handles click, Mediator handles coordination |
| **Easy to Extend** | Add new components without modifying existing ones | Add Logger without changing Button |
| **Centralized Control** | All interaction logic in one place | Mediator controls all communication |
| **Better Testability** | Easy to test components in isolation | Mock the mediator to test Button |
| **Reusability** | Components can be reused in different contexts | Same Button can work with different mediators |
| **Open/Closed Principle** | Open for extension, closed for modification | Add new behaviors in mediator, don't change components |

### ❌ Disadvantages

| Disadvantage | Explanation | Mitigation |
|-------------|-------------|------------|
| **God Object** | Mediator can become too complex with many components | Split into multiple smaller mediators |
| **Single Point of Failure** | If mediator fails, all communication fails | Implement proper error handling and logging |
| **Performance Overhead** | Extra layer of indirection | Usually negligible, but consider for high-performance scenarios |
| **Added Complexity** | More classes in the system | Only use when benefits outweigh complexity |
| **Mediator Knows Everything** | Mediator must know about all components | Keep mediator focused on coordination, not business logic |

---

## When to Use

### ✅ Use Mediator Pattern When:

| Scenario | Reason | Example |
|----------|--------|---------|
| **Many interconnected components** | Reduces complexity of many-to-many relationships | UI form with multiple controls interacting |
| **Complex communication logic** | Centralizes coordination in one place | Workflow with multiple steps and conditions |
| **Want to reuse components** | Components don't depend on specific contexts | Button used in different dialogs |
| **Hard to understand interactions** | Makes communication explicit | Air traffic control system |
| **Changing one component affects many** | Isolates changes to mediator | Adding validation affects multiple fields |

**Common Use Cases:**
1. **GUI Frameworks:** Dialog boxes, forms with multiple controls
2. **Chat Applications:** Users communicate through chat room
3. **Air Traffic Control:** Planes communicate through ATC
4. **Workflow Systems:** Steps coordinate through workflow engine
5. **Game Development:** Game objects interact through game manager

### ❌ Don't Use Mediator Pattern When:

| Scenario | Reason | Alternative |
|----------|--------|-------------|
| **Simple interactions** | Overhead not justified | Direct communication |
| **Only 2 objects** | No need for mediator | Direct reference or Observer pattern |
| **One-way communication** | Mediator is overkill | Command pattern or direct call |
| **Performance critical** | Extra indirection adds overhead | Direct communication with careful design |
| **Clear hierarchy** | Parent-child relationship is natural | Composite pattern |
---


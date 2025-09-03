# ??? Builder Design Pattern

## ?? What is the Builder Pattern?
The **Builder Pattern** is a creational design pattern used to construct complex objects step by step.  
It separates the construction process from the representation, allowing the same construction process to create different types of objects.

---

## ?? Without Builder
In .NET, without a builder, you might need to repeatedly create new objects or work with immutable objects directly, which can be inefficient or verbose.

Example:  
Working with strings directly in C# requires creating new string objects each time you modify the text, which is inefficient.

---

## ? With Builder
The Builder Pattern provides a **mutable helper class** that allows you to build the object step by step and only create the final object when needed.

Example:  
In .NET, the **`StringBuilder`** class implements the Builder Pattern.  
- You can append, insert, or remove text without creating new string instances each time.  
- Finally, you call `.ToString()` to produce the built string.

---

## ? Advantages
- Improves efficiency when building complex or mutable objects.  
- Avoids constructors with too many parameters.  
- Allows step-by-step construction with flexibility.  
- Provides a fluent and readable API.  

---

## ?? Disadvantages
- Requires additional classes (the Builder itself).  
- Can be overkill for very simple objects.  
- Adds extra abstraction to the design.  

---

## ?? When to Use?
- When an object has **many optional or complex parameters**.  
- When repeated modifications are required before producing the final object.  
- When efficiency and readability are important.  

---

## ?? Examples in .NET

### ?? `StringBuilder`
Instead of creating multiple string objects:
```csharp
var builder = new StringBuilder();
builder.Append("Hello");
builder.Append(" World");
string result = builder.ToString(); // "Hello World"

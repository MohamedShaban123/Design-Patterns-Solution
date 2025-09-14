# Proxy Design Pattern

## 📖 Overview
The **Proxy Pattern** is a structural design pattern that provides a **substitute (placeholder)** for another object to control access to it.  
Instead of working directly with the real object, clients use the proxy, which forwards requests to the real object while adding extra behavior if necessary.  

---

## 🎯 Intent
- Control access to an object.  
- Add additional behavior without modifying the real object.  
- Delay object creation (lazy loading).  
- Provide security, logging, caching, or remote access.  

---

## 📊 Participants
1. **Subject** – Defines the common interface for both the Real Object and Proxy.  
2. **RealSubject** – The actual object that performs the real work.  
3. **Proxy** – Acts as a substitute for the RealSubject and controls access to it.  
4. **Client** – Uses the Subject interface but works indirectly with the RealSubject through the Proxy.  

---

## 🔑 Types of Proxies
- **Virtual Proxy** → Delays creation of heavy objects until needed.  
- **Protection Proxy** → Controls access based on permissions.  
- **Remote Proxy** → Represents an object in a different address space (e.g., remote server).  
- **Caching Proxy** → Stores results of expensive calls for reuse.  
- **Logging Proxy** → Logs requests before passing them to the real object.  

---

## ✅ Benefits
- Adds a layer of security and access control.  
- Improves performance with lazy loading and caching.  
- Helps manage complexity by acting as a gatekeeper.  
- Keeps client code consistent (client doesn’t know if it’s using proxy or real object).  

---

## ⚠️ Drawbacks
- Adds extra complexity.  
- May introduce performance overhead due to indirection.  

---

## 📌 Real-World Examples
- **ATM card** → Proxy for your bank account.  
- **Reverse proxy (Nginx/Apache)** → Controls client access to backend servers.  
- **Smart pointer in C++** → Acts as a proxy to manage memory.  
- **Virtual proxy in an image viewer** → Load a high-resolution image only when it’s displayed.  

---

## 📂 Example Use Case (Conceptual)
- **Subject:** `IBankAccount` defines the `Withdraw(amount)` method.  
- **RealSubject:** `RealBankAccount` performs actual withdrawal and balance updates.  
- **Proxy:** `BankAccountProxy` checks user role before forwarding the request to `RealBankAccount`.  
- **Client:** Calls `Withdraw(amount)` without knowing whether it’s working with a proxy or real object.  

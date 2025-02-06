## Day 1
Online Shopping System

Create a Product class with attributes:
1. ProductID(int)
2. Name(string)
3. Price(decimal)
4. StockQuantity(private int)

Implement Encapsulation:
1. Restrict direct access to StockQuantity (private).
2. Provide getter and setter methods (UpdateStock(), GetStockQuantity()).
3. Ensure StockQuantity cannot be negative when a product is added or purchased.

Implement:
1. Parameterized Constructor to initialize products.
2. Destructor to print a message when a product is removed from the system.

![day1_1](/img/day1_1.png)
![day1_2](/img/day1_2.png)

Destructor is only called by programiz.com c# compiler

## Day 2
Online Shopping System

Inheritance(Base & Derived Classes, base Keyword, Method Overriding)
1. Create a base class Item with common attributes(ProductID, Name).
2. Create derived classes:
    a. Electronics(with additional warranty period).
    b. Clothing(with size and material attributes).
3. Use the base keyword in derived classes to call the parent constructor.
4. Override DisplayProductDetails() to provide product-specific details.

Polymorphism(Method Overloading, Method Overriding, Virtual Methods)
●	Implement Method Overloading:
    ○	ApplyDiscount(decimal percentage)
    ○	ApplyDiscount(decimal percentage, bool isLoyalCustomer)
●	Implement Method Overriding:
    ○	Use virtual in Item for CalculateFinalPrice().
    ○	Override CalculateFinalPrice() in Electronics and Clothing

Abstraction(Abstract Classes vs Interfaces)
●	Create an abstract class ShoppingService :
    ○	Abstract method GetCategory().
    ○	Non-abstract method PrintShoppingPolicy().
●	Implement ShoppingService in Product.
●	Create an interface IShoppingCartOperations :
    ○	void AddProduct(int productID, int quantity);
    ○	void RemoveProduct(int productID);
    ○	void DisplayCart();
●	Implement Explicit Interface Implementation in ShoppingCart.

Sealed Class
    ●	Implement a sealed class PaymentProcessor to handle payments.
    ●	Add a method ProcessPayment(decimal amount, string paymentMethod).

Partial Class
Implement a partial class ShoppingCartOperations :
    ●	One part handles AddProduct() and RemoveProduct().
    ●	Another part handles UpdateStock() and DisplayCart()

![day2](/img/day2.png)

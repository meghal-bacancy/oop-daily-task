namespace day2
{
    //Online Shopping System

    //Inheritance (Base & Derived Classes, base Keyword, Method Overriding)
    //●	Create a base class Item with common attributes (ProductID, Name).
    //●	Create derived classes:
    //    ○	Electronics(with additional warranty period).
    //    ○	Clothing(with size and material attributes).
    //●	Use the base keyword in derived classes to call the parent constructor.
    //●	Override DisplayProductDetails() to provide product-specific details.

    //Polymorphism(Method Overloading, Method Overriding, Virtual Methods)
    //●	Implement Method Overloading:
    //    ○	ApplyDiscount(decimal percentage)
    //    ○	ApplyDiscount(decimal percentage, bool isLoyalCustomer)
    //●	Implement Method Overriding:
    //    ○	Use virtual in Item for CalculateFinalPrice().
    //    ○	Override CalculateFinalPrice() in Electronics and Clothing

    class Item
    {
        private int _id;
        private string _name;
        private int _price;

        public Item(int id, string name, int price)
        {
            _id = id;
            _name = name;
            _price = price;
            Console.WriteLine("Item Class Constructor");
        }

        public virtual void DisplayProductDetails()
        {
            Console.Write($"Product ID: {_id}, Name: {_name}");
        }

        //protected double ApplyDiscount(double percentage)
        //{
        //    return (1 - percentage) * _price;
        //}

        //protected double ApplyDiscount(double percentage, bool isLoyalCustomer)
        //{
        //    return (1 - percentage - (0.1 * percentage)) * _price;
        //}

        public int GetPrice()
        {
            return _price;
        }

        public virtual double CalculateFinalPrice()
        {
            //return ApplyDiscount(0.2);
            return 0.8 * _price;
        }
    }

    class Electronics : Item
    {
        private int _warrantyPeriod;

        public Electronics(int id, string name, int price, int warrantyPeriod) : base(id, name, price)
        {
            _warrantyPeriod = warrantyPeriod;
            Console.WriteLine("Electronics Class Constructor");
        }

        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($", Warranty Period: {_warrantyPeriod} years");
        }

        public override double CalculateFinalPrice()
        {
            //return ApplyDiscount(0.2, true);
            return 0.9 * GetPrice();
        }
    }

    class Clothing : Item
    {
        private int _size;
        private string _material;

        public Clothing(int id, string name, int price, int size, string material) : base(id, name, price)
        {
            _size = size;
            _material = material;
            Console.WriteLine("Clothing Class Constructor");
        }

        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($", Size: {_size}, Material: {_material} ");
        }

        public override double CalculateFinalPrice()
        {
            return 0.9 * GetPrice();
        }
    }

    //Abstraction(Abstract Classes vs Interfaces)
    //●	Create an abstract class ShoppingService :
    //    ○	Abstract method GetCategory().
    //    ○	Non-abstract method PrintShoppingPolicy().
    //●	Implement ShoppingService in Product.
    //●	Create an interface IShoppingCartOperations :
    //    ○	void AddProduct(int productID, int quantity);
    //    ○	void RemoveProduct(int productID);
    //    ○	void DisplayCart();
    //●	Implement Explicit Interface Implementation in ShoppingCart.

    abstract class ShoppingService
    {
        public abstract void GetCategory();
        public void PrintShoppingPolicy()
        {
            Console.WriteLine("Shopping Policy");
        }
    }

    class Product : ShoppingService
    {
        public override void GetCategory()
        {
            Console.WriteLine("Product Category");
        }
    }

    interface IShoppingCartOperations
    {
        void AddProduct(int productID, int quantity);
        void RemoveProduct(int productID);
        void DisplayCart();
    }

    class ShoppingCart : IShoppingCartOperations
    {
        private Dictionary<int, int> cart = new Dictionary<int, int>();

        public void AddProduct(int productID, int quantity)
        {
            if (cart.ContainsKey(productID))
                cart[productID] += quantity;
            else
                cart[productID] = quantity;

            Console.WriteLine($"Product {productID} added with quantity {quantity}.");
        }

        public void DisplayCart()
        {
            if (cart.Count == 0)
            {
                return;
            }

            foreach (var item in cart)
            {
                Console.WriteLine($"Product ID: {item.Key}, Quantity: {item.Value}");
            }
        }

        public void RemoveProduct(int productID)
        {
            if (cart.ContainsKey(productID))
            {
                cart.Remove(productID);
                Console.WriteLine($"Product {productID} removed.");
                return;
            }
            Console.WriteLine($"Product {productID} not found in cart.");
        }
    }

    //Sealed Class
    //    ●	Implement a sealed class PaymentProcessor to handle payments.
    //    ●	Add a method ProcessPayment(decimal amount, string paymentMethod).

    sealed class PaymentProcessor
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($"Payment Method: {paymentMethod}, Amount: {amount}");
        }
    }
}

//Partial Class
//Implement a partial class ShoppingCartOperations:
//    ●	One part handles AddProduct() and RemoveProduct().
//    ●	Another part handles UpdateStock() and DisplayCart()

partial class ShoppingCartOperations
{
    //private Dictionary<int, int> cart = new Dictionary<int, int>();
    public void AddProduct(int productID, int quantity)
    {
        if (cart.ContainsKey(productID))
            cart[productID] += quantity;
        else
            cart[productID] = quantity;

        Console.WriteLine($"Product {productID} added with quantity {quantity}.");
    }

    public void RemoveProduct(int productID)
    {
        if (cart.ContainsKey(productID))
        {
            cart.Remove(productID);
            Console.WriteLine($"Product {productID} removed.");
            return;
        }
        Console.WriteLine($"Product {productID} not found in cart.");
    }
}
using day2;

class Program
{
    static void Main(string[] args)
    {
        //Inheritance(Base & Derived Classes, base Keyword, Method Overriding)
        Electronics ElectronicItem = new Electronics(1, "m", 50, 5);
        Clothing ClothingItem = new Clothing(1, "m", 100, 6, "silk");
        ElectronicItem.DisplayProductDetails();
        ClothingItem.DisplayProductDetails();
        Console.WriteLine();

        //Polymorphism(Method Overloading, Method Overriding, Virtual Methods)
        Console.WriteLine($"Final Price of Electronic Item {ElectronicItem.CalculateFinalPrice()}");
        Console.WriteLine($"Final Price of Clothing Item {ClothingItem.CalculateFinalPrice()}");
        Console.WriteLine();

        //Abstraction(Abstract Classes vs Interfaces)
        Product product = new Product();
        product.PrintShoppingPolicy();
        product.GetCategory();

        Console.WriteLine();
        ShoppingCart cart = new ShoppingCart();
        cart.AddProduct(56, 7);
        cart.AddProduct(89, 1);
        cart.AddProduct(63, 10);
        Console.WriteLine();

        cart.DisplayCart();
        cart.RemoveProduct(56);
        Console.WriteLine();
        cart.DisplayCart();
        Console.WriteLine();

        //Sealed Class
        PaymentProcessor paymentProcessor = new PaymentProcessor();
        paymentProcessor.ProcessPayment(50, "Cash");
        paymentProcessor.ProcessPayment(60, "Credit Card");
        Console.WriteLine();

        //Partial Class
        ShoppingCartOperations shoppingCartOperations = new ShoppingCartOperations();
        shoppingCartOperations.AddProduct(56, 7);
        shoppingCartOperations.AddProduct(89, 1);
        shoppingCartOperations.AddProduct(63, 10);
        Console.WriteLine();

        shoppingCartOperations.DisplayCart();
    }
}
//Online Shopping System

//Create a Product class with attributes:
//○	ProductID(int)
//○	Name(string)
//○	Price(decimal)
//○	StockQuantity(private int)

//Implement Encapsulation:
//○	Restrict direct access to StockQuantity (private).
//○	Provide getter and setter methods (UpdateStock(), GetStockQuantity()).
//○	Ensure StockQuantity cannot be negative when a product is added or purchased.

//Implement:
//○	Parameterized Constructor to initialize products.
//○	Destructor to print a message when a product is removed from the system.


class Product
{
    int ProductID;
    String Name;
    decimal Price;
    private int StockQuantity;

    public void UpdateStock(int StockQuantity)
    {
        if (StockQuantity + this.StockQuantity >= 0)
        {
            this.StockQuantity += StockQuantity;
        }
        else
        {
            Console.WriteLine("StockQuantity cannot be negative");
        }
    }

    public int GetStockQuantity()
    { 
        return this.StockQuantity; 
    }

    public Product(int ProductID, String Name, decimal Price, int StockQuantity)
    {
        this.ProductID = ProductID;
        this.Name = Name;
        this.Price = Price;
        this.StockQuantity = StockQuantity > 0 ? StockQuantity : 0;
    }

    ~Product()
    {
        Console.WriteLine($"Product with Name: {Name}, ProductID: {ProductID}, Price: {Price}, and StockQuantity: {StockQuantity} destroyed.");

    }
}

class Program
{
    static void Main(string[] args)
    {
        Product Laptop = new Product(10, "Laptop", 25.6M, 10);

        Console.WriteLine($"Initial Stock: {Laptop.GetStockQuantity()}");
        Laptop.UpdateStock(5);
        Laptop.UpdateStock(-12);
        Laptop.UpdateStock(-5);

        Product Keyboard = new Product(20, "Keyboard", 2.65M, 10);
        Product Mouse = new Product(30, "Mouse", 15M, 0);
    }
}


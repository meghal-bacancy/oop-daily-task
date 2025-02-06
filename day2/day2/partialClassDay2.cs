partial class ShoppingCartOperations
{
    private Dictionary<int, int> cart = new Dictionary<int, int>();
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
}
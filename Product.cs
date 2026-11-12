namespace C__Preply;

public class Product : IProduct
{
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductStock { get; set; }

    public Product(string name, decimal price, int stock)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Product name cannot be empty.");
        }

        if (price <= 0)
        {
            throw new ArgumentException("Price must be greater than zero.");
        }

        if (stock < 0)
        {
            throw new ArgumentException("Stock cannot be negative.");
        }
        
        ProductName = name;
        ProductPrice = price;
        ProductStock = stock;
    }

    public virtual decimal Sell(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be greater than zero.");
        }

        if (quantity > ProductStock)
        {
            throw new InvalidOperationException("Not enough products in stock.");
        }

        decimal totalCost = ProductPrice * quantity;
        ProductStock -= quantity;

        return totalCost;
    }

    public void Restock(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be greater than zero.");
        }

        ProductStock += quantity;
    }
}
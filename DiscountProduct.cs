namespace C__Preply;

public class DiscountProduct : Product
{
    public decimal DiscountPercent { get; set; }
    
    public DiscountProduct(string name, decimal price, int stock, decimal discountPercent) : base(name, price, stock)
    {
        
        if (discountPercent <= 0 || discountPercent >= 100)
        {
            throw new ArgumentException("Discount must be between 0 and 100 percent.");
        }

        DiscountPercent = discountPercent;
    }
    
    public override decimal Sell(int quantity)
    {
        decimal originalCost = base.Sell(quantity);

        decimal totalCost = originalCost * (100 - DiscountPercent) / 100;

        return totalCost;
    }
    
    
}
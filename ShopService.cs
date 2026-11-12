namespace C__Preply;

public class ShopService
{
    public decimal SellProduct(IProduct product, int quantity)
        {
            return product.Sell(quantity);
        }

    public void RestockProduct(IProduct product, int quantity)
    {
        product.Restock(quantity);
    }
    
}
namespace C__Preply;

public interface IProduct
{
    decimal Sell(int quantity);
    void Restock(int quantity);
}
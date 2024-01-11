namespace ConsoleApp84;

public class Pasta : FastFood
{
    public Pasta(string name) : base(name)
    {
        
    }

    public override void SetPrice(int price)
    {
        if (price > 1000)
        {
            throw new Exception("wrong price for pasta");
        }
        base.SetPrice(price);
    }
}
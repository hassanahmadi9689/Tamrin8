namespace ConsoleApp84;

public class Pizza : FastFood
{
    public Pizza(string name) : base(name)
    {
            
    }

    public override void SetPrice(int price)
    {
        if (price > 20000)
        {
            throw new Exception("wrong price for pizza");
        }
        base.SetPrice(price);
    }
}
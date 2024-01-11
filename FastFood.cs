namespace ConsoleApp84;

public class FastFood
{
    protected FastFood(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    
    public int Price { get;private set; }
    public Type Type { get; private set; }

    public void SetType(Type type)
    {

        Type = type;

    }
    public virtual void SetPrice(int price)
    {
        if (price<0)
        {
            throw new Exception("price cant bee negative");
        }

        Price = price;
    }
}

public enum Type
{
    Pizza,
    Pasta
}
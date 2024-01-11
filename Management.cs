namespace ConsoleApp84;

public class Management : IFood
{
    private static List<FastFood> _foods = new List<FastFood>();
    private static List<UserPurchases> _userPurchases = new List<UserPurchases>();
    public void AddFood(string name,int price,int type)
    {
        if (type==1)
        {
            var pizza = new Pizza(name);
            pizza.SetPrice(price);
            pizza.SetType(Type.Pizza);
            _foods.Add(pizza);
        }

        if (type==2)
        {
            var pasta = new Pasta(name);
            pasta.SetPrice(price);
            pasta.SetType(Type.Pasta);
            _foods.Add(pasta);
        }
    }

    

    public static void sale(string username, string foodname)
    {
        var food = _foods.Find(_ => _.Name == foodname);
        if (food is null)
        {
            throw new Exception("food no found");
        }

        var buy = new UserPurchases(username, food);
        _userPurchases.Add(buy);
    }

    public void ShowListFoods()
    {
        foreach (var food in _foods)
        {
            Console.WriteLine($"type :{food.Type } - name :{food.Name} - price: {food.Price}");
        }
    }

    public static void showselling()
    {
        foreach (var selling in _userPurchases)
        {
            Console.WriteLine($"user :{selling.User} - food : {selling.FastFood.Name} - date:{selling.PurchaseDate}");
        }
    }
}
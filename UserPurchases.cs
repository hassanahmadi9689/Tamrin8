namespace ConsoleApp84;

public class UserPurchases
{
    public UserPurchases(string user, FastFood food)
    {
        User = user;
        FastFood = food;
        PurchaseDate=DateTime.Now;
    }
    public string User { get; set; }
    public FastFood FastFood { get; set; }
    
    public DateTime PurchaseDate { get; set; }
    
}
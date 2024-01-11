namespace ConsoleApp84;

//public class User
//{
    //public User(string username)
    //{
        //Username = username;
      //  _UserPurchasesList = new ();
    //}
    
    //public string Username { get; set; }
    //private List<UserPurchases> _UserPurchasesList;

    //public List<UserPurchases> GetPurchasesList()
    //{
      //  return _UserPurchasesList;
    //}

    //public void setpurchases(FastFood food)
    //{
    //    _UserPurchasesList.Add(new UserPurchases(this,food.Name,food.Price));
  //  }
//}
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
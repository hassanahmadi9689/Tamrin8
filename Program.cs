// See https://aka.ms/new-console-template for more information

using ConsoleApp84;

IFood food = new Management();
while (true)
{
    try
    {
        Run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}


void Run()
{var Option = GetNumberFromUser("Choose option:\n" +
                                "1.Add food\n" +
                                "2.Show foods\n" +
                                "3.selling food \n" +
                                "4.Show list of selling ");
    switch (Option)
    {
        case 1:
        {
            var name = GetValidStringFromUser("enter name of food");
            var type = GetNumberFromUser("choose : \n" +
                                         "1.pizza\n" +
                                         "2.pasta");
            int price = GetNumberFromUser("enter price");
            food.AddFood(name,price,type);
            break;
        }
        case 2:
        {
            food.ShowListFoods();
            break;
        }
        case 3:
        {
            var username = GetValidStringFromUser("enter username");
            var foodname = GetValidStringFromUser("enter name of food");
            Management.sale(username,foodname);
            break;
        }
        case 4:
        {
            Management.showselling();
            break;
        }
       
            
    }
    
}


static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}
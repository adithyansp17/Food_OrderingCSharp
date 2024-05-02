//dotnet ef dbcontext scaffold "Data Source=TJ16AA044-PC,49955;Initial Catalog=FoodToOrder_WPF_Adithyan;User=sa;Password=sa@1234;TrustServiceCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --namespace FoodToOrderLibrary --data-annotations --project FoodToOrder


using FoodToOrderLibrary;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.Numerics;

List<Restaurant> items;

//Reading data from .json file
using (StreamReader r = new StreamReader("RestaurantData.json"))
{
    string json = r.ReadToEnd();
    items = JsonConvert.DeserializeObject<List<Restaurant>>(json);
}

//lambda expressions
var ClearScreen = () => { Console.Clear(); } ;
var appNamePrint = () => { Console.WriteLine($"\t\tFOOD ORDERING APPLICATION\n{new string('-', 57)}\n\n"); };

//Delete a restaurant
void DeleteRestaurant()
{
    displayrestaurant();
    Console.Write("\nEnter the s.no of restaurant to delete: ");
    int sno = Convert.ToInt32(Console.ReadLine());
    Restaurant q =items.Where(id => id.Id == sno).ToList()[0];
    bool f= items.Remove(q);
    Console.WriteLine("\n\nDeleting!! Please wait...");
    Thread.Sleep(3000);
}

//Edit the details of restaurant
void EditRestaurant()
{
    displayrestaurant();
    Console.Write("\nEnter the s.no of restaurant to edit: ");
    int sno = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nEnter 1 to edit name and 2 to update open status: ");
    int ch = Convert.ToInt32(Console.ReadLine());
    if (ch == 1)
    {
        Console.Write("\nEnter the new name: ");
        string name = Console.ReadLine();
        items[sno - 1].RestaurantName = name;
    }
    else
    {
        items[sno - 1].ROpen= !(items[sno - 1].ROpen);
    }
    Console.WriteLine("\n\nEditing!! Please wait...");
    Thread.Sleep(3000);
}

//Delete a dish
void DeleteDish()
{
    displayrestaurant();
    Console.Write("\nEnter the s.no of restaurant's dish to delete: ");
    int sno = Convert.ToInt32(Console.ReadLine());
    Dishlist(items[sno-1]);
    Console.Write("\nEnter the s.no of dish to delete: ");
    int dno = Convert.ToInt32(Console.ReadLine());
    Dishes rmd = items[sno-1].dishes.Where(x => x.Id == dno).ToList()[0];
    items[sno-1].dishes.Remove(rmd);
    Console.WriteLine("\n\nDeleting!! Please wait...");
    Thread.Sleep(3000);
}

//Edit the details of a dish
void EditDish(int id)
{
    Dishlist(items[id - 1]);
    Console.Write("\nEnter the s.no of dish to edit: ");
    int dno = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nEnter 1 to edit name, 2 to edit price and 3 to change availabiltity: ");
    int ch = Convert.ToInt32(Console.ReadLine());
    if (ch == 1)
    {
        Console.Write("\nEnter the new name: ");
        string name = Console.ReadLine();
        items[id - 1].dishes[dno-1].DishName = name;
    }
    else if (ch == 2)
    {
        Console.Write("\nEnter the new price: ");
        int newp = Convert.ToInt32(Console.ReadLine());
        items[id - 1].dishes[dno - 1].Price = newp;
        PriceChange();
    }
    else
    {
        items[id - 1].dishes[dno - 1].Available = !(items[id - 1].dishes[dno - 1].Available);
    }
    Console.WriteLine("\n\nEditing!! Please wait...");
    Thread.Sleep(3000);
}

//Event handled method
void PriceChange()
{
    Console.WriteLine("\n\nPrice has changed for a dish");
    Thread.Sleep(1500);
}

//Adding a dish
void AddDish(int Rid)
{
    int id;
    if(items[Rid - 1].dishes.Count == 0)
    {
        id = 1;
    }
    else
    {
        id = items[Rid - 1].dishes[items[Rid - 1].dishes.Count-1].Id + 1;
    }
    
    bool avail = true;
    int rid = Rid,amt;
    string dname;

    Console.Write("\nEnter the dish name: ");
    dname= Console.ReadLine();
    Console.Write("\nEnter the price: ");
    amt = Convert.ToInt32(Console.ReadLine());
    Dishes d = new Dishes(id, dname, avail, amt, rid);
    items[Rid-1].dishes.Add(d);
}

//Add a restaurant
void AddRestaurant()
{
    Console.WriteLine("\nADDING A RESTAURANT\n");
    int id = items[items.Count-1].Id+1;
    bool open = true;
    Console.Write("\nEnter the restaurant name: ");
    string name = Console.ReadLine();
    Console.Write("\nEnter the no of dishes available in this restaurant: ");
    int nd = Convert.ToInt32(Console.ReadLine());
    Restaurant R = new Restaurant(id,name, open, new List<Dishes>());
    items.Add(R);
    for(int i = 0; i < nd; i++)
    {
        Console.WriteLine("\nEnter the details for {0} dish",i+1);
        AddDish(id);
    }
    Console.WriteLine("\n\nAdding!! Please wait...");
    Thread.Sleep(3000);
}

//Admin control
void AdminScreen()
{
    int id;
    ClearScreen();
    appNamePrint();
    Console.WriteLine("1. Admin authority\n\n2. Display Restaurant Names\n\n3. Exit\n\n");
    Console.Write("Please enter your choice: ");
    int adminChoice = Convert.ToInt32(Console.ReadLine());
    if (adminChoice == 1)
    {
        ClearScreen();
        appNamePrint();
        Console.WriteLine("1. Add a restaurant\n\n2. Modify any details of restaurant\n\n3. Delete a restaurant\n\n4. Add a dish to a restaurant\n\n5. Modify a dish details\n\n6. Delete a dish\n\n7. Go back\n\n");
        Console.Write("Enter the choice: ");
        int ach = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
        appNamePrint();
        switch (ach)
        {
            case 1:
                AddRestaurant();
                AdminScreen();
                break;
            case 2:
                EditRestaurant();
                AdminScreen();
                break;
            case 3:
                DeleteRestaurant();
                AdminScreen();
                break;
            case 4:
                displayrestaurant();
                Console.Write("Enter the s.no of restaurant to add the dish: ");
                id = Convert.ToInt32(Console.ReadLine());
                ClearScreen();
                appNamePrint();
                Console.WriteLine("\nADDING A DISH\n");
                AddDish(id);
                Console.WriteLine("\n\nEditing!! Please wait...");
                Thread.Sleep(3000);
                AdminScreen();
                break;
            case 5:
                displayrestaurant();
                Console.Write("Enter the s.no of restaurant to edit the dish: ");
                id= Convert.ToInt32(Console.ReadLine());
                EditDish(id);
                AdminScreen();
                break;
            case 6:
                DeleteDish();
                AdminScreen();
                break;
            case 7:
                AdminScreen();
                break;
            default:
                AdminScreen();
                break;
        }
    }
    else if (adminChoice == 2) 
    {
        displayrestaurant();
        Console.Write("Enter 1 to go back: ");
        int goBack = Convert.ToInt32(Console.ReadLine());
        if (goBack == 1)
        {
            AdminScreen();
        }
    }
    else
    {
        var convertedJson1 = JsonConvert.SerializeObject(items, Formatting.Indented);
        File.WriteAllText("C:\\Users\\Adithyan SP\\source\\repos\\FoodToOrder\\FoodToOrder\\RestaurantData.json", convertedJson1);
        Environment.Exit(0);
    }
    var convertedJson = JsonConvert.SerializeObject(items, Formatting.Indented);
    File.WriteAllText("C:\\Users\\Adithyan SP\\source\\repos\\FoodToOrder\\FoodToOrder\\RestaurantData.json", convertedJson);

}

//To display the restaurant list
void displayrestaurant()
{
    ClearScreen();
    appNamePrint();
    var resList = from item in items
                  select item;
    foreach (var i in resList)
    {
        if (i.ROpen)
        {
            Console.WriteLine($"{i.Id}. Restaurant- {i.RestaurantName}\n");
        }
    }
}

//To display the dish list
void Dishlist(Restaurant r)
{
    ClearScreen();
    appNamePrint();
    Console.WriteLine($"\t\tMENU\n{new string('-', 40)}");
    for (int i = 0; i < r.dishes.Count; i++)
    {
        if (r.dishes[i].Available)
        {
            Console.WriteLine($"{r.dishes[i].Id}. {r.dishes[i].DishName}\t\tPrice -{r.dishes[i].Price}");
        }
    }
}

void UserScreen()
{
    int tries = 0, total = 0, ans;
    bool flag = false;
    Users users = new Users();
    Console.WriteLine($"SIGN-IN FOR ORDERING\n{new string('-', 21)}\n");
    //To give the user 3 chance for authentication
    while (tries < 3)
    {
        ++tries;
        Console.Write("\nEnter your Email: ");
        string email = Console.ReadLine();
        Console.Write("\nEnter your password: ");
        string pass = Console.ReadLine();

        foreach (var item in Data.users)
        {
            if (item.Email == email)
            {
                if (item.Password == pass)
                {
                    users.print();
                    if (item.Role == "admin")
                    {
                        AdminScreen();
                        Environment.Exit(0);
                    }
                    Console.WriteLine($"Restaurant List\n{new string('-', 20)}\n");
                    displayrestaurant();
                    flag = true;
                }
            }
        }
        if (flag)       //Valid user
            break;
        else
        {
            if (tries < 3)
                Console.WriteLine("Invalid username and password\nTry again!!\n\n");
        }
    }
    //Invalid login credentials
    if (!flag)
    {
        Console.WriteLine("\nUnauthorized User....\nExiting...\n");
        Environment.Exit(1);
    }

    Console.Write("\nPlease choose a Restaurant: ");
    int ch = Convert.ToInt32(Console.ReadLine());

    switch (ch)
    {
        case 1:
            Dishlist(items[0]);
            break;
        case 2:
            Dishlist(items[1]);
            break;
        case 3:
            Dishlist(items[2]);
            break;
    }

    List<CartDetails> list = new List<CartDetails>();

    //Adding the food item and the quantity to a a list
    do
    {
        Console.Write("\nChoose the item to order :");
        int ch1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter the quantity :");
        int qty = Convert.ToInt32(Console.ReadLine());

        CartDetails details = new CartDetails(1, ch1, qty);
        list.Add(details);

        Console.Write("\nDo you need more items(1-yes/0-no): ");
        ans = Convert.ToInt32(Console.ReadLine());
    } while (ans == 1);

    Console.Write("\n\nEnter 1 to place the order and 0 to Cancel: ");
    ans = Convert.ToInt32(Console.ReadLine());

    if (ans == 1)
    {
        ClearScreen();
        appNamePrint();
        Restaurant cartde = items[ch - 1];
        Console.WriteLine("\n\nCART DETAILS");
        Console.WriteLine(new string('-', 21) + "\n");
        Console.WriteLine("\nItem\t\tQuantity\tPrice\tTotal\n");

        //Displaying the cart details
        foreach (var i in list)
        {
            var sltdish = cartde.dishes[i.DishId - 1];
            double amt = sltdish.Price;
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", sltdish.DishName, i.Quantity, sltdish.Price, amt * i.Quantity);
            total += (int)amt * i.Quantity;
        }

        Console.WriteLine(new string('-', 40) + "\n");
        Console.WriteLine("\t\t\tThe total MRP = {0}", total);
        Console.Write("\n\nPress 1 to Confirm: ");
        tries = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n\nPlacing the order!! Please wait...");
        Thread.Sleep(3000);
        if (tries == 1)
        {
            Console.WriteLine("\n\nOrder Placed...Thank you for ordering..:)\n");
        }
    }
}
//main starts here
appNamePrint();
Data d = new Data();
UserScreen();

//EventHandler add to a function which is declared in the data.cs file
d.Changed += PriceChange;
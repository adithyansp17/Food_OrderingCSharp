using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Data
    {
        public Data()
        {
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
        }
        public delegate void PriceChangedHandler();


        public event PriceChangedHandler Changed; 

        public static List<Users> users = new List<Users>();
        
        Users user1 = new Users(1, "John", "Doe", "user", "johndoe@gmail.com", "password");
        Users user2 = new Users(2, "Mary", "Jane", "user", "maryj@gmail.com", "password");
        Users user3 = new Users(3, "Sam", "Smith", "user", "samsmith@gmail.com", "password");
        Users user4 = new Users(1, "Admin", "X", "admin", "admin", "admin");

    }
}

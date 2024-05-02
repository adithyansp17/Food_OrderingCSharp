  using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Restaurant
    {
        private int id;
        private string restaurantName;
        private bool ropen;
        private int userId;

        public int Id
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }
        public string RestaurantName
        { 
            get 
            { 
                return restaurantName; 
            } 
            set 
            { 
                restaurantName = value; 
            } 
        }
        public bool ROpen
        { 
            get 
            { 
                return ropen;
            } 
            set 
            {  
                ropen = value; 
            } 
        }
        public int UserId
        { 
            get 
            { 
                return userId; 
            } 
            set 
            { 
                userId = value;
            } 
        }

        public List<Dishes> dishes = new List<Dishes>();
        public Restaurant() { }

        public Restaurant(int id,string name,bool open,List<Dishes> d)
        {
            Id = id;
            RestaurantName= name;
            ROpen = open;
            foreach (Dishes dis in d)
            {
                dishes.Add(dis);
            }
        }

       
    }
}

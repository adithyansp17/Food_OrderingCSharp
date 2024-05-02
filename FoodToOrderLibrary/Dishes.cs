using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Dishes
    {
        private int id;
        private string dishName;
        private bool available;
        private int price;
        private int restaurantId;

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
        public string DishName
        {
            get
            {
                return dishName;
            }
            set
            {
                dishName = value;
            }
        }
        public bool Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int RestaurantId
        {
            get
            {
                return restaurantId;
            }
            set
            {
                restaurantId = value;
            }
        }
        public Dishes() { }

        public Dishes(int id, string dishName, bool available, int price, int restaurantId)
        {
            Id = id;
            DishName = dishName;
            Available = available;
            Price = price;
            RestaurantId = restaurantId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class CartDetails
    {
        private int id;
        private int dishId;
        private int quantity;

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
        public int DishId
        {
            get
            {
                return dishId;
            }
            set
            {
                dishId = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public CartDetails() { }

        public CartDetails(int id, int dishId, int quantity)
        {
            Id = id;
            DishId = dishId;
            Quantity = quantity;
        }
    }
}

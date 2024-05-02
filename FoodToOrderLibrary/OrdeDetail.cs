using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class OrdeDetail
    {
        private int id;
        private int dishId;
        private int quantity;
        private int orderId;

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
        public int OrderId
        {
            get
            {
                return orderId;
            }
            set
            {
                orderId = value;
            }
        }
        public OrdeDetail() { }

        public OrdeDetail(int id, int dishId, int quantity, int orderId)
        {
            Id = id;
            DishId = dishId;
            Quantity = quantity;
            OrderId = orderId;
        }
    }
}

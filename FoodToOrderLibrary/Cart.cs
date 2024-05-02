using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Cart
    {
        private int id;
        private double amount;
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
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
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
        public Cart() { }

        public Cart(int id, double amount, int userId) 
        {  
            Id = id; 
            Amount = amount; 
            UserId = userId;
        }
    }
}

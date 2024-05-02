using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Orders
    {
        private int id;
        private DateOnly date;
        private double orderAmount;
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
        public DateOnly Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public double OrderAmount
        {
            get
            {
                return orderAmount;
            }
            set
            {
                orderAmount = value;
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
        public Orders() { }

        public Orders(int iD, DateOnly date, double orderAmount, int userId)
        {
            Id = iD;
            Date = date;
            OrderAmount = orderAmount;
            UserId = userId;
        }
    }
}

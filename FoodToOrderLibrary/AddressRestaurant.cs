using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class AddressRestaurant
    {
        private int addressId;
        private int restaurantId;

        public int AddressId
        {
            get
            {
                return addressId;
            }
            set
            {
                addressId = value;
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
        public AddressRestaurant() { }

        public AddressRestaurant(int addressId, int restaurantId)
        {
            AddressId = addressId;
            RestaurantId = restaurantId;
        }
    }
}

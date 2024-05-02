using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Address
    {
        private int id;
        private int houseNo;
        private string street;
        private string city;
        private string area;
        private string state;
        private string country;
        private int pincode;
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
        public int HouseNo
        {
            get
            {
                return houseNo;
            }
            set
            {
                houseNo = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public int Pincode
        {
            get
            {
                return pincode;
            }
            set
            {
                pincode = value;
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
        public Address()
        {
            
        }

        public Address(int id, int houseNo, string street, string city, string area, string state, string country, int pincode, int userId)
        {
            Id = id;
            HouseNo = houseNo;
            Street = street;
            City = city;
            Area = area;
            State = state;
            Country = country;
            Pincode = pincode;
            UserId = userId;
            
        }
    }
}

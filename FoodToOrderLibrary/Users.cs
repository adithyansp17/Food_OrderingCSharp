using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrderLibrary
{
    public class Users : IPerson
    {
        public int id;
        public string firstName; 
        public string lastName;
        public string role;
        public string email;
        public string password;

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
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public Users() { }

        public Users(int id, string firstName, string lastName, string role, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Email = email;
            Password = password;
        }

        public void print()
        {
            if (Role == "admin")
            {
                Console.WriteLine("Welcome Admin!!\n");
            }
            else
            {
                Console.WriteLine("Logged in..\n\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class User
    {
        protected string name, username, password, phone;
        protected DateTime dateOfBirth;
        protected Gender gender;
        protected double weight, height;

        public string Name { 
            get 
            { 
                return name; 
            } 
            set
            {
                name = value;
            } 
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
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

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public double Weight
        {
            get
            { 
                return weight; 
            }

            set
            {
                weight = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

    }
}

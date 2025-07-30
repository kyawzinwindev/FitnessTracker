using FitnessTracker.Fitness_Tracker_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class User
    {
        protected string name, username, password;
        protected DateTime dateOfBirth;
        protected string gender;
        protected decimal weight, height;

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

        public string Gender
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

        public decimal Weight
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

        public decimal Height
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

        public static decimal TotalBurnedCalories()
        {
            var activitiesAdapter = new ActivityRecordsTableAdapter();
            var activitiesTable = activitiesAdapter.GetData();

            int currentUserID = Session.UserID;

            return  activitiesTable.Rows.Cast<DataRow>()
                .Where(row => Convert.ToInt32(row["UserID"]) == currentUserID)
                .Sum(row => Convert.ToInt32(row["BurnedCalories"]));

        }

    }
}

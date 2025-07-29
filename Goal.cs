using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class Goal
    {
        protected int userID;
        protected string title;
        protected decimal targetCalories;
        protected DateTime startDate, endDate;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public decimal TargetCalories
        {
            get { return targetCalories; }
            set { targetCalories = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}

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
        protected double targetCalories;
        protected DateTime startDate, endDate;
        protected bool isGoalAchieved;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public double TargetCalories
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

        public bool IsGoalAchieved
        {
            get { return isGoalAchieved; }
            set { isGoalAchieved = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class Activity
    {
        protected int userID;
        protected ActivityType activityType;
        protected DateTime activityDate;
        protected string metric1, metric2, metric3;
        protected double burnedCalories;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public ActivityType ActivityType
        {
            get { return activityType; }
            set { activityType = value; }
        }

        public DateTime ActivityDate
        {
            get { return activityDate; }
            set { activityDate = value; }
        }

        public string Metric1
        {
            get { return metric1; }
            set { metric1 = value; }
        }

        public string Metric2
        {
            get { return metric2; }
            set { metric2 = value; }
        }

        public string Metric3
        {
            get { return metric3; }
            set { metric3 = value; }
        }

        public double BurnedCalories
        {
            get { return burnedCalories; }
            set { burnedCalories = value; }
        }
    }
}

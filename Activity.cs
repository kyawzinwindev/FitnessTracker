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
        protected DateTime activityDateTime;
        protected decimal metric1, metric2, metric3;
        protected decimal burnedCalories;

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

        public DateTime ActivityDateTime
        {
            get { return activityDateTime; }
            set { activityDateTime = value; }
        }

        public decimal Metric1
        {
            get { return metric1; }
            set { metric1 = value; }
        }

        public decimal Metric2
        {
            get { return metric2; }
            set { metric2 = value; }
        }

        public decimal Metric3
        {
            get { return metric3; }
            set { metric3 = value; }
        }

        public decimal BurnedCalories
        {
            get { return burnedCalories; }
            set { burnedCalories = value; }
        }
    }
}

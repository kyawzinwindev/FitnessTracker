using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            comboActivityType.DataSource = Enum.GetValues(typeof(ActivityType));
        }

        private void comboActivityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityType selectedActivity = (ActivityType)comboActivityType.SelectedItem;

            switch (selectedActivity)
            {
                case ActivityType.Walking:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Distance (km):";
                    metric3lbl.Text = "Steps:";
                    break;

                case ActivityType.Swimming:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Average Heart Rate:";
                    metric3lbl.Text = "Laps:";
                    break;

                case ActivityType.Running:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Distance (km):";
                    metric3lbl.Text = "Pace (min/km):";
                    break;

                case ActivityType.Cycling:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Distance (km):";
                    metric3lbl.Text = "Average Speed (km/h):";
                    break;

                case ActivityType.JumpRope:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Intensity Level:";
                    metric3lbl.Text = "Total Jumps:";
                    break;

                case ActivityType.Yoga:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Difficulty Level:";
                    metric3lbl.Text = "Breathing Rate:";
                    break;
            }
        }

        private void createActivitySubmitBtn_Click(object sender, EventArgs e)
        {

        }

        private decimal CalculateBurnedCalories(ActivityType activityType, decimal Metric1, decimal Metric2, decimal Metric3)
        {
            switch (activityType)
            {
                case ActivityType.Walking:
                    return 3.5m * Metric1 + 50 * Metric2 + 0.04m * Metric3;

                case ActivityType.Swimming:
                    return 6 * Metric1 + 0.1m * Metric2 + 8 * Metric3;

                case ActivityType.Running:
                    return 6 * Metric1 + 60 * Metric2 + 0.75m * Metric3;

                case ActivityType.Cycling:
                    return 6 * Metric1 + 30 * Metric2 + 0.5m * Metric3;

                case ActivityType.JumpRope:
                    return 12 * Metric1 * Metric2 + 0.1m * Metric3;

                case ActivityType.Yoga:
                    return 3 * Metric1 + 0.05m * Metric3 * Metric1 * Metric2;

                default:
                    return 0;
            }
        }
    }
}

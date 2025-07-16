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
                    metric2lbl.Text = "Duration (min):";
                    metric1lbl.Text = "Distance (km):";
                    metric3lbl.Text = "Steps:";
                    break;

                case ActivityType.Swimming:
                    metric2lbl.Text = "Duration (min):";
                    metric1lbl.Text = "Average Heart Rate:";
                    metric3lbl.Text = "Laps:";
                    break;

                case ActivityType.Running:
                    metric2lbl.Text = "Duration (min):";
                    metric1lbl.Text = "Distance (km):";
                    metric3lbl.Text = "Pace (min/km):";
                    break;

                case ActivityType.Cycling:
                    metric2lbl.Text = "Duration (min):";
                    metric1lbl.Text = "Distance (km):";
                    metric3lbl.Text = "Average Speed (km/h):";
                    break;

                case ActivityType.JumpRope:
                    metric1lbl.Text = "Duration (min):";
                    metric3lbl.Text = "Intensity Level:";
                    metric2lbl.Text = "Total Jumps:";
                    break;

                case ActivityType.Yoga:
                    metric1lbl.Text = "Duration (min):";
                    metric2lbl.Text = "Difficulty Level:";
                    metric3lbl.Text = "Breathing Rate:";
                    break;
            }
        }
    }
}

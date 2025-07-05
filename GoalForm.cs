using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class GoalForm : Form
    {
        Fitness_Tracker_DataSetTableAdapters.GoalsTableAdapter gta = new Fitness_Tracker_DataSetTableAdapters.GoalsTableAdapter();
        public GoalForm()
        {
            InitializeComponent();
        }

        private void createGoalBtn_Click(object sender, EventArgs e)
        {
            if (txtTargetCalories.Text == "")
            {
                MessageBox.Show("Please Enter Your Target Calories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if ( !startDate.Checked )
            {
                MessageBox.Show("Please Enter Start Date of the Goal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!endDate.Checked)
            {
                MessageBox.Show("Please Enter End Date of the Goal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (startDate.Value >= endDate.Value)
            {
                MessageBox.Show("End Date must be after Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Goal newGoal = new Goal();
                newGoal.UserID = Session.UserID;
                newGoal.TargetCalories = decimal.Parse(txtTargetCalories.Text);
                newGoal.StartDate = startDate.Value;
                newGoal.EndDate = endDate.Value;
                newGoal.IsGoalAchieved = false;

                try
                {
                    int data = gta.Insert(newGoal.UserID, newGoal.TargetCalories, newGoal.StartDate, newGoal.EndDate, newGoal.IsGoalAchieved);

                    if (data > 0)
                    {
                        MessageBox.Show("Create Goal Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

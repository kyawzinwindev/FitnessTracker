using FitnessTracker.Fitness_Tracker_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class GoalUserControl : UserControl
    {
        Fitness_Tracker_DataSetTableAdapters.GoalsTableAdapter gta = new Fitness_Tracker_DataSetTableAdapters.GoalsTableAdapter();

        public GoalUserControl()
        {
            InitializeComponent();
        }

        private void saveGoalBtn_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please Enter Your Goal Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTargetCalories.Text == "")
            {
                MessageBox.Show("Please Enter Your Target Calories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!startDate.Checked)
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
                newGoal.Title = txtTitle.Text.Trim();
                newGoal.TargetCalories = decimal.Parse(txtTargetCalories.Text);
                newGoal.StartDate = startDate.Value;
                newGoal.EndDate = endDate.Value;

                if(saveGoalBtn.Tag == null)
                {
                    try
                    {
                        int data = gta.Insert(newGoal.UserID, newGoal.Title, newGoal.TargetCalories, newGoal.StartDate, newGoal.EndDate);

                        if (data > 0)
                        {
                            MessageBox.Show("Create Goal Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearGoalForm();
                            this.LoadGoals();
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
                else
                {
                    var table = gta.GetData();
                    var goalId = Convert.ToInt32(saveGoalBtn.Tag);

                    var row = table.FirstOrDefault(r => r.goalID == goalId); 

                    if (row != null)
                    {
                        row["Title"] = txtTitle.Text;
                        row["TargetCalories"] = Convert.ToInt32(txtTargetCalories.Text);
                        row["StartDate"] = startDate.Value;
                        row["EndDate"] = endDate.Value;

                        int data = gta.Update(row); 

                        if (data > 0)
                        {
                            MessageBox.Show("Update Goal Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearGoalForm();
                            this.LoadGoals();
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
            }
        }

        public void LoadGoals()
        {
            try
            {
                var goalsAdapter = new GoalsTableAdapter();
                var activitiesAdapter = new ActivityRecordsTableAdapter();

                var goalsTable = goalsAdapter.GetData();           
                var activitiesTable = activitiesAdapter.GetData();

                int currentUserID = Session.UserID;

                var displayData = goalsTable.Rows.Cast<DataRow>()
                    .Where(goalRow => Convert.ToInt32(goalRow["UserID"]) == currentUserID)
                    .Select(goalRow =>
                    {
                        DateTime start = Convert.ToDateTime(goalRow["StartDate"]);
                        DateTime end = Convert.ToDateTime(goalRow["EndDate"]);
                        int target = Convert.ToInt32(goalRow["TargetCalories"]);

                        var relatedActivities = activitiesTable.Rows.Cast<DataRow>()
                    .Where(a =>
                        Convert.ToInt32(a["UserID"]) == currentUserID &&
                        Convert.ToDateTime(a["ActivityDateTime"]).Date >= start.Date &&
                        Convert.ToDateTime(a["ActivityDateTime"]).Date <= end.Date
                    );

                        int totalBurned = relatedActivities.Sum(a => Convert.ToInt32(a["BurnedCalories"]));
                        double achieved = Math.Min((totalBurned / (double)target) * 100, 100);
                        string status = achieved >= 100 ? "Done" : "Not Yet";

                        return new
                        {
                            Title = goalRow["Title"].ToString(),
                            Start = start.Date,
                            End = end.Date,
                            Target = target,
                            Burned = totalBurned,
                            Achieved = $"{achieved:F1}%",
                            Status = status,
                            ID = Convert.ToInt32(goalRow["GoalID"])
                        };
                    }).ToList();


                dgvGoals.DataSource = displayData;
                dgvGoals.Columns["ID"].Visible = false;

                dgvGoals.Columns["Start"].HeaderText = "Start Date";
                dgvGoals.Columns["End"].HeaderText = "End Date";
                dgvGoals.Columns["Target"].HeaderText = "Target Calories";
                dgvGoals.Columns["Burned"].HeaderText = "Current BurnedCalories";
                dgvGoals.Columns["Achieved"].HeaderText = "Achieved %";
                dgvGoals.Columns["Status"].HeaderText = "Status";

                this.ClearGoalForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while clearing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void dgvGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGoals.Rows[e.RowIndex];

                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtTargetCalories.Text = row.Cells["Target"].Value.ToString();
                startDate.Value = Convert.ToDateTime(row.Cells["Start"].Value);
                endDate.Value = Convert.ToDateTime(row.Cells["End"].Value);


               saveGoalBtn.Tag = row.Cells["ID"].Value;
               deleteGoalBtn.Tag = row.Cells["ID"].Value;

                labelGoalHeading.Text = "Update Goal";
                saveGoalBtn.Text = "Update";
                deleteGoalBtn.Enabled = true;
            }
        }

        private void ClearGoalForm()
        {
            txtTitle.Clear();
            txtTargetCalories.Clear();
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today;

            saveGoalBtn.Tag = null;
            deleteGoalBtn.Tag = null;

            labelGoalHeading.Text = "Create New Goal";
            saveGoalBtn.Text = "Save";
            deleteGoalBtn.Enabled = false;
        }

        private void deleteGoalBtn_Click(object sender, EventArgs e)
        {
            var table = gta.GetData();
            int goalId = Convert.ToInt32(deleteGoalBtn.Tag);
            var row = table.FirstOrDefault(r => r.goalID == goalId);

            if(row != null)
            {
                gta.DeleteGoal(goalId, Session.UserID);

                MessageBox.Show("Delete Goal Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ClearGoalForm();
                this.LoadGoals();
            }
        }

        private void clearGoalBtn_Click(object sender, EventArgs e)
        {
            this.ClearGoalForm();
        }
    }
}

using FitnessTracker.Fitness_Tracker_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class ActivityRecordUserControl : UserControl
    {
        Fitness_Tracker_DataSetTableAdapters.ActivityRecordsTableAdapter ata = new Fitness_Tracker_DataSetTableAdapters.ActivityRecordsTableAdapter();

        public ActivityRecordUserControl()
        {
            InitializeComponent();

            this.LoadComboBoxData();

            comboActivityType.SelectedIndexChanged += comboActivityType_SelectedIndexChanged;
        }

        private void saveActivityRecordBtn_Click(object sender, EventArgs e)
        {
            if (comboActivityType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Activity Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (metric1.Text == "" || metric2.Text == "" || metric3.Text == "")
            {
                MessageBox.Show("Please Enter All Metric Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!activityTime.Checked)
            {
                MessageBox.Show("Please Enter Activity Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!activityDate.Checked)
            {
                MessageBox.Show("Please Enter Activity Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (activityDate.Value > DateTime.Now)
            {
                MessageBox.Show("Activity Date cannot be in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ActivityRecord newActivity = new ActivityRecord();
                newActivity.UserID = Session.UserID;
                newActivity.ActivityType = (ActivityType)comboActivityType.SelectedItem;
                newActivity.Metric1 = decimal.Parse(metric1.Text);
                newActivity.Metric2 = decimal.Parse(metric2.Text);
                newActivity.Metric3 = decimal.Parse(metric3.Text);
                DateTime date = activityDate.Value.Date;
                DateTime time = activityTime.Value;
                newActivity.ActivityDateTime = date + time.TimeOfDay;
                newActivity.BurnedCalories = this.CalculateBurnedCalories(newActivity.ActivityType, newActivity.Metric1, newActivity.Metric2, newActivity.Metric3);

                if(saveActivityRecordBtn.Tag == null)
                {
                    try
                    {
                        int data = ata.Insert(newActivity.UserID, newActivity.ActivityType.ToString(), newActivity.ActivityDateTime, newActivity.Metric1, newActivity.Metric2, newActivity.Metric3, newActivity.BurnedCalories);

                        if (data > 0)
                        {
                            decimal burnedCalories = CalculateBurnedCalories(newActivity.ActivityType, newActivity.Metric1, newActivity.Metric2, newActivity.Metric3);
                            MessageBox.Show($"Create Activity Successful! Burned Calories: {burnedCalories}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.ClearActivityRecordForm();
                            this.LoadActivityRecords();
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    var table = ata.GetData();
                    var activityRecordID = Convert.ToInt32(saveActivityRecordBtn.Tag);

                    var row = table.FirstOrDefault(r => r.activityRecordID == activityRecordID);

                    if (row != null)
                    {
                        row["ActivityType"] = newActivity.ActivityType;
                        row["Metric1"] = newActivity.Metric1;
                        row["Metric2"] = newActivity.Metric2;
                        row["Metric3"] = newActivity.Metric3;
                        row["Metric1"] = newActivity.Metric1;
                        row["ActivityDateTime"] = newActivity.ActivityDateTime;
                        row["BurnedCalories"] = this.CalculateBurnedCalories(newActivity.ActivityType, newActivity.Metric1, newActivity.Metric2, newActivity.Metric3);

                        int data = ata.Update(row);

                        if (data > 0)
                        {
                            MessageBox.Show("Update ActivityRecord Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearActivityRecordForm();
                            this.LoadActivityRecords();
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ClearActivityRecordForm()
        {
            metric1.Clear();
            metric2.Clear();
            metric3.Clear();
            activityDate.Value = DateTime.Now;
            activityTime.Value = DateTime.Now;

            saveActivityRecordBtn.Tag = null;
            deleteActivityRecordBtn.Tag = null;

            labelActivityRecordHeading.Text = "Create New Activity Record";
            saveActivityRecordBtn.Text = "Save";
            deleteActivityRecordBtn.Enabled = false;
        }


        public void LoadComboBoxData()
        {
            comboActivityType.DataSource = Enum.GetValues(typeof(ActivityType));
        }

        public void LoadActivityRecords()
        {
            try
            {
                var activitiesAdapter = new ActivityRecordsTableAdapter();

                var activitiesTable = activitiesAdapter.GetData();

                int currentUserID = Session.UserID;

                var displayData = activitiesTable.Rows.Cast<DataRow>()
                    .Where(activityRow => Convert.ToInt32(activityRow["UserID"]) == currentUserID)
                    .Select(activityRow =>
                    {
                        DateTime time = Convert.ToDateTime(activityRow["ActivityDateTime"]);
                        DateTime date = time.Date;

                        return new
                        {
                            Activity = activityRow["ActivityType"].ToString(),
                            BurnedCalories = Convert.ToInt32(activityRow["BurnedCalories"]),
                            Time = time,
                            Date = date,
                            Metric1 = Convert.ToDecimal(activityRow["Metric1"]),
                            Metric2 = Convert.ToDecimal(activityRow["Metric2"]),
                            Metric3 = Convert.ToDecimal(activityRow["Metric3"]),
                            ActivityDateTime = time,
                            ID = Convert.ToInt32(activityRow["ActivityRecordID"])
                        };
                    }).ToList();


                dgvActivityRecords.DataSource = displayData;
                dgvActivityRecords.Columns["ID"].Visible = false;
                dgvActivityRecords.Columns["Metric1"].Visible = false;
                dgvActivityRecords.Columns["Metric2"].Visible = false;
                dgvActivityRecords.Columns["Metric3"].Visible = false;
                dgvActivityRecords.Columns["ActivityDateTime"].Visible = false;

                dgvActivityRecords.Columns["Activity"].HeaderText = "Activity Name";
                dgvActivityRecords.Columns["BurnedCalories"].HeaderText = "Burned Calories";
                dgvActivityRecords.Columns["Time"].HeaderText = "Activity Time";
                dgvActivityRecords.Columns["Date"].HeaderText = "Activity Date";

                this.ClearActivityRecordForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while clearing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void comboActivityType_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvActivityRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvActivityRecords.Rows[e.RowIndex];

                string activityTypeStr = row.Cells["Activity"].Value.ToString();
                if (Enum.TryParse(activityTypeStr, out ActivityType activityType))
                {
                    comboActivityType.SelectedItem = activityType;
                    comboActivityType_SelectedIndexChanged(comboActivityType, EventArgs.Empty); 
                }
                metric1.Text = row.Cells["Metric1"].Value.ToString();
                metric2.Text = row.Cells["Metric2"].Value.ToString();
                metric3.Text = row.Cells["Metric3"].Value.ToString();

                DateTime activityDateTime = Convert.ToDateTime(row.Cells["ActivityDateTime"].Value);
                activityDate.Value = activityDateTime.Date;
                activityTime.Value = DateTime.Today.Add(activityDateTime.TimeOfDay);


                saveActivityRecordBtn.Tag = row.Cells["ID"].Value;
                deleteActivityRecordBtn.Tag = row.Cells["ID"].Value;

                labelActivityRecordHeading.Text = "Update Activity Record";
                saveActivityRecordBtn.Text = "Update";
                deleteActivityRecordBtn.Enabled = true;
            }
        }

        private void deleteActivityRecordBtn_Click(object sender, EventArgs e)
        {
            var table = ata.GetData();
            int activityRecordID = Convert.ToInt32(deleteActivityRecordBtn.Tag);
            var row = table.FirstOrDefault(r => r.activityRecordID == activityRecordID);

            if (row != null)
            {
                ata.DeleteActivityRecord(activityRecordID, Session.UserID);

                MessageBox.Show("Delete Activity Record Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ClearActivityRecordForm();
                this.LoadActivityRecords();
            }
        }

        private void clearActivityRecordBtn_Click(object sender, EventArgs e)
        {
            this.ClearActivityRecordForm();
        }
    }
}

namespace FitnessTracker
{
    partial class ActivityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboActivityType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metric1lbl = new System.Windows.Forms.Label();
            this.metric2lbl = new System.Windows.Forms.Label();
            this.metric3lbl = new System.Windows.Forms.Label();
            this.metric1 = new System.Windows.Forms.TextBox();
            this.metric2 = new System.Windows.Forms.TextBox();
            this.metric3 = new System.Windows.Forms.TextBox();
            this.createActivitySubmitBtn = new System.Windows.Forms.Button();
            this.activityTime = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.activityDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboActivityType
            // 
            this.comboActivityType.FormattingEnabled = true;
            this.comboActivityType.Location = new System.Drawing.Point(161, 29);
            this.comboActivityType.Name = "comboActivityType";
            this.comboActivityType.Size = new System.Drawing.Size(191, 21);
            this.comboActivityType.TabIndex = 0;
            this.comboActivityType.SelectedIndexChanged += new System.EventHandler(this.comboActivityType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Activity";
            // 
            // metric1lbl
            // 
            this.metric1lbl.AutoSize = true;
            this.metric1lbl.Location = new System.Drawing.Point(41, 93);
            this.metric1lbl.Name = "metric1lbl";
            this.metric1lbl.Size = new System.Drawing.Size(35, 13);
            this.metric1lbl.TabIndex = 2;
            this.metric1lbl.Text = "label2";
            // 
            // metric2lbl
            // 
            this.metric2lbl.AutoSize = true;
            this.metric2lbl.Location = new System.Drawing.Point(41, 148);
            this.metric2lbl.Name = "metric2lbl";
            this.metric2lbl.Size = new System.Drawing.Size(35, 13);
            this.metric2lbl.TabIndex = 3;
            this.metric2lbl.Text = "label2";
            // 
            // metric3lbl
            // 
            this.metric3lbl.AutoSize = true;
            this.metric3lbl.Location = new System.Drawing.Point(41, 203);
            this.metric3lbl.Name = "metric3lbl";
            this.metric3lbl.Size = new System.Drawing.Size(35, 13);
            this.metric3lbl.TabIndex = 4;
            this.metric3lbl.Text = "label2";
            // 
            // metric1
            // 
            this.metric1.Location = new System.Drawing.Point(161, 90);
            this.metric1.Name = "metric1";
            this.metric1.Size = new System.Drawing.Size(191, 20);
            this.metric1.TabIndex = 5;
            // 
            // metric2
            // 
            this.metric2.Location = new System.Drawing.Point(161, 145);
            this.metric2.Name = "metric2";
            this.metric2.Size = new System.Drawing.Size(191, 20);
            this.metric2.TabIndex = 6;
            // 
            // metric3
            // 
            this.metric3.Location = new System.Drawing.Point(161, 203);
            this.metric3.Name = "metric3";
            this.metric3.Size = new System.Drawing.Size(191, 20);
            this.metric3.TabIndex = 7;
            // 
            // createActivitySubmitBtn
            // 
            this.createActivitySubmitBtn.Location = new System.Drawing.Point(161, 359);
            this.createActivitySubmitBtn.Name = "createActivitySubmitBtn";
            this.createActivitySubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.createActivitySubmitBtn.TabIndex = 8;
            this.createActivitySubmitBtn.Text = "Create";
            this.createActivitySubmitBtn.UseVisualStyleBackColor = true;
            this.createActivitySubmitBtn.Click += new System.EventHandler(this.createActivitySubmitBtn_Click);
            // 
            // activityTime
            // 
            this.activityTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.activityTime.Location = new System.Drawing.Point(161, 256);
            this.activityTime.Name = "activityTime";
            this.activityTime.ShowUpDown = true;
            this.activityTime.Size = new System.Drawing.Size(191, 20);
            this.activityTime.TabIndex = 9;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(41, 256);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(67, 13);
            this.time.TabIndex = 10;
            this.time.Text = "Activity Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(41, 302);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(67, 13);
            this.date.TabIndex = 11;
            this.date.Text = "Activity Date";
            // 
            // activityDate
            // 
            this.activityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.activityDate.Location = new System.Drawing.Point(161, 302);
            this.activityDate.Name = "activityDate";
            this.activityDate.Size = new System.Drawing.Size(191, 20);
            this.activityDate.TabIndex = 12;
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 394);
            this.Controls.Add(this.activityDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.activityTime);
            this.Controls.Add(this.createActivitySubmitBtn);
            this.Controls.Add(this.metric3);
            this.Controls.Add(this.metric2);
            this.Controls.Add(this.metric1);
            this.Controls.Add(this.metric3lbl);
            this.Controls.Add(this.metric2lbl);
            this.Controls.Add(this.metric1lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboActivityType);
            this.Name = "ActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityForm";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboActivityType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label metric1lbl;
        private System.Windows.Forms.Label metric2lbl;
        private System.Windows.Forms.Label metric3lbl;
        private System.Windows.Forms.TextBox metric1;
        private System.Windows.Forms.TextBox metric2;
        private System.Windows.Forms.TextBox metric3;
        private System.Windows.Forms.Button createActivitySubmitBtn;
        private System.Windows.Forms.DateTimePicker activityTime;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker activityDate;
    }
}
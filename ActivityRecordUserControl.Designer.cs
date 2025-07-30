namespace FitnessTracker
{
    partial class ActivityRecordUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableActivityRecordLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvActivityRecords = new System.Windows.Forms.DataGridView();
            this.panelActivityRecordForm = new System.Windows.Forms.Panel();
            this.saveActivityRecordBtn = new System.Windows.Forms.Button();
            this.clearActivityRecordBtn = new System.Windows.Forms.Button();
            this.deleteActivityRecordBtn = new System.Windows.Forms.Button();
            this.activityDate = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.activityTime = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.Label();
            this.metric3 = new System.Windows.Forms.TextBox();
            this.metric3lbl = new System.Windows.Forms.Label();
            this.metric2 = new System.Windows.Forms.TextBox();
            this.metric2lbl = new System.Windows.Forms.Label();
            this.metric1 = new System.Windows.Forms.TextBox();
            this.comboActivityType = new System.Windows.Forms.ComboBox();
            this.metric1lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelActivityRecordHeading = new System.Windows.Forms.Label();
            this.tableActivityRecordLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityRecords)).BeginInit();
            this.panelActivityRecordForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableActivityRecordLayout
            // 
            this.tableActivityRecordLayout.AutoSize = true;
            this.tableActivityRecordLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableActivityRecordLayout.ColumnCount = 1;
            this.tableActivityRecordLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableActivityRecordLayout.Controls.Add(this.dgvActivityRecords, 0, 1);
            this.tableActivityRecordLayout.Controls.Add(this.panelActivityRecordForm, 0, 0);
            this.tableActivityRecordLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableActivityRecordLayout.Location = new System.Drawing.Point(0, 0);
            this.tableActivityRecordLayout.Name = "tableActivityRecordLayout";
            this.tableActivityRecordLayout.RowCount = 2;
            this.tableActivityRecordLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableActivityRecordLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableActivityRecordLayout.Size = new System.Drawing.Size(603, 668);
            this.tableActivityRecordLayout.TabIndex = 0;
            // 
            // dgvActivityRecords
            // 
            this.dgvActivityRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivityRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivityRecords.Location = new System.Drawing.Point(3, 452);
            this.dgvActivityRecords.MultiSelect = false;
            this.dgvActivityRecords.Name = "dgvActivityRecords";
            this.dgvActivityRecords.ReadOnly = true;
            this.dgvActivityRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityRecords.Size = new System.Drawing.Size(597, 213);
            this.dgvActivityRecords.TabIndex = 22;
            this.dgvActivityRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivityRecords_CellClick);
            // 
            // panelActivityRecordForm
            // 
            this.panelActivityRecordForm.AutoSize = true;
            this.panelActivityRecordForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelActivityRecordForm.Controls.Add(this.saveActivityRecordBtn);
            this.panelActivityRecordForm.Controls.Add(this.clearActivityRecordBtn);
            this.panelActivityRecordForm.Controls.Add(this.deleteActivityRecordBtn);
            this.panelActivityRecordForm.Controls.Add(this.activityDate);
            this.panelActivityRecordForm.Controls.Add(this.date);
            this.panelActivityRecordForm.Controls.Add(this.activityTime);
            this.panelActivityRecordForm.Controls.Add(this.time);
            this.panelActivityRecordForm.Controls.Add(this.metric3);
            this.panelActivityRecordForm.Controls.Add(this.metric3lbl);
            this.panelActivityRecordForm.Controls.Add(this.metric2);
            this.panelActivityRecordForm.Controls.Add(this.metric2lbl);
            this.panelActivityRecordForm.Controls.Add(this.metric1);
            this.panelActivityRecordForm.Controls.Add(this.comboActivityType);
            this.panelActivityRecordForm.Controls.Add(this.metric1lbl);
            this.panelActivityRecordForm.Controls.Add(this.label1);
            this.panelActivityRecordForm.Controls.Add(this.labelActivityRecordHeading);
            this.panelActivityRecordForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActivityRecordForm.Location = new System.Drawing.Point(3, 3);
            this.panelActivityRecordForm.Name = "panelActivityRecordForm";
            this.panelActivityRecordForm.Size = new System.Drawing.Size(597, 443);
            this.panelActivityRecordForm.TabIndex = 0;
            // 
            // saveActivityRecordBtn
            // 
            this.saveActivityRecordBtn.Location = new System.Drawing.Point(99, 412);
            this.saveActivityRecordBtn.Name = "saveActivityRecordBtn";
            this.saveActivityRecordBtn.Size = new System.Drawing.Size(80, 28);
            this.saveActivityRecordBtn.TabIndex = 21;
            this.saveActivityRecordBtn.Text = "Save";
            this.saveActivityRecordBtn.UseVisualStyleBackColor = true;
            this.saveActivityRecordBtn.Click += new System.EventHandler(this.saveActivityRecordBtn_Click);
            // 
            // clearActivityRecordBtn
            // 
            this.clearActivityRecordBtn.Location = new System.Drawing.Point(315, 412);
            this.clearActivityRecordBtn.Name = "clearActivityRecordBtn";
            this.clearActivityRecordBtn.Size = new System.Drawing.Size(80, 28);
            this.clearActivityRecordBtn.TabIndex = 19;
            this.clearActivityRecordBtn.Text = "Clear";
            this.clearActivityRecordBtn.UseVisualStyleBackColor = true;
            this.clearActivityRecordBtn.Click += new System.EventHandler(this.clearActivityRecordBtn_Click);
            // 
            // deleteActivityRecordBtn
            // 
            this.deleteActivityRecordBtn.Location = new System.Drawing.Point(208, 412);
            this.deleteActivityRecordBtn.Name = "deleteActivityRecordBtn";
            this.deleteActivityRecordBtn.Size = new System.Drawing.Size(80, 28);
            this.deleteActivityRecordBtn.TabIndex = 18;
            this.deleteActivityRecordBtn.Text = "Delete";
            this.deleteActivityRecordBtn.UseVisualStyleBackColor = true;
            this.deleteActivityRecordBtn.Click += new System.EventHandler(this.deleteActivityRecordBtn_Click);
            // 
            // activityDate
            // 
            this.activityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.activityDate.Location = new System.Drawing.Point(40, 369);
            this.activityDate.Name = "activityDate";
            this.activityDate.Size = new System.Drawing.Size(390, 20);
            this.activityDate.TabIndex = 16;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(37, 353);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(67, 13);
            this.date.TabIndex = 14;
            this.date.Text = "Activity Date";
            // 
            // activityTime
            // 
            this.activityTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.activityTime.Location = new System.Drawing.Point(40, 310);
            this.activityTime.Name = "activityTime";
            this.activityTime.ShowUpDown = true;
            this.activityTime.Size = new System.Drawing.Size(390, 20);
            this.activityTime.TabIndex = 13;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(37, 294);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(67, 13);
            this.time.TabIndex = 11;
            this.time.Text = "Activity Time";
            // 
            // metric3
            // 
            this.metric3.Location = new System.Drawing.Point(40, 254);
            this.metric3.Name = "metric3";
            this.metric3.Size = new System.Drawing.Size(390, 20);
            this.metric3.TabIndex = 10;
            // 
            // metric3lbl
            // 
            this.metric3lbl.AutoSize = true;
            this.metric3lbl.Location = new System.Drawing.Point(37, 238);
            this.metric3lbl.Name = "metric3lbl";
            this.metric3lbl.Size = new System.Drawing.Size(35, 13);
            this.metric3lbl.TabIndex = 9;
            this.metric3lbl.Text = "label2";
            // 
            // metric2
            // 
            this.metric2.Location = new System.Drawing.Point(40, 196);
            this.metric2.Name = "metric2";
            this.metric2.Size = new System.Drawing.Size(390, 20);
            this.metric2.TabIndex = 8;
            // 
            // metric2lbl
            // 
            this.metric2lbl.AutoSize = true;
            this.metric2lbl.Location = new System.Drawing.Point(37, 177);
            this.metric2lbl.Name = "metric2lbl";
            this.metric2lbl.Size = new System.Drawing.Size(35, 13);
            this.metric2lbl.TabIndex = 7;
            this.metric2lbl.Text = "label2";
            // 
            // metric1
            // 
            this.metric1.Location = new System.Drawing.Point(40, 133);
            this.metric1.Name = "metric1";
            this.metric1.Size = new System.Drawing.Size(390, 20);
            this.metric1.TabIndex = 6;
            // 
            // comboActivityType
            // 
            this.comboActivityType.FormattingEnabled = true;
            this.comboActivityType.Location = new System.Drawing.Point(40, 71);
            this.comboActivityType.Name = "comboActivityType";
            this.comboActivityType.Size = new System.Drawing.Size(390, 21);
            this.comboActivityType.TabIndex = 5;
            // 
            // metric1lbl
            // 
            this.metric1lbl.AutoSize = true;
            this.metric1lbl.Location = new System.Drawing.Point(37, 117);
            this.metric1lbl.Name = "metric1lbl";
            this.metric1lbl.Size = new System.Drawing.Size(35, 13);
            this.metric1lbl.TabIndex = 4;
            this.metric1lbl.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Activity";
            // 
            // labelActivityRecordHeading
            // 
            this.labelActivityRecordHeading.AutoSize = true;
            this.labelActivityRecordHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelActivityRecordHeading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivityRecordHeading.Location = new System.Drawing.Point(0, 0);
            this.labelActivityRecordHeading.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.labelActivityRecordHeading.Name = "labelActivityRecordHeading";
            this.labelActivityRecordHeading.Size = new System.Drawing.Size(253, 25);
            this.labelActivityRecordHeading.TabIndex = 1;
            this.labelActivityRecordHeading.Text = "Create New Activity Record";
            this.labelActivityRecordHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActivityRecordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableActivityRecordLayout);
            this.Name = "ActivityRecordUserControl";
            this.Size = new System.Drawing.Size(603, 668);
            this.tableActivityRecordLayout.ResumeLayout(false);
            this.tableActivityRecordLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityRecords)).EndInit();
            this.panelActivityRecordForm.ResumeLayout(false);
            this.panelActivityRecordForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableActivityRecordLayout;
        private System.Windows.Forms.Panel panelActivityRecordForm;
        private System.Windows.Forms.Label labelActivityRecordHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label metric1lbl;
        private System.Windows.Forms.ComboBox comboActivityType;
        private System.Windows.Forms.TextBox metric1;
        private System.Windows.Forms.Label metric2lbl;
        private System.Windows.Forms.TextBox metric2;
        private System.Windows.Forms.Label metric3lbl;
        private System.Windows.Forms.TextBox metric3;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.DateTimePicker activityTime;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker activityDate;
        private System.Windows.Forms.Button clearActivityRecordBtn;
        private System.Windows.Forms.Button deleteActivityRecordBtn;
        private System.Windows.Forms.Button saveActivityRecordBtn;
        private System.Windows.Forms.DataGridView dgvActivityRecords;
    }
}

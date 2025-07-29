namespace FitnessTracker
{
    partial class GoalUserControl
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
            this.tableGoalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.panelGoalForm = new System.Windows.Forms.Panel();
            this.clearGoalBtn = new System.Windows.Forms.Button();
            this.deleteGoalBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveGoalBtn = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.txtTargetCalories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoalHeading = new System.Windows.Forms.Label();
            this.tableGoalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            this.panelGoalForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableGoalLayout
            // 
            this.tableGoalLayout.ColumnCount = 1;
            this.tableGoalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGoalLayout.Controls.Add(this.dgvGoals, 0, 1);
            this.tableGoalLayout.Controls.Add(this.panelGoalForm, 0, 0);
            this.tableGoalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGoalLayout.Location = new System.Drawing.Point(0, 0);
            this.tableGoalLayout.Name = "tableGoalLayout";
            this.tableGoalLayout.RowCount = 2;
            this.tableGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGoalLayout.Size = new System.Drawing.Size(603, 416);
            this.tableGoalLayout.TabIndex = 0;
            // 
            // dgvGoals
            // 
            this.dgvGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoals.Location = new System.Drawing.Point(3, 340);
            this.dgvGoals.MultiSelect = false;
            this.dgvGoals.Name = "dgvGoals";
            this.dgvGoals.ReadOnly = true;
            this.dgvGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoals.Size = new System.Drawing.Size(597, 73);
            this.dgvGoals.TabIndex = 16;
            this.dgvGoals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoals_CellClick);
            // 
            // panelGoalForm
            // 
            this.panelGoalForm.AutoSize = true;
            this.panelGoalForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGoalForm.Controls.Add(this.clearGoalBtn);
            this.panelGoalForm.Controls.Add(this.deleteGoalBtn);
            this.panelGoalForm.Controls.Add(this.label5);
            this.panelGoalForm.Controls.Add(this.saveGoalBtn);
            this.panelGoalForm.Controls.Add(this.endDate);
            this.panelGoalForm.Controls.Add(this.txtTargetCalories);
            this.panelGoalForm.Controls.Add(this.label4);
            this.panelGoalForm.Controls.Add(this.startDate);
            this.panelGoalForm.Controls.Add(this.label2);
            this.panelGoalForm.Controls.Add(this.txtTitle);
            this.panelGoalForm.Controls.Add(this.label1);
            this.panelGoalForm.Controls.Add(this.labelGoalHeading);
            this.panelGoalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoalForm.Location = new System.Drawing.Point(3, 3);
            this.panelGoalForm.Name = "panelGoalForm";
            this.panelGoalForm.Size = new System.Drawing.Size(597, 331);
            this.panelGoalForm.TabIndex = 0;
            // 
            // clearGoalBtn
            // 
            this.clearGoalBtn.Location = new System.Drawing.Point(316, 300);
            this.clearGoalBtn.Name = "clearGoalBtn";
            this.clearGoalBtn.Size = new System.Drawing.Size(80, 28);
            this.clearGoalBtn.TabIndex = 18;
            this.clearGoalBtn.Text = "Clear";
            this.clearGoalBtn.UseVisualStyleBackColor = true;
            this.clearGoalBtn.Click += new System.EventHandler(this.clearGoalBtn_Click);
            // 
            // deleteGoalBtn
            // 
            this.deleteGoalBtn.Location = new System.Drawing.Point(197, 300);
            this.deleteGoalBtn.Name = "deleteGoalBtn";
            this.deleteGoalBtn.Size = new System.Drawing.Size(80, 28);
            this.deleteGoalBtn.TabIndex = 17;
            this.deleteGoalBtn.Text = "Delete";
            this.deleteGoalBtn.UseVisualStyleBackColor = true;
            this.deleteGoalBtn.Click += new System.EventHandler(this.deleteGoalBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Date";
            // 
            // saveGoalBtn
            // 
            this.saveGoalBtn.Location = new System.Drawing.Point(80, 300);
            this.saveGoalBtn.Name = "saveGoalBtn";
            this.saveGoalBtn.Size = new System.Drawing.Size(80, 28);
            this.saveGoalBtn.TabIndex = 15;
            this.saveGoalBtn.Text = "Save";
            this.saveGoalBtn.UseVisualStyleBackColor = true;
            this.saveGoalBtn.Click += new System.EventHandler(this.saveGoalBtn_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(32, 256);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(402, 20);
            this.endDate.TabIndex = 14;
            // 
            // txtTargetCalories
            // 
            this.txtTargetCalories.Location = new System.Drawing.Point(32, 121);
            this.txtTargetCalories.Name = "txtTargetCalories";
            this.txtTargetCalories.Size = new System.Drawing.Size(402, 20);
            this.txtTargetCalories.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Target Calories";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(32, 184);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(402, 20);
            this.startDate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Date";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(32, 61);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(402, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // labelGoalHeading
            // 
            this.labelGoalHeading.AutoSize = true;
            this.labelGoalHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGoalHeading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalHeading.Location = new System.Drawing.Point(0, 0);
            this.labelGoalHeading.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.labelGoalHeading.Name = "labelGoalHeading";
            this.labelGoalHeading.Size = new System.Drawing.Size(160, 25);
            this.labelGoalHeading.TabIndex = 0;
            this.labelGoalHeading.Text = "Create New Goal";
            this.labelGoalHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableGoalLayout);
            this.Name = "GoalUserControl";
            this.Size = new System.Drawing.Size(603, 416);
            this.tableGoalLayout.ResumeLayout(false);
            this.tableGoalLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            this.panelGoalForm.ResumeLayout(false);
            this.panelGoalForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableGoalLayout;
        private System.Windows.Forms.Panel panelGoalForm;
        private System.Windows.Forms.Label labelGoalHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetCalories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button saveGoalBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.Button clearGoalBtn;
        private System.Windows.Forms.Button deleteGoalBtn;
    }
}

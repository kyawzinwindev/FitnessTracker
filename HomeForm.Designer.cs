namespace FitnessTracker
{
    partial class HomeForm
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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.goalPageBtn = new System.Windows.Forms.Button();
            this.activityRecordPageBtn = new System.Windows.Forms.Button();
            this.profilePageBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.welcomeNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableMain.Controls.Add(this.panel1, 0, 0);
            this.tableMain.Controls.Add(this.label1, 0, 3);
            this.tableMain.Controls.Add(this.panelMain, 0, 2);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 4;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.Size = new System.Drawing.Size(800, 450);
            this.tableMain.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.goalPageBtn);
            this.flowLayoutPanel1.Controls.Add(this.activityRecordPageBtn);
            this.flowLayoutPanel1.Controls.Add(this.profilePageBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // goalPageBtn
            // 
            this.goalPageBtn.Location = new System.Drawing.Point(3, 3);
            this.goalPageBtn.Name = "goalPageBtn";
            this.goalPageBtn.Size = new System.Drawing.Size(120, 40);
            this.goalPageBtn.TabIndex = 0;
            this.goalPageBtn.Text = "Goal";
            this.goalPageBtn.UseVisualStyleBackColor = true;
            this.goalPageBtn.Click += new System.EventHandler(this.goalPageBtn_Click);
            // 
            // activityRecordPageBtn
            // 
            this.activityRecordPageBtn.Location = new System.Drawing.Point(129, 3);
            this.activityRecordPageBtn.Name = "activityRecordPageBtn";
            this.activityRecordPageBtn.Size = new System.Drawing.Size(120, 40);
            this.activityRecordPageBtn.TabIndex = 1;
            this.activityRecordPageBtn.Text = "ActivityRecord";
            this.activityRecordPageBtn.UseVisualStyleBackColor = true;
            this.activityRecordPageBtn.Click += new System.EventHandler(this.activityRecordPageBtn_Click);
            // 
            // profilePageBtn
            // 
            this.profilePageBtn.Location = new System.Drawing.Point(255, 3);
            this.profilePageBtn.Name = "profilePageBtn";
            this.profilePageBtn.Size = new System.Drawing.Size(120, 40);
            this.profilePageBtn.TabIndex = 2;
            this.profilePageBtn.Text = "Profile";
            this.profilePageBtn.UseVisualStyleBackColor = true;
            this.profilePageBtn.Click += new System.EventHandler(this.profilePageBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.todayDateLabel);
            this.panel1.Controls.Add(this.welcomeNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 68);
            this.panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(710, 22);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.AutoSize = true;
            this.todayDateLabel.Location = new System.Drawing.Point(11, 42);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(35, 13);
            this.todayDateLabel.TabIndex = 1;
            this.todayDateLabel.Text = "label1";
            // 
            // welcomeNameLabel
            // 
            this.welcomeNameLabel.AutoSize = true;
            this.welcomeNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeNameLabel.Location = new System.Drawing.Point(9, 6);
            this.welcomeNameLabel.Name = "welcomeNameLabel";
            this.welcomeNameLabel.Size = new System.Drawing.Size(65, 25);
            this.welcomeNameLabel.TabIndex = 0;
            this.welcomeNameLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Small steps everyday lead to big results.";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 137);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(794, 296);
            this.panelMain.TabIndex = 4;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableMain);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitnessTracker - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.Label welcomeNameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button goalPageBtn;
        private System.Windows.Forms.Button activityRecordPageBtn;
        private System.Windows.Forms.Button profilePageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
    }
}
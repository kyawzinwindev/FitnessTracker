namespace FitnessTracker
{
    partial class MainForm
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
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerFormBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.activityMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goalMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGoalFormBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // registerFormBtn
            // 
            this.registerFormBtn.Name = "registerFormBtn";
            this.registerFormBtn.Size = new System.Drawing.Size(61, 20);
            this.registerFormBtn.Text = "&Register";
            this.registerFormBtn.Click += new System.EventHandler(this.registerFormBtn_Click);
            // 
            // loginFormBtn
            // 
            this.loginFormBtn.Name = "loginFormBtn";
            this.loginFormBtn.Size = new System.Drawing.Size(49, 20);
            this.loginFormBtn.Text = "&Login";
            this.loginFormBtn.Click += new System.EventHandler(this.loginFormBtn_Click);
            // 
            // activityMenuBtn
            // 
            this.activityMenuBtn.Name = "activityMenuBtn";
            this.activityMenuBtn.Size = new System.Drawing.Size(59, 20);
            this.activityMenuBtn.Text = "&Activity";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(57, 20);
            this.logoutBtn.Text = "&Logout";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginFormBtn,
            this.registerFormBtn,
            this.goalMenuBtn,
            this.activityMenuBtn,
            this.logoutBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goalMenuBtn
            // 
            this.goalMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.createGoalFormBtn});
            this.goalMenuBtn.Name = "goalMenuBtn";
            this.goalMenuBtn.Size = new System.Drawing.Size(43, 20);
            this.goalMenuBtn.Text = "&Goal";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // createGoalFormBtn
            // 
            this.createGoalFormBtn.Name = "createGoalFormBtn";
            this.createGoalFormBtn.Size = new System.Drawing.Size(180, 22);
            this.createGoalFormBtn.Text = "Create New Goal";
            this.createGoalFormBtn.Click += new System.EventHandler(this.createGoalFormBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessTracker.Properties.Resources.main_page_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fitness Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerFormBtn;
        private System.Windows.Forms.ToolStripMenuItem loginFormBtn;
        private System.Windows.Forms.ToolStripMenuItem activityMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem logoutBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goalMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGoalFormBtn;
    }
}


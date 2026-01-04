namespace UniversityRegistration
{
    partial class StudentForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btn_finalize = new Button();
            btn_register = new Button();
            lb_registeredCourses = new ListBox();
            clb_availableCourses = new CheckedListBox();
            lbl_welcome = new Label();
            lbl_stats = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(567, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, refreshToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(113, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(113, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_finalize);
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(lb_registeredCourses);
            groupBox1.Controls.Add(clb_availableCourses);
            groupBox1.Location = new Point(12, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 396);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Registration";
            // 
            // btn_finalize
            // 
            btn_finalize.Location = new Point(312, 359);
            btn_finalize.Name = "btn_finalize";
            btn_finalize.Size = new Size(202, 31);
            btn_finalize.TabIndex = 7;
            btn_finalize.Text = "Save Changes / Finalize";
            btn_finalize.UseVisualStyleBackColor = true;
            btn_finalize.Click += btn_finalize_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(237, 162);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(69, 102);
            btn_register.TabIndex = 6;
            btn_register.Text = ">>";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // lb_registeredCourses
            // 
            lb_registeredCourses.FormattingEnabled = true;
            lb_registeredCourses.ItemHeight = 15;
            lb_registeredCourses.Location = new Point(312, 34);
            lb_registeredCourses.Name = "lb_registeredCourses";
            lb_registeredCourses.Size = new Size(202, 319);
            lb_registeredCourses.TabIndex = 5;
            // 
            // clb_availableCourses
            // 
            clb_availableCourses.FormattingEnabled = true;
            clb_availableCourses.Location = new Point(29, 34);
            clb_availableCourses.Name = "clb_availableCourses";
            clb_availableCourses.Size = new Size(202, 346);
            clb_availableCourses.TabIndex = 4;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Location = new Point(41, 41);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(38, 15);
            lbl_welcome.TabIndex = 5;
            lbl_welcome.Text = "label1";
            // 
            // lbl_stats
            // 
            lbl_stats.AutoSize = true;
            lbl_stats.Location = new Point(41, 83);
            lbl_stats.Name = "lbl_stats";
            lbl_stats.Size = new Size(38, 15);
            lbl_stats.TabIndex = 6;
            lbl_stats.Text = "label2";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 562);
            Controls.Add(lbl_stats);
            Controls.Add(lbl_welcome);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btn_finalize;
        private Button btn_register;
        private ListBox lb_registeredCourses;
        private CheckedListBox clb_availableCourses;
        private Label lbl_welcome;
        private Label lbl_stats;
    }
}
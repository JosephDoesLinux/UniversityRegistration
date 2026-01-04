namespace UniversityRegistration
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txt_description = new TextBox();
            label10 = new Label();
            btn_clearCourses = new Button();
            btn_add = new Button();
            cmb_majors = new ComboBox();
            label4 = new Label();
            txt_title = new TextBox();
            txt_code = new TextBox();
            nud_credits = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            dgv_courses = new DataGridView();
            course_id = new DataGridViewTextBoxColumn();
            course_code = new DataGridViewTextBoxColumn();
            course_title = new DataGridViewTextBoxColumn();
            course_description = new DataGridViewTextBoxColumn();
            credits = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            btn_updateMajor = new Button();
            btn_addMajor = new Button();
            btn_deleteMajor = new Button();
            label6 = new Label();
            txt_majorName = new TextBox();
            lv_majors = new ListView();
            major_id = new ColumnHeader();
            major_name = new ColumnHeader();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            btn_userDelete = new Button();
            btn_userUpdate = new Button();
            btn_userAdd = new Button();
            groupBox4 = new GroupBox();
            rb_student = new RadioButton();
            rb_admin = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmb_userMajor = new ComboBox();
            txt_userPass = new TextBox();
            txt_userName = new TextBox();
            dgv_users = new DataGridView();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_credits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
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
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 411);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btn_delete);
            tabPage1.Controls.Add(btn_update);
            tabPage1.Controls.Add(dgv_courses);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Courses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btn_clearCourses);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(cmb_majors);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_title);
            groupBox1.Controls.Add(txt_code);
            groupBox1.Controls.Add(nud_credits);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 261);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Details";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(90, 87);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(184, 107);
            txt_description.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 90);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 20;
            label10.Text = "Description:";
            // 
            // btn_clearCourses
            // 
            btn_clearCourses.Location = new Point(152, 232);
            btn_clearCourses.Name = "btn_clearCourses";
            btn_clearCourses.Size = new Size(60, 23);
            btn_clearCourses.TabIndex = 19;
            btn_clearCourses.Text = "Clear";
            btn_clearCourses.UseVisualStyleBackColor = true;
            btn_clearCourses.Click += btn_clearCourses_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(218, 232);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(56, 23);
            btn_add.TabIndex = 18;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cmb_majors
            // 
            cmb_majors.FormattingEnabled = true;
            cmb_majors.Location = new Point(90, 200);
            cmb_majors.Name = "cmb_majors";
            cmb_majors.Size = new Size(184, 23);
            cmb_majors.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 203);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Major:";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(90, 55);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(184, 23);
            txt_title.TabIndex = 15;
            // 
            // txt_code
            // 
            txt_code.Location = new Point(90, 22);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(184, 23);
            txt_code.TabIndex = 14;
            // 
            // nud_credits
            // 
            nud_credits.Location = new Point(90, 232);
            nud_credits.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nud_credits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_credits.Name = "nud_credits";
            nud_credits.Size = new Size(58, 23);
            nud_credits.TabIndex = 13;
            nud_credits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 236);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "Credits:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 11;
            label2.Text = "Course Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 10;
            label1.Text = "Course Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 22);
            label5.Name = "label5";
            label5.Size = new Size(183, 15);
            label5.TabIndex = 15;
            label5.Text = "Select an item to update/remove:";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(606, 349);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(687, 349);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // dgv_courses
            // 
            dgv_courses.AllowUserToAddRows = false;
            dgv_courses.AllowUserToDeleteRows = false;
            dgv_courses.AllowUserToOrderColumns = true;
            dgv_courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Columns.AddRange(new DataGridViewColumn[] { course_id, course_code, course_title, course_description, credits });
            dgv_courses.Location = new Point(292, 40);
            dgv_courses.MultiSelect = false;
            dgv_courses.Name = "dgv_courses";
            dgv_courses.ReadOnly = true;
            dgv_courses.RowHeadersVisible = false;
            dgv_courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_courses.Size = new Size(470, 303);
            dgv_courses.TabIndex = 12;
            dgv_courses.CellClick += dgv_courses_CellClick;
            // 
            // course_id
            // 
            course_id.DataPropertyName = "course_id";
            course_id.HeaderText = "ID";
            course_id.Name = "course_id";
            course_id.ReadOnly = true;
            // 
            // course_code
            // 
            course_code.DataPropertyName = "course_code";
            course_code.HeaderText = "Code";
            course_code.Name = "course_code";
            course_code.ReadOnly = true;
            // 
            // course_title
            // 
            course_title.DataPropertyName = "course_title";
            course_title.HeaderText = "Title";
            course_title.Name = "course_title";
            course_title.ReadOnly = true;
            // 
            // course_description
            // 
            course_description.DataPropertyName = "course_description";
            course_description.HeaderText = "Description";
            course_description.Name = "course_description";
            course_description.ReadOnly = true;
            // 
            // credits
            // 
            credits.DataPropertyName = "credits";
            credits.HeaderText = "Credits";
            credits.Name = "credits";
            credits.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(lv_majors);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Majors";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_updateMajor);
            groupBox2.Controls.Add(btn_addMajor);
            groupBox2.Controls.Add(btn_deleteMajor);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_majorName);
            groupBox2.Location = new Point(603, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(159, 371);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit/Add Majors";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(8, 273);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(145, 63);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_updateMajor
            // 
            btn_updateMajor.Location = new Point(6, 204);
            btn_updateMajor.Name = "btn_updateMajor";
            btn_updateMajor.Size = new Size(145, 63);
            btn_updateMajor.TabIndex = 4;
            btn_updateMajor.Text = "Update";
            btn_updateMajor.UseVisualStyleBackColor = true;
            btn_updateMajor.Click += btn_updateMajor_Click;
            // 
            // btn_addMajor
            // 
            btn_addMajor.Location = new Point(6, 66);
            btn_addMajor.Name = "btn_addMajor";
            btn_addMajor.Size = new Size(145, 63);
            btn_addMajor.TabIndex = 3;
            btn_addMajor.Text = "Add";
            btn_addMajor.UseVisualStyleBackColor = true;
            btn_addMajor.Click += btn_addMajor_Click;
            // 
            // btn_deleteMajor
            // 
            btn_deleteMajor.Location = new Point(6, 135);
            btn_deleteMajor.Name = "btn_deleteMajor";
            btn_deleteMajor.Size = new Size(145, 63);
            btn_deleteMajor.TabIndex = 2;
            btn_deleteMajor.Text = "Delete";
            btn_deleteMajor.UseVisualStyleBackColor = true;
            btn_deleteMajor.Click += btn_deleteMajor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 1;
            label6.Text = "Major:";
            // 
            // txt_majorName
            // 
            txt_majorName.Location = new Point(6, 37);
            txt_majorName.Name = "txt_majorName";
            txt_majorName.Size = new Size(145, 23);
            txt_majorName.TabIndex = 0;
            // 
            // lv_majors
            // 
            lv_majors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lv_majors.Columns.AddRange(new ColumnHeader[] { major_id, major_name });
            lv_majors.FullRowSelect = true;
            lv_majors.GridLines = true;
            lv_majors.Location = new Point(6, 3);
            lv_majors.Name = "lv_majors";
            lv_majors.Size = new Size(591, 374);
            lv_majors.TabIndex = 0;
            lv_majors.UseCompatibleStateImageBehavior = false;
            lv_majors.View = View.Details;
            lv_majors.SelectedIndexChanged += lv_majors_SelectedIndexChanged;
            // 
            // major_id
            // 
            major_id.Tag = "ID";
            major_id.Width = 50;
            // 
            // major_name
            // 
            major_name.Tag = "Major Name";
            major_name.Width = 200;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(dgv_users);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 383);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Accounts";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_userDelete);
            groupBox3.Controls.Add(btn_userUpdate);
            groupBox3.Controls.Add(btn_userAdd);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cmb_userMajor);
            groupBox3.Controls.Add(txt_userPass);
            groupBox3.Controls.Add(txt_userName);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(756, 115);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Manage Students and Admins";
            // 
            // btn_userDelete
            // 
            btn_userDelete.Location = new Point(639, 23);
            btn_userDelete.Name = "btn_userDelete";
            btn_userDelete.Size = new Size(103, 80);
            btn_userDelete.TabIndex = 9;
            btn_userDelete.Text = "Delete";
            btn_userDelete.UseVisualStyleBackColor = true;
            btn_userDelete.Click += btn_userDelete_Click;
            // 
            // btn_userUpdate
            // 
            btn_userUpdate.Location = new Point(530, 23);
            btn_userUpdate.Name = "btn_userUpdate";
            btn_userUpdate.Size = new Size(103, 80);
            btn_userUpdate.TabIndex = 8;
            btn_userUpdate.Text = "Update";
            btn_userUpdate.UseVisualStyleBackColor = true;
            btn_userUpdate.Click += btn_userUpdate_Click;
            // 
            // btn_userAdd
            // 
            btn_userAdd.Location = new Point(421, 22);
            btn_userAdd.Name = "btn_userAdd";
            btn_userAdd.Size = new Size(103, 80);
            btn_userAdd.TabIndex = 7;
            btn_userAdd.Text = "Add";
            btn_userAdd.UseVisualStyleBackColor = true;
            btn_userAdd.Click += btn_userAdd_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rb_student);
            groupBox4.Controls.Add(rb_admin);
            groupBox4.Location = new Point(282, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(121, 85);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "SelectedUser Role:";
            // 
            // rb_student
            // 
            rb_student.AutoSize = true;
            rb_student.Checked = true;
            rb_student.Location = new Point(27, 45);
            rb_student.Name = "rb_student";
            rb_student.Size = new Size(66, 19);
            rb_student.TabIndex = 1;
            rb_student.TabStop = true;
            rb_student.Text = "Student";
            rb_student.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            rb_admin.AutoSize = true;
            rb_admin.Location = new Point(27, 20);
            rb_admin.Name = "rb_admin";
            rb_admin.Size = new Size(61, 19);
            rb_admin.TabIndex = 0;
            rb_admin.Text = "Admin";
            rb_admin.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 83);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 5;
            label9.Text = "Major:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 4;
            label8.Text = "User Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 21);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 3;
            label7.Text = "Full Name:";
            // 
            // cmb_userMajor
            // 
            cmb_userMajor.FormattingEnabled = true;
            cmb_userMajor.Location = new Point(98, 80);
            cmb_userMajor.Name = "cmb_userMajor";
            cmb_userMajor.Size = new Size(178, 23);
            cmb_userMajor.TabIndex = 2;
            // 
            // txt_userPass
            // 
            txt_userPass.Location = new Point(98, 51);
            txt_userPass.Name = "txt_userPass";
            txt_userPass.Size = new Size(178, 23);
            txt_userPass.TabIndex = 1;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(97, 18);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(178, 23);
            txt_userName.TabIndex = 0;
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToAddRows = false;
            dgv_users.AllowUserToDeleteRows = false;
            dgv_users.AllowUserToOrderColumns = true;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(6, 127);
            dgv_users.MultiSelect = false;
            dgv_users.Name = "dgv_users";
            dgv_users.ReadOnly = true;
            dgv_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_users.Size = new Size(756, 250);
            dgv_users.TabIndex = 0;
            dgv_users.CellClick += dgv_users_CellClick;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminPanelForm";
            Text = "AdminPanelForm";
            Load += AdminPanelForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_credits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Button btn_delete;
        private Button btn_update;
        private DataGridView dgv_courses;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btn_clearCourses;
        private Button btn_add;
        private ComboBox cmb_majors;
        private Label label4;
        private TextBox txt_title;
        private TextBox txt_code;
        private NumericUpDown nud_credits;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lv_majors;
        private ColumnHeader major_id;
        private ColumnHeader major_name;
        private GroupBox groupBox2;
        private Button btn_addMajor;
        private Button btn_deleteMajor;
        private Label label6;
        private TextBox txt_majorName;
        private Button btn_updateMajor;
        private Button btn_clear;
        private GroupBox groupBox3;
        private ComboBox cmb_userMajor;
        private TextBox txt_userPass;
        private TextBox txt_userName;
        private DataGridView dgv_users;
        private GroupBox groupBox4;
        private RadioButton rb_student;
        private RadioButton rb_admin;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btn_userDelete;
        private Button btn_userUpdate;
        private Button btn_userAdd;
        private TextBox txt_description;
        private Label label10;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn course_code;
        private DataGridViewTextBoxColumn course_title;
        private DataGridViewTextBoxColumn course_description;
        private DataGridViewTextBoxColumn credits;
    }
}
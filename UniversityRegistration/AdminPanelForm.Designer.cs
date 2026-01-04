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
            button2 = new Button();
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
            col_id = new DataGridViewTextBoxColumn();
            col_code = new DataGridViewTextBoxColumn();
            col_title = new DataGridViewTextBoxColumn();
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
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_credits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            pictureBox1.Size = new Size(280, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(cmb_majors);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_title);
            groupBox1.Controls.Add(txt_code);
            groupBox1.Controls.Add(nud_credits);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 246);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Details";
            // 
            // button2
            // 
            button2.Location = new Point(43, 174);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 19;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(148, 174);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(95, 23);
            btn_add.TabIndex = 18;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cmb_majors
            // 
            cmb_majors.FormattingEnabled = true;
            cmb_majors.Location = new Point(122, 116);
            cmb_majors.Name = "cmb_majors";
            cmb_majors.Size = new Size(121, 23);
            cmb_majors.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 119);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Major:";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(122, 83);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(121, 23);
            txt_title.TabIndex = 15;
            // 
            // txt_code
            // 
            txt_code.Location = new Point(122, 50);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(121, 23);
            txt_code.TabIndex = 14;
            // 
            // nud_credits
            // 
            nud_credits.Location = new Point(185, 145);
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
            label3.Location = new Point(122, 147);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "Credits:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 86);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 11;
            label2.Text = "Course Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 53);
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
            dgv_courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Columns.AddRange(new DataGridViewColumn[] { col_id, col_code, col_title });
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
            // col_id
            // 
            col_id.DataPropertyName = "course_id";
            col_id.HeaderText = "ID";
            col_id.Name = "col_id";
            col_id.ReadOnly = true;
            // 
            // col_code
            // 
            col_code.DataPropertyName = "course_code";
            col_code.HeaderText = "Code";
            col_code.Name = "col_code";
            col_code.ReadOnly = true;
            // 
            // col_title
            // 
            col_title.DataPropertyName = "course_code";
            col_title.HeaderText = "Title";
            col_title.Name = "col_title";
            col_title.ReadOnly = true;
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 383);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Accounts";
            tabPage3.UseVisualStyleBackColor = true;
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
        private Button button2;
        private Button btn_add;
        private ComboBox cmb_majors;
        private Label label4;
        private TextBox txt_title;
        private TextBox txt_code;
        private NumericUpDown nud_credits;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_code;
        private DataGridViewTextBoxColumn col_title;
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
    }
}
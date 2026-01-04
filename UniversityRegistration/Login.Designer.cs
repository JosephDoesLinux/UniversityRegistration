namespace UniversityRegistration
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            link_ums = new LinkLabel();
            btn_login = new Button();
            txt_password = new TextBox();
            txt_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(244, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(link_ums);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 152);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Credentials for Registration";
            // 
            // link_ums
            // 
            link_ums.AutoSize = true;
            link_ums.Location = new Point(6, 127);
            link_ums.Name = "link_ums";
            link_ums.Size = new Size(97, 15);
            link_ums.TabIndex = 7;
            link_ums.TabStop = true;
            link_ums.Text = "LIU UMS Website";
            link_ums.LinkClicked += link_ums_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(137, 123);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(81, 64);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(131, 23);
            txt_password.TabIndex = 1;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(81, 22);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(131, 23);
            txt_id.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 67);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Password  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "ID               :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 176);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btn_login;
        private TextBox txt_password;
        private TextBox txt_id;
        private Label label2;
        private Label label1;
        private LinkLabel link_ums;
    }
}


namespace Student_Attendance_Form
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.linkLabel_ForgetPass = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton_Login = new FontAwesome.Sharp.IconButton();
            this.iconButton_SignUp = new FontAwesome.Sharp.IconButton();
            this.iconButton_EyeClose = new FontAwesome.Sharp.IconButton();
            this.iconButton_EyeOpen = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Username.Location = new System.Drawing.Point(47, 174);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(81, 21);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Password.Location = new System.Drawing.Point(47, 236);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(76, 21);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(47, 210);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(265, 23);
            this.textBox_Username.TabIndex = 3;
            this.textBox_Username.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Username_Validating);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(47, 270);
            this.textBox_Password.MaxLength = 32;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(265, 23);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Password_Validating);
            // 
            // linkLabel_ForgetPass
            // 
            this.linkLabel_ForgetPass.AutoSize = true;
            this.linkLabel_ForgetPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_ForgetPass.Location = new System.Drawing.Point(124, 377);
            this.linkLabel_ForgetPass.Name = "linkLabel_ForgetPass";
            this.linkLabel_ForgetPass.Size = new System.Drawing.Size(117, 20);
            this.linkLabel_ForgetPass.TabIndex = 7;
            this.linkLabel_ForgetPass.TabStop = true;
            this.linkLabel_ForgetPass.Text = "Forget Password";
            this.linkLabel_ForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ForgetPass_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButton_Login);
            this.groupBox1.Controls.Add(this.iconButton_SignUp);
            this.groupBox1.Controls.Add(this.iconButton_EyeClose);
            this.groupBox1.Controls.Add(this.iconButton_EyeOpen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel_ForgetPass);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 437);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // iconButton_Login
            // 
            this.iconButton_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton_Login.FlatAppearance.BorderSize = 0;
            this.iconButton_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Login.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton_Login.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconButton_Login.IconColor = System.Drawing.Color.Teal;
            this.iconButton_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Login.IconSize = 30;
            this.iconButton_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Login.Location = new System.Drawing.Point(205, 318);
            this.iconButton_Login.Name = "iconButton_Login";
            this.iconButton_Login.Size = new System.Drawing.Size(107, 37);
            this.iconButton_Login.TabIndex = 13;
            this.iconButton_Login.Text = "Login";
            this.iconButton_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Login.UseVisualStyleBackColor = false;
            this.iconButton_Login.Click += new System.EventHandler(this.iconButton_Login_Click);
            // 
            // iconButton_SignUp
            // 
            this.iconButton_SignUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton_SignUp.FlatAppearance.BorderSize = 0;
            this.iconButton_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_SignUp.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton_SignUp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton_SignUp.IconColor = System.Drawing.Color.Teal;
            this.iconButton_SignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_SignUp.IconSize = 30;
            this.iconButton_SignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_SignUp.Location = new System.Drawing.Point(47, 318);
            this.iconButton_SignUp.Name = "iconButton_SignUp";
            this.iconButton_SignUp.Size = new System.Drawing.Size(107, 37);
            this.iconButton_SignUp.TabIndex = 12;
            this.iconButton_SignUp.Text = "Sign up";
            this.iconButton_SignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_SignUp.UseVisualStyleBackColor = false;
            this.iconButton_SignUp.Click += new System.EventHandler(this.iconButton_SignUp_Click);
            // 
            // iconButton_EyeClose
            // 
            this.iconButton_EyeClose.BackColor = System.Drawing.Color.White;
            this.iconButton_EyeClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton_EyeClose.FlatAppearance.BorderSize = 0;
            this.iconButton_EyeClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton_EyeClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton_EyeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_EyeClose.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorProvider1.SetIconAlignment(this.iconButton_EyeClose, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.iconButton_EyeClose.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconButton_EyeClose.IconColor = System.Drawing.Color.Black;
            this.iconButton_EyeClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_EyeClose.IconSize = 25;
            this.iconButton_EyeClose.Location = new System.Drawing.Point(278, 276);
            this.iconButton_EyeClose.Name = "iconButton_EyeClose";
            this.iconButton_EyeClose.Size = new System.Drawing.Size(30, 15);
            this.iconButton_EyeClose.TabIndex = 11;
            this.iconButton_EyeClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_EyeClose.UseVisualStyleBackColor = false;
            this.iconButton_EyeClose.Click += new System.EventHandler(this.iconButton_EyeClose_Click);
            // 
            // iconButton_EyeOpen
            // 
            this.iconButton_EyeOpen.BackColor = System.Drawing.Color.White;
            this.iconButton_EyeOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton_EyeOpen.FlatAppearance.BorderSize = 0;
            this.iconButton_EyeOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton_EyeOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton_EyeOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_EyeOpen.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorProvider1.SetIconAlignment(this.iconButton_EyeOpen, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.iconButton_EyeOpen.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton_EyeOpen.IconColor = System.Drawing.Color.Black;
            this.iconButton_EyeOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_EyeOpen.IconSize = 25;
            this.iconButton_EyeOpen.Location = new System.Drawing.Point(278, 276);
            this.iconButton_EyeOpen.Name = "iconButton_EyeOpen";
            this.iconButton_EyeOpen.Size = new System.Drawing.Size(30, 15);
            this.iconButton_EyeOpen.TabIndex = 10;
            this.iconButton_EyeOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_EyeOpen.UseVisualStyleBackColor = false;
            this.iconButton_EyeOpen.Click += new System.EventHandler(this.iconButton_EyeOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(328, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log into your account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.LinkLabel linkLabel_ForgetPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton_EyeOpen;
        private FontAwesome.Sharp.IconButton iconButton_EyeClose;
        private FontAwesome.Sharp.IconButton iconButton_SignUp;
        private FontAwesome.Sharp.IconButton iconButton_Login;
    }
}


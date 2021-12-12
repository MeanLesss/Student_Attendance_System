
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
            this.button_Login = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_EyesClose = new System.Windows.Forms.Button();
            this.button_EyesOpen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 22);
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
            this.label_Username.Location = new System.Drawing.Point(47, 182);
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
            this.label_Password.Location = new System.Drawing.Point(47, 241);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(76, 21);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(47, 210);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(246, 23);
            this.textBox_Username.TabIndex = 3;
            this.textBox_Username.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Username_Validating);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(47, 270);
            this.textBox_Password.MaxLength = 32;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(246, 23);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            this.textBox_Password.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Password_Validating);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.MintCream;
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Location = new System.Drawing.Point(186, 318);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(107, 23);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.MintCream;
            this.button_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SignUp.Location = new System.Drawing.Point(47, 318);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(107, 23);
            this.button_SignUp.TabIndex = 6;
            this.button_SignUp.Text = "Sign up";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(123, 376);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Login);
            this.groupBox1.Controls.Add(this.button_SignUp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.button_EyesClose);
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Controls.Add(this.button_EyesOpen);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 437);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log into your account";
            // 
            // button_EyesClose
            // 
            this.button_EyesClose.BackColor = System.Drawing.Color.Transparent;
            this.button_EyesClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_EyesClose.BackgroundImage")));
            this.button_EyesClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_EyesClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_EyesClose.FlatAppearance.BorderSize = 0;
            this.button_EyesClose.Location = new System.Drawing.Point(263, 270);
            this.button_EyesClose.Name = "button_EyesClose";
            this.button_EyesClose.Size = new System.Drawing.Size(30, 23);
            this.button_EyesClose.TabIndex = 2;
            this.button_EyesClose.UseVisualStyleBackColor = false;
            this.button_EyesClose.Click += new System.EventHandler(this.button_EyesClose_Click);
            // 
            // button_EyesOpen
            // 
            this.button_EyesOpen.BackColor = System.Drawing.Color.Transparent;
            this.button_EyesOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_EyesOpen.BackgroundImage")));
            this.button_EyesOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_EyesOpen.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_EyesOpen.FlatAppearance.BorderSize = 0;
            this.button_EyesOpen.Location = new System.Drawing.Point(263, 269);
            this.button_EyesOpen.Name = "button_EyesOpen";
            this.button_EyesOpen.Size = new System.Drawing.Size(30, 23);
            this.button_EyesOpen.TabIndex = 1;
            this.button_EyesOpen.UseVisualStyleBackColor = false;
            this.button_EyesOpen.Click += new System.EventHandler(this.button_EyesOpen_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_EyesOpen;
        private System.Windows.Forms.Button button_EyesClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}


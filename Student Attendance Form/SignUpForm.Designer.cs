
namespace Student_Attendance_Form
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Question = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SecureAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.textBox_NewUsername = new System.Windows.Forms.TextBox();
            this.label_NewUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox_Question = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Question);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button_Register);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.label_Question);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_SecureAnswer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox1.Controls.Add(this.label_PhoneNumber);
            this.groupBox1.Controls.Add(this.textBox_ConfirmPassword);
            this.groupBox1.Controls.Add(this.label_ConfirmPassword);
            this.groupBox1.Controls.Add(this.textBox_NewPassword);
            this.groupBox1.Controls.Add(this.label_NewPassword);
            this.groupBox1.Controls.Add(this.textBox_NewUsername);
            this.groupBox1.Controls.Add(this.label_NewUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(328, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_Register
            // 
            this.button_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Register.BackColor = System.Drawing.Color.LightYellow;
            this.button_Register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Register.FlatAppearance.BorderSize = 0;
            this.button_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Register.ForeColor = System.Drawing.Color.Purple;
            this.button_Register.Location = new System.Drawing.Point(206, 363);
            this.button_Register.Margin = new System.Windows.Forms.Padding(0);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(107, 35);
            this.button_Register.TabIndex = 18;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Pink;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.Navy;
            this.button_Cancel.Location = new System.Drawing.Point(33, 363);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(107, 35);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Location = new System.Drawing.Point(152, 21);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(139, 15);
            this.label_Question.TabIndex = 16;
            this.label_Question.Text = "(What is your pet name?)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(314, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "*";
            // 
            // textBox_SecureAnswer
            // 
            this.textBox_SecureAnswer.Location = new System.Drawing.Point(33, 324);
            this.textBox_SecureAnswer.MaxLength = 32;
            this.textBox_SecureAnswer.Name = "textBox_SecureAnswer";
            this.textBox_SecureAnswer.Size = new System.Drawing.Size(280, 23);
            this.textBox_SecureAnswer.TabIndex = 14;
            this.textBox_SecureAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_SecureAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_SecureAnswer_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Security question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(152, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(210, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(152, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(154, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(33, 263);
            this.textBox_PhoneNumber.MaxLength = 12;
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(280, 23);
            this.textBox_PhoneNumber.TabIndex = 8;
            this.textBox_PhoneNumber.TextChanged += new System.EventHandler(this.textBox_PhoneNumber_TextChanged);
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PhoneNumber_KeyPress);
            this.textBox_PhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_PhoneNumber_Validating);
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PhoneNumber.Location = new System.Drawing.Point(33, 229);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(113, 21);
            this.label_PhoneNumber.TabIndex = 7;
            this.label_PhoneNumber.Text = "Phone number";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(33, 203);
            this.textBox_ConfirmPassword.MaxLength = 32;
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(280, 23);
            this.textBox_ConfirmPassword.TabIndex = 6;
            this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
            this.textBox_ConfirmPassword.TextChanged += new System.EventHandler(this.textBox_ConfirmPassword_TextChanged);
            this.textBox_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ConfirmPassword_Validating);
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ConfirmPassword.Location = new System.Drawing.Point(33, 169);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(171, 21);
            this.label_ConfirmPassword.TabIndex = 5;
            this.label_ConfirmPassword.Text = "Confirm new password";
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(33, 143);
            this.textBox_NewPassword.MaxLength = 32;
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(280, 23);
            this.textBox_NewPassword.TabIndex = 4;
            this.textBox_NewPassword.UseSystemPasswordChar = true;
            this.textBox_NewPassword.TextChanged += new System.EventHandler(this.textBox_NewPassword_TextChanged);
            this.textBox_NewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_NewPassword_Validating);
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NewPassword.Location = new System.Drawing.Point(33, 109);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(113, 21);
            this.label_NewPassword.TabIndex = 3;
            this.label_NewPassword.Text = "New password";
            // 
            // textBox_NewUsername
            // 
            this.textBox_NewUsername.Location = new System.Drawing.Point(33, 83);
            this.textBox_NewUsername.Name = "textBox_NewUsername";
            this.textBox_NewUsername.Size = new System.Drawing.Size(280, 23);
            this.textBox_NewUsername.TabIndex = 2;
            this.textBox_NewUsername.TextChanged += new System.EventHandler(this.textBox_NewUsername_TextChanged);
            // 
            // label_NewUsername
            // 
            this.label_NewUsername.AutoSize = true;
            this.label_NewUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NewUsername.Location = new System.Drawing.Point(36, 49);
            this.label_NewUsername.Name = "label_NewUsername";
            this.label_NewUsername.Size = new System.Drawing.Size(115, 21);
            this.label_NewUsername.TabIndex = 1;
            this.label_NewUsername.Text = "New username";
            this.label_NewUsername.Click += new System.EventHandler(this.label_NewUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-8, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox_Question
            // 
            this.comboBox_Question.FormattingEnabled = true;
            this.comboBox_Question.Items.AddRange(new object[] {
            "sadsa",
            "sd",
            "fsaf",
            "asf"});
            this.comboBox_Question.Location = new System.Drawing.Point(169, 291);
            this.comboBox_Question.Name = "comboBox_Question";
            this.comboBox_Question.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Question.TabIndex = 20;
            this.comboBox_Question.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpForm_FormClosed);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NewUsername;
        private System.Windows.Forms.TextBox textBox_NewUsername;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SecureAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Question;
    }
}
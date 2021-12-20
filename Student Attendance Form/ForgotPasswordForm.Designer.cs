
namespace Student_Attendance_Form
{
    partial class ForgotPasswordForm
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
            this.panel_ByPhoneNumber = new System.Windows.Forms.Panel();
            this.button_CheckPhone = new System.Windows.Forms.Button();
            this.textBox_OldPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_UsernamePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_PhoneNumber = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel_NewPassword = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ConformPassword = new System.Windows.Forms.TextBox();
            this.panel_SecurityQuestion = new System.Windows.Forms.Panel();
            this.button_CheckSecure = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_UsernameSecure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_ByPhoneNumber.SuspendLayout();
            this.panel_NewPassword.SuspendLayout();
            this.panel_SecurityQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ByPhoneNumber
            // 
            this.panel_ByPhoneNumber.Controls.Add(this.button_CheckPhone);
            this.panel_ByPhoneNumber.Controls.Add(this.textBox_OldPhoneNumber);
            this.panel_ByPhoneNumber.Controls.Add(this.label3);
            this.panel_ByPhoneNumber.Controls.Add(this.textBox_UsernamePhone);
            this.panel_ByPhoneNumber.Controls.Add(this.label2);
            this.panel_ByPhoneNumber.Location = new System.Drawing.Point(13, 69);
            this.panel_ByPhoneNumber.Name = "panel_ByPhoneNumber";
            this.panel_ByPhoneNumber.Size = new System.Drawing.Size(352, 369);
            this.panel_ByPhoneNumber.TabIndex = 0;
            // 
            // button_CheckPhone
            // 
            this.button_CheckPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_CheckPhone.FlatAppearance.BorderSize = 0;
            this.button_CheckPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_CheckPhone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_CheckPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CheckPhone.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CheckPhone.Location = new System.Drawing.Point(196, 222);
            this.button_CheckPhone.Name = "button_CheckPhone";
            this.button_CheckPhone.Size = new System.Drawing.Size(115, 32);
            this.button_CheckPhone.TabIndex = 4;
            this.button_CheckPhone.Text = "Check";
            this.button_CheckPhone.UseVisualStyleBackColor = false;
            this.button_CheckPhone.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // textBox_OldPhoneNumber
            // 
            this.textBox_OldPhoneNumber.Location = new System.Drawing.Point(20, 166);
            this.textBox_OldPhoneNumber.Name = "textBox_OldPhoneNumber";
            this.textBox_OldPhoneNumber.Size = new System.Drawing.Size(291, 23);
            this.textBox_OldPhoneNumber.TabIndex = 3;
            this.textBox_OldPhoneNumber.TextChanged += new System.EventHandler(this.textBox_OldPhoneNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // textBox_UsernamePhone
            // 
            this.textBox_UsernamePhone.Location = new System.Drawing.Point(20, 107);
            this.textBox_UsernamePhone.Name = "textBox_UsernamePhone";
            this.textBox_UsernamePhone.Size = new System.Drawing.Size(291, 23);
            this.textBox_UsernamePhone.TabIndex = 1;
            this.textBox_UsernamePhone.TextChanged += new System.EventHandler(this.textBox_UsernamePhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose one of the recover option";
            // 
            // radioButton_PhoneNumber
            // 
            this.radioButton_PhoneNumber.AutoSize = true;
            this.radioButton_PhoneNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton_PhoneNumber.Location = new System.Drawing.Point(51, 47);
            this.radioButton_PhoneNumber.Name = "radioButton_PhoneNumber";
            this.radioButton_PhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.radioButton_PhoneNumber.TabIndex = 2;
            this.radioButton_PhoneNumber.Text = "Phone number";
            this.radioButton_PhoneNumber.UseVisualStyleBackColor = true;
            this.radioButton_PhoneNumber.CheckedChanged += new System.EventHandler(this.radioButton_PhoneNumber_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton1.Location = new System.Drawing.Point(205, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Security question";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel_NewPassword
            // 
            this.panel_NewPassword.Controls.Add(this.button1);
            this.panel_NewPassword.Controls.Add(this.label6);
            this.panel_NewPassword.Controls.Add(this.label4);
            this.panel_NewPassword.Controls.Add(this.textBox_NewPassword);
            this.panel_NewPassword.Controls.Add(this.label5);
            this.panel_NewPassword.Controls.Add(this.textBox_ConformPassword);
            this.panel_NewPassword.Location = new System.Drawing.Point(12, 66);
            this.panel_NewPassword.Name = "panel_NewPassword";
            this.panel_NewPassword.Size = new System.Drawing.Size(353, 366);
            this.panel_NewPassword.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(179, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Change password";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(30, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Input your new password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(30, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm new password";
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(30, 175);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(291, 23);
            this.textBox_NewPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(30, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "New password";
            // 
            // textBox_ConformPassword
            // 
            this.textBox_ConformPassword.Location = new System.Drawing.Point(30, 234);
            this.textBox_ConformPassword.Name = "textBox_ConformPassword";
            this.textBox_ConformPassword.Size = new System.Drawing.Size(291, 23);
            this.textBox_ConformPassword.TabIndex = 11;
            // 
            // panel_SecurityQuestion
            // 
            this.panel_SecurityQuestion.Controls.Add(this.button_CheckSecure);
            this.panel_SecurityQuestion.Controls.Add(this.label8);
            this.panel_SecurityQuestion.Controls.Add(this.textBox_Answer);
            this.panel_SecurityQuestion.Controls.Add(this.label7);
            this.panel_SecurityQuestion.Controls.Add(this.textBox_UsernameSecure);
            this.panel_SecurityQuestion.Location = new System.Drawing.Point(12, 69);
            this.panel_SecurityQuestion.Name = "panel_SecurityQuestion";
            this.panel_SecurityQuestion.Size = new System.Drawing.Size(364, 366);
            this.panel_SecurityQuestion.TabIndex = 5;
            // 
            // button_CheckSecure
            // 
            this.button_CheckSecure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_CheckSecure.FlatAppearance.BorderSize = 0;
            this.button_CheckSecure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_CheckSecure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_CheckSecure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CheckSecure.Font = new System.Drawing.Font("Thirteen Pixel Fonts", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CheckSecure.Location = new System.Drawing.Point(197, 206);
            this.button_CheckSecure.Name = "button_CheckSecure";
            this.button_CheckSecure.Size = new System.Drawing.Size(115, 32);
            this.button_CheckSecure.TabIndex = 5;
            this.button_CheckSecure.Text = "Check";
            this.button_CheckSecure.UseVisualStyleBackColor = false;
            this.button_CheckSecure.Click += new System.EventHandler(this.button_ConfirmSecure_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(21, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "What is your pet name?";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(21, 163);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(291, 23);
            this.textBox_Answer.TabIndex = 2;
            this.textBox_Answer.TextChanged += new System.EventHandler(this.textBox_Answer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(21, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Username";
            // 
            // textBox_UsernameSecure
            // 
            this.textBox_UsernameSecure.Location = new System.Drawing.Point(21, 107);
            this.textBox_UsernameSecure.Name = "textBox_UsernameSecure";
            this.textBox_UsernameSecure.Size = new System.Drawing.Size(291, 23);
            this.textBox_UsernameSecure.TabIndex = 0;
            this.textBox_UsernameSecure.TextChanged += new System.EventHandler(this.textBox_UsernameSecure_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(346, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton_PhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_SecurityQuestion);
            this.Controls.Add(this.panel_ByPhoneNumber);
            this.Controls.Add(this.panel_NewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.panel_ByPhoneNumber.ResumeLayout(false);
            this.panel_ByPhoneNumber.PerformLayout();
            this.panel_NewPassword.ResumeLayout(false);
            this.panel_NewPassword.PerformLayout();
            this.panel_SecurityQuestion.ResumeLayout(false);
            this.panel_SecurityQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ByPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox_OldPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_UsernamePhone;
        private System.Windows.Forms.Panel panel_NewPassword;
        private System.Windows.Forms.TextBox textBox_ConformPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_CheckPhone;
        private System.Windows.Forms.Panel panel_SecurityQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_UsernameSecure;
        private System.Windows.Forms.Button button_CheckSecure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Form
{
    public partial class SignUpForm : Form
    {
        private ManaageTeacher manageTeacher= new ManaageTeacher();
        public SignUpForm()
        {
            InitializeComponent();

        }
        private void textBox_NewUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_NewUsername.Text))
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void textBox_NewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_NewPassword.Text))
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void textBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ConfirmPassword.Text))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void textBox_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PhoneNumber.Text))
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SecureAnswer.Text))
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult = DialogResult.Cancel;
            Login_Form logInForm = new Login_Form();
            logInForm.Show(); 
            /*this.Close();*/
        }

        private void label_NewUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_NewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_NewPassword.Text))
            {
                e.Cancel = false;
                textBox_NewPassword.Focus();
                errorProvider1.SetError(textBox_NewPassword, "Please input your password!");
            }
            else
            {
                if (textBox_NewPassword.Text.Length < 3)
                {
                    e.Cancel = false;
                    //errorProvider1.SetError(textBox_Password, null);
                    errorProvider1.SetError(textBox_NewPassword, "The password need at least 3 characters.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox_NewPassword, null);
                }
            }
        }

        private void textBox_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ConfirmPassword.Text))
            {
                e.Cancel = false;
                textBox_ConfirmPassword.Focus();
                errorProvider1.SetError(textBox_ConfirmPassword, "Please input your password!");
            }
            else
            {
                if (textBox_ConfirmPassword.Text != textBox_NewPassword.Text)
                {
                    e.Cancel = false;
                    //errorProvider1.SetError(textBox_Password, null);
                    errorProvider1.SetError(textBox_ConfirmPassword, "The password does NOT match!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox_ConfirmPassword, null);
                }
            }
        }

        private void textBox_SecureAnswer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SecureAnswer.Text))
            {
                e.Cancel = false;
                textBox_SecureAnswer.Focus();
                errorProvider1.SetError(textBox_SecureAnswer, "Please input your answer!");
            }
            else
            {
                if (textBox_SecureAnswer.Text.Length < 3)
                {
                    e.Cancel = false;
                    //errorProvider1.SetError(textBox_Password, null);
                    errorProvider1.SetError(textBox_SecureAnswer, "The answer need at least 3 characters.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox_SecureAnswer, null);
                }
            }
        }

        private void textBox_PhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PhoneNumber.Text))
            {
                e.Cancel = false;
                textBox_PhoneNumber.Focus();
                errorProvider1.SetError(textBox_PhoneNumber, "Please input your phone number");
            }
            else
            {
                if (textBox_PhoneNumber.Text.Length < 9)
                {
                    e.Cancel = false;
                    //errorProvider1.SetError(textBox_Password, null);
                    errorProvider1.SetError(textBox_PhoneNumber, "Phone number digit at least 9-12.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox_PhoneNumber, null);
                }
            }
        }

        private void textBox_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox_PhoneNumber, "Input number only");
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {

            //need validation

            manageTeacher.Teachers.Add(new Teacher
            {
                Username = textBox_NewUsername.Text,
                Password = textBox_NewPassword.Text,
                Phone = textBox_PhoneNumber.Text,
                QuestionNo = comboBox_Question.SelectedIndex,
                Answer = textBox_SecureAnswer.Text

            }) ;
            manageTeacher.SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            manageTeacher.LoadData();
        }
    }
}

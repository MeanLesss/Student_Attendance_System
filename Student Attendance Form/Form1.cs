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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_EyesClose_Click(object sender, EventArgs e)
        {
            if(textBox_Password.PasswordChar == '*')
            {
                button_EyesOpen.BringToFront();
                textBox_Password.PasswordChar = '\0';
            }
        }

        private void button_EyesOpen_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == '\0')
            {
                button_EyesClose.BringToFront();
                textBox_Password.PasswordChar = '*';
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Password.PasswordChar < 3)
            {
                
            }
        }

        private void textBox_Username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Username.Text))
            {
                e.Cancel = false;
                textBox_Username.Focus();
                errorProvider1.SetError(textBox_Username, "Please input your username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_Username, null);
            }
        }
        private void textBox_Password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                e.Cancel = false;
                textBox_Password.Focus();
                errorProvider1.SetError(textBox_Password, "Please input your password");
            }
            else
            {
                if (textBox_Password.Text.Length < 3)
                {
                    e.Cancel = false;
                    //errorProvider1.SetError(textBox_Password, null);
                    errorProvider1.SetError(textBox_Password, "The password need at least 3 characters.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox_Password, null);
                }

            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //need authentication first
            //check if the username and password match the file


            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //open other form
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //open sign up form
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //open forget password form
            }
        }
    }
}

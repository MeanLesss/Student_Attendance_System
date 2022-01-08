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
        private Teacher teacher = new Teacher();
        private ManaageTeacher manageTeacher = new ManaageTeacher();
        private bool correct;
        public bool IsLogin { get; set; } = false;


        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manageTeacher.LoadData();
        }

        private void iconButton_EyeClose_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == '*')
            {
                iconButton_EyeOpen.BringToFront();
                textBox_Password.PasswordChar = '\0';
            }
        }

        private void iconButton_EyeOpen_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == '\0')
            {
                iconButton_EyeClose.BringToFront();
                textBox_Password.PasswordChar = '*';
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

        private bool Authentication()
        {
            manageTeacher.LoadData();


            Teacher teacher = manageTeacher.Teachers.Find(
            t => t.Username == textBox_Username.Text &&
            t.Username == textBox_Password.Text);
            correct = true;

            if(textBox_Username.Text == teacher.Username &&
                textBox_Password.Text
             == teacher.Username)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
            
            return correct;

        }

        private void button_Login_Click(object sender, EventArgs e)
        {

        }

        private void iconButton_SignUp_Click(object sender, EventArgs e)
        {
            manageTeacher.LoadData();
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_ForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();

            manageTeacher.LoadData();
            this.Hide();
            forgotPasswordForm.Show();
        }

        private void iconButton_Login_Click(object sender, EventArgs e)
        {
            Teacher teacher = manageTeacher.Teachers.Find(
                t => t.Username == textBox_Username.Text &&
                t.Password == textBox_Password.Text);

            textBox_Username.Clear();
            textBox_Password.Clear();

            if (teacher != null)
            {
                IsLogin = true;
                new Dashboard(teacher).Show();
                this.Hide();
            }else
            {
                MessageBox.Show("User not found!", "Log in failed");
            }
        }
    }
}

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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            panel_NewPassword.Visible = false;
            radioButton_PhoneNumber.Checked = true;
        }


        private void textBox_OldPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_UsernamePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_UsernameSecure_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_PhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            panel_ByPhoneNumber.Visible = true;
            panel_SecurityQuestion.Visible= false;
            panel_NewPassword.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel_SecurityQuestion.Visible = true;
            panel_ByPhoneNumber.Visible = false;
            panel_NewPassword.Visible = false;
        }

        private void button_ConfirmSecure_Click(object sender, EventArgs e)
        {
            panel_SecurityQuestion.Visible = false;
            panel_ByPhoneNumber.Visible = false;
            panel_NewPassword.Visible = true;//jusst testing
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            panel_SecurityQuestion.Visible = false;
            panel_ByPhoneNumber.Visible = false;
            panel_NewPassword.Visible = true;//just testing
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

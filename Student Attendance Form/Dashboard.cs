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
    public partial class Dashboard : Form
    {
        Teacher teacher;
        ManageAttendance manageAttendance;
        public BindingSource BindingSource { get; set; } = new BindingSource();
        public Dashboard(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            manageAttendance = new ManageAttendance(teacher.Username);
            label_UserName.Text = teacher.Username;
            comboBox_Subject.SelectedIndex = 0;
            comboBox_Session.SelectedIndex = 0;
        }
        public Dashboard()
        {
            InitializeComponent();
            comboBox_Subject.SelectedIndex = 0;
            comboBox_Session.SelectedIndex = 0;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            manageAttendance.LoadData();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            manageAttendance.SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageAttendance.LoadData();
            bindingSource1.Clear();
            DateTime date = new DateTime(dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            var lst = from a in manageAttendance.attendances
                      where a.Date == date /*(a.Date - date).TotalDays < 1*/ &&
                      a.Subject == comboBox_Subject.SelectedItem.ToString()
                      && a.Session == comboBox_Session.SelectedIndex
                      select a;
            if (lst.Count() == 0)
            {//new Date of attendances
                Attendance a1, a2, a3, a4, a5;
                manageAttendance.attendances.Add(a1 = new Attendance
                {
                    No = 1,
                    Name = "Sokvimean",
                    Date = dateTimePicker1.Value,
                    Session = comboBox_Session.SelectedIndex,
                    Subject = comboBox_Subject.SelectedItem.ToString()
                });
                manageAttendance.attendances.Add(a2 = new Attendance
                {
                    No = 2,
                    Name = "Piseth",
                    Date = dateTimePicker1.Value,
                    Session = comboBox_Session.SelectedIndex,
                    Subject = comboBox_Subject.SelectedItem.ToString()
                });
                manageAttendance.attendances.Add(a3 = new Attendance
                {
                    No = 3,
                    Name = "Thanit",
                    Date = dateTimePicker1.Value,
                    Session = comboBox_Session.SelectedIndex,
                    Subject = comboBox_Subject.SelectedItem.ToString()
                });
                manageAttendance.attendances.Add(a4 = new Attendance
                {
                    No = 4,
                    Name = "Daphea",
                    Date = dateTimePicker1.Value,
                    Session = comboBox_Session.SelectedIndex,
                    Subject = comboBox_Subject.SelectedItem.ToString()
                });
                manageAttendance.attendances.Add(a5 = new Attendance
                {
                    No = 5,
                    Name = "Phanit",
                    Date = dateTimePicker1.Value,
                    Session = comboBox_Session.SelectedIndex,
                    Subject = comboBox_Subject.SelectedItem.ToString()
                });
                bindingSource1.Add(a1);
                bindingSource1.Add(a2);
                bindingSource1.Add(a3);
                bindingSource1.Add(a4);
                bindingSource1.Add(a5);
            }
            else
            {
                int i = 1;
                foreach (var a in lst)
                {
                    a.No = i++;
                    bindingSource1.Add(a);
                }
            }
        }

        private void ataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

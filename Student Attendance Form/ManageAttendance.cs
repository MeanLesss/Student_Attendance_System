using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_Form
{
    class ManageAttendance
    {
        public List<Attendance> attendances { get; set; } = new List<Attendance>();
        readonly string filename = "attendance.csv";

        public string TeacherName { get; set; } = "";

        public ManageAttendance(string teacherName)
        {
            TeacherName = teacherName;
            filename = teacherName + "_" + filename;
        }

        private Image LoadImage(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch
            {

                return Properties.Resources.wine_glass;
            }
        }

        public void LoadData()
        {
            if (!File.Exists(filename)) return;
            var ts = from t in File.ReadAllLines(filename).Skip(1)
                     let x = t.Split(',')
                     select new Attendance
                     {
                         Avatar = Image.FromFile(x[0]),
                         Name = x[1],
                         Status = x[2],
                         Remark = x[3],
                     };
            attendances.Clear();
            int i = 1;
            foreach(var t in ts)
            {
                t.No = i++;
                attendances.Add(t);
            }
        }

        public void SaveData()
        {
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Avatar,Name,Status,Remark");
                    foreach (var t in attendances)
                    {
                        sw.WriteLine($"{t.Avatar},{t.Name},{t.Status}," +
                            $"{t.Remark}");
                    }
                }
            }
        }
    }
}

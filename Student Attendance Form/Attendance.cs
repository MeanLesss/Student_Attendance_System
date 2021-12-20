using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_Form
{
    class Attendance
    {
        public int No { get; set; } = 0;
        public Image Avatar { get; set; } = Properties.Resources.wine_glass;
        public string Name { get; set; }
        public string Status { get; set; } = " Present";
        public string Remark { get; set; } = " ";
    }
}

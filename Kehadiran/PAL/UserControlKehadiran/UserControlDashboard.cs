using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kehadiran.PAL.UserControlKehadiran
{
    public partial class UserControlDashboard : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Kehadiran;
                            Integrated Security = True;";
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {
            labelTotalKelas.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Class_Table;", sql).ToString();
            labelTotalPelajar.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Student_Table;", sql).ToString();
            labelTotalPengguna.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM User_Table;", sql).ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}

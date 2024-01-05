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
    public partial class UserControlLaporan : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Kehadiran;
                            Integrated Security = True;";
        public UserControlLaporan()
        {
            InitializeComponent();
        }

        public void FirstTab()
        {
            tabControlLaporan.SelectedTab = tabPageLKelas;
        }

        private void comboBoxKelas_Click(object sender, EventArgs e)
        {
            comboBoxKelas.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxKelas, sql);
        }

        private void comboBoxKelas1_Click(object sender, EventArgs e)
        {
            comboBoxKelas1.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxKelas1, sql);
        }

        private void comboBoxRegNo_Click(object sender, EventArgs e)
        {
            if(comboBoxKelas1.SelectedIndex != 1)
            {
                comboBoxRegNo.Items.Clear();
                Attendance.Attendance.FillComboBox("SELECT DISTINCT(Student_Reg) FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name = '" + comboBoxKelas1.SelectedItem.ToString() + "';", comboBoxRegNo, sql);
            }
        }

        private void comboBoxKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKelas.SelectedIndex != -1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerdate.Text + "%' AND Class_Name = '" + comboBoxKelas.SelectedItem.ToString() + "';", dataGridViewLKelas, sql);

        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKelas1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerdate1.Text + "%' AND Class_Name = '" + comboBoxKelas1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "';", dataGridViewLPelajar, sql);

        }

        private void comboBoxKelas1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKelas1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerdate1.Text + "%' AND Class_Name = '" + comboBoxKelas1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "';", dataGridViewLPelajar, sql);

        }
    }
}

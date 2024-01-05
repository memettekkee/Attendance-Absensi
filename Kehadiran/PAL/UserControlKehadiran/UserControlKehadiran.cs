using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kehadiran.PAL.UserControlKehadiran
{
    public partial class UserControlKehadiran : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Kehadiran;
                            Integrated Security = True;";
        private bool okay;
        public UserControlKehadiran()
        {
            InitializeComponent();
            dataGridViewTKehadiran.Columns["Column1"].Visible = false;
            dataGridViewTKehadiran.Columns["Column5"].Visible = false;
        }

        private void comboBoxKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Attendance.Attendance.IsMarkAttendance(dateTimePickerdate.Text, comboBoxKelas.SelectedItem.ToString(), sql))
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Table.Student_ID, Student_Name, Student_Reg, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date = '" + dateTimePickerdate.Text + "' AND Class_Name = '" + comboBoxKelas.SelectedItem.ToString() + "';", dataGridViewTKehadiran, sql);
                okay = true;
            }
            else
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg FROM Student_Table INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Class_Name = '" + comboBoxKelas.SelectedItem.ToString() + "';", dataGridViewTKehadiran, sql);
                okay = false;
            }
        }

        private void tabPageTKehadiran_Leave(object sender, EventArgs e)
        {
            if(comboBoxKelas.SelectedIndex != -1)
            {
                string status;
                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerdate.Text, comboBoxKelas.SelectedItem.ToString(), sql))
                {
                    foreach (DataGridViewRow row in dataGridViewTKehadiran.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Hadir";
                        else
                            status = "Tidak Hadir";

                        Attendance.Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerdate.Text, status, sql);
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewTKehadiran.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Hadir";
                        else
                            status = "Tidak Hadir";

                        Attendance.Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerdate.Text, status, sql);
                    }
                }
            }
        }

        private void dataGridViewTKehadiran_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (comboBoxKelas.SelectedIndex != -1)
            {
                
                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerdate.Text, comboBoxKelas.SelectedItem.ToString(), sql) && okay)
                {
                    foreach (DataGridViewRow row in dataGridViewTKehadiran.Rows)
                    {
                        if (row.Cells["Column5"].Value.ToString() == "Hadir")
                            row.Cells["Column4"].Value = true;
                        else
                            row.Cells["Column4"].Value = false;
                    }
                }
              
            }
        }

        private void comboBoxKelas_Click(object sender, EventArgs e)
        {
            comboBoxKelas.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxKelas, sql);
        }
    }
}

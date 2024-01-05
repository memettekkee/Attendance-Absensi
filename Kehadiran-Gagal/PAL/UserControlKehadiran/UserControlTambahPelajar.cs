using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kehadiran.PAL.UserControlKehadiran
{
    public partial class UserControlTambahPelajar : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Absensi;
                            Integrated Security = True;";

        private string SID = "", gender = "";
        public UserControlTambahPelajar()
        {
            InitializeComponent();
        }

        public void ClearTextBox()
        {
            textBoxNama.Clear();
            textBoxNoReg.Clear();
            comboBoxClass.SelectedIndex = -1;
            radioButtonLakilaki.Checked = false;
            radioButtonPerempuan.Checked = false;
            tabControlPelajar.SelectedTab = tabPageTambahPljr;
        }

        private void ClearTextBox2()
        {
            textBoxNama1.Clear();
            textBoxNoReg1.Clear();
            comboBoxKelas1.SelectedIndex = -1;
            radioButtonLaki1.Checked = false;
            radioButtonPerempuan1.Checked = false;
            SID = "";
        }

        private void tabCariPelajar_Enter(object sender, EventArgs e)
        {
            textBoxCari.Clear();
            comboBoxCarik.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID;", dataGridViewPelajar, sql);
            dataGridViewPelajar.Columns[0].Visible = false;
            labelHitungPelajar.Text = dataGridViewPelajar.Rows.Count.ToString();
        }

        private void tabPageTambahPljr_Enter(object sender, EventArgs e)
        {
            ClearTextBox2();
        }

        private void tabPageTambahPljr_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabPageUPPelajar_Leave(object sender, EventArgs e)
        {
            ClearTextBox2();
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass, sql);
        }

        private void buttonTambahkan_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButtonLakilaki.Checked)
                gender = "Laki-Laki";
            if (radioButtonPerempuan.Checked)
                gender = "Perempuan";
            if (textBoxNama.Text.Trim() == string.Empty || textBoxNoReg.Text.Trim() == string.Empty || comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(radioButtonLakilaki.Checked == false && radioButtonPerempuan.Checked == false)
            {
                MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddStudent(textBoxNama.Text.Trim(), textBoxNoReg.Text.Trim(), comboBoxClass.SelectedItem.ToString(), gender, sql);

                if (check)
                    ClearTextBox();
                
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxCarik.SelectedIndex == 0)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Name LIKE '%" + textBoxCari.Text.Trim() + "%';", dataGridViewPelajar, sql);
            if (comboBoxCarik.SelectedIndex == 1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Reg LIKE '%" + textBoxCari.Text.Trim() + "%';", dataGridViewPelajar, sql);
            if (comboBoxCarik.SelectedIndex == 2)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name LIKE '%" + textBoxCari.Text.Trim() + "%';", dataGridViewPelajar, sql);
        }

        private void dataGridViewPelajar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewPelajar.Rows[e.RowIndex];
                SID = row.Cells["Column1"].Value.ToString();
                textBoxNama1.Text = row.Cells["Column2"].Value.ToString();
                textBoxNoReg1.Text = row.Cells["Column3"].Value.ToString();
                comboBoxKelas1.Items.Clear();
                Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxKelas1, sql);
                comboBoxKelas1.SelectedItem = row.Cells["Column4"].Value.ToString();
                if (row.Cells["Column5"].Value.ToString() == "Laki-Laki")
                    radioButtonLaki1.Checked = true;
                if (row.Cells["Column5"].Value.ToString() == "Perempuan")
                    radioButtonPerempuan1.Checked = true;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if(SID != "")
            {
                string gender = "";
                if (radioButtonLaki1.Checked)
                    gender = "Laki-Laki";
                if (radioButtonPerempuan1.Checked)
                    gender = "Perempuan";
                if (textBoxNama1.Text.Trim() == string.Empty || textBoxNoReg1.Text.Trim() == string.Empty || comboBoxKelas1.SelectedIndex == -1)
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonLaki1.Checked == false && radioButtonPerempuan1.Checked == false)
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateStudent(SID, textBoxNama1.Text.Trim(), textBoxNoReg1.Text.Trim(), comboBoxKelas1.SelectedItem.ToString(), gender, sql);

                    if (check)
                    {
                        ClearTextBox2();
                    }
                }
            }
            else
                MessageBox.Show("Pilih baris dari tabel.", "Pilih baris", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if(SID != "")
            {
                string gender = "";
                if (radioButtonLaki1.Checked)
                    gender = "Laki-Laki";
                if (radioButtonPerempuan1.Checked)
                    gender = "Perempuan";
                if (textBoxNama1.Text.Trim() == string.Empty || textBoxNoReg1.Text.Trim() == string.Empty || comboBoxKelas1.SelectedIndex == -1)
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonLaki1.Checked == false && radioButtonPerempuan1.Checked == false)
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Apakah kamu mau hapus pelajar ini?", "Hapus pelajar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteStudent(SID, sql);

                        if (check)
                            ClearTextBox2();

                    }
                }
            }
            else
                MessageBox.Show("Pilih baris dari tabel.", "Pilih baris", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

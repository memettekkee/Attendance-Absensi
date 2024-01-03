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
    public partial class UserControlKelas : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Absensi;
                            Integrated Security = True;";

        private string CID = "";
        public UserControlKelas()
        {
            InitializeComponent();
        }

        private void IntegerType(KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public void ClearTextBox()
        {
            textBoxNama.Clear();
            textBoxJumlahPljr.Clear();
            textBoxLaki.Clear();
            textBoxPerempuan.Clear();
            tabControlKelas.SelectedTab = tabPageTambahKls;
        }

        private void ClearTextBoxx()
        {
            textBoxUbhNama.Clear();
            textBoxUbhPljr.Clear();
            textBoxUbhLK.Clear();
            textBoxUbhPrmpn.Clear();
            CID = "";
        }

        private void buttonTambahkan_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text.Trim() == string.Empty || textBoxJumlahPljr.Text.Trim() == string.Empty || textBoxLaki.Text.Trim() == string.Empty || textBoxPerempuan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddClass(textBoxNama.Text.Trim(), textBoxJumlahPljr.Text.Trim(), textBoxLaki.Text.Trim(), textBoxPerempuan.Text.Trim(), sql);

                if(check)
                    ClearTextBox();
            }
        }

        private void tabPageUPClass_Leave(object sender, EventArgs e)
        {
            ClearTextBoxx();
        }

        private void tabCariKls_Enter(object sender, EventArgs e)
        {
            textBoxCari.Clear();
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table;", dataGridViewKelas, sql);
            dataGridViewKelas.Columns[0].Visible = false;
            labelHitungKls.Text = dataGridViewKelas.Rows.Count.ToString();
        }

        private void tabPageTambahKls_Enter(object sender, EventArgs e)
        {
            ClearTextBoxx();
        }

        private void tabPageTambahKls_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void textBoxJumlahPljr_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxLaki_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxPerempuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxUbhPljr_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxUbhLK_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxUbhPrmpn_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name LIKE '%" + textBoxCari.Text + "%';", dataGridViewKelas, sql);
        }

        private void dataGridViewKelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewKelas.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxUbhNama.Text = row.Cells[1].Value.ToString();
                textBoxUbhPljr.Text = row.Cells[2].Value.ToString();
                textBoxUbhLK.Text = row.Cells[3].Value.ToString();
                textBoxUbhPrmpn.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxUbhNama.Text.Trim() == string.Empty || textBoxUbhPljr.Text.Trim() == string.Empty || textBoxUbhLK.Text.Trim() == string.Empty || textBoxUbhPrmpn.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateClass(CID, textBoxUbhNama.Text.Trim(), textBoxUbhPljr.Text.Trim(), textBoxUbhLK.Text.Trim(), textBoxUbhPrmpn.Text.Trim(), sql);

                    if (check)
                        ClearTextBoxx();
                }
            }
            else
                MessageBox.Show("Pilih baris dari tabel.", "Pilih baris", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxUbhNama.Text.Trim() == string.Empty || textBoxUbhPljr.Text.Trim() == string.Empty || textBoxUbhLK.Text.Trim() == string.Empty || textBoxUbhPrmpn.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Apakah kamu mau hapus kelas ini?", "Hapus kelas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteClass(CID, sql);

                        if (check)
                           ClearTextBoxx();
                        
                    }
                }
            }
            else
                MessageBox.Show("Pilih baris dari tabel.", "Pilih baris", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

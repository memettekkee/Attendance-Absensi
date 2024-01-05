using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kehadiran.PAL.UserControlKehadiran
{
    public partial class UserControlRegister : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Kehadiran;
                            Integrated Security = True;";
        public string UID;
        public string Gender = "", Role, ID = "";
        public UserControlRegister()
        {
            InitializeComponent();
        }

        public void HideErrorPic()
        {
            pictureBoxErrorPho.Visible = false;
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorTahun.Visible = false;
        }

        private void HideErrorPic1()
        {
            pictureBoxErrorTelp.Visible = false;
            pictureBoxErrorEmail1.Visible = false;
            pictureBoxErrorTHN.Visible = false;
        }

        public void ClearTextBox()
        {
            textBoxNama.Clear();
            textBoxPass.Clear();
            maskedTextBoxPho.Text = "+6200000000000";
            maskedTextBoxPho.ForeColor = Color.DarkGray;
            maskedTextBoxNIM.Text = "20000000000";
            maskedTextBoxNIM.ForeColor = Color.DarkGray;
            maskedTextBoxTL.Text = "00/00/0000";
            maskedTextBoxTL.ForeColor = Color.DarkGray;
            textBoxEmail.Text = "contoh@gmail.com";
            textBoxEmail.ForeColor = Color.DarkGray;
            radioButtonLakilaki.Checked = false;
            radioButtonPerempuan.Checked = false;
            checkBoxAdmin.Checked = false;
            textBoxAlamat.Clear();
            tabControlRegister.SelectedTab = tabPageTambahPengguna;
        }

        private void ClearTextBox1()
        {
            textBoxNama1.Clear();
            textBoxPassword1.Clear();
            maskedTextBoxTelpon1.Text = "+6200000000000";
            maskedTextBoxTelpon1.ForeColor = Color.DarkGray;
            maskedTextBoxNIM1.Text = "20000000000";
            maskedTextBoxNIM1.ForeColor = Color.DarkGray;
            maskedTextBoxTL1.Text = "00/00/0000";
            maskedTextBoxTL1.ForeColor = Color.DarkGray;
            radioButtonLaki1.Checked = false;
            radioButtonPerempuan1.Checked = false;
            textBoxEmail1.Text = "contoh@gmail.com";
            textBoxEmail1.ForeColor = Color.DarkGray;
            checkBoxAdmin1.Checked = false;
            textBoxAlamat1.Clear();
            ID = "";
        }

        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox.Select(0, 0);
            });
        }

        //private void maskedTextBoxEmail_Enter(object sender, EventArgs e)
        //{
        //    if (maskedTextBoxEmail.Text == "00000000000@student.com")
        //    {
        //        maskedTextBoxEmail.Text = "";
        //        maskedTextBoxEmail.ForeColor = Color.Black;
        //    }
        //}

        //private void maskedTextBoxEmail_Leave(object sender, EventArgs e)
        //{
        //    if (maskedTextBoxEmail.Text == "")
        //    {
        //        maskedTextBoxEmail.Text = "00000000000@student.com";
        //        maskedTextBoxEmail.ForeColor = Color.DarkGray;
        //    }

        //    if (!IsValidEmail(maskedTextBoxEmail.Text) || maskedTextBoxEmail.Text == "00000000000@student.com")
        //        pictureBoxErrorEmail.Visible = true;
        //    else
        //        pictureBoxErrorEmail.Visible = false;
        //}

        private void maskedTextBoxPho_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "+6200000000000")
                maskedTextBoxPho.Text = "";

            if (!maskedTextBoxPho.MaskCompleted)
            {
                maskedTextBoxPho.ForeColor = Color.Black;
                Mask(maskedTextBoxPho);
            }
        }

        private void maskedTextBoxPho_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "+")
            {
                maskedTextBoxPho.Text = "+6200000000000";
                maskedTextBoxPho.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxPho.MaskCompleted)
                maskedTextBoxPho.ForeColor = Color.DarkGray;

            if (!maskedTextBoxPho.MaskCompleted || maskedTextBoxPho.Text == "+6200000000000")
                pictureBoxErrorPho.Visible = true;
            else 
                pictureBoxErrorPho.Visible = false;
        }

        private void maskedTextBoxNIM_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxNIM.Text == "20000000000")
                maskedTextBoxNIM.Text = "";

            if(!maskedTextBoxNIM.MaskCompleted)
            {
                maskedTextBoxNIM.ForeColor = Color.Black;
                Mask(maskedTextBoxNIM);
            }
        }

        private void maskedTextBoxNIM_Leave(object sender, EventArgs e)
        {
            if(maskedTextBoxNIM.Text.Trim() == "")
            {
                maskedTextBoxNIM.Text = "20000000000";
                maskedTextBoxNIM.ForeColor= Color.DarkGray;
            }

            if(!maskedTextBoxNIM.MaskCompleted)
                maskedTextBoxNIM.ForeColor = Color.DarkGray;

            if (maskedTextBoxNIM.Text == "20000000000" || !maskedTextBoxNIM.MaskCompleted)
                pictureBoxErrorTahun.Visible = true;
            else
                pictureBoxErrorTahun.Visible= false;
        }

        private void maskedTextBoxTelpon1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxTelpon1.Text == "+6200000000000")
                maskedTextBoxTelpon1.Text = "";

            if (!maskedTextBoxTelpon1.MaskCompleted)
            {
                maskedTextBoxTelpon1.ForeColor = Color.Black;
                Mask(maskedTextBoxTelpon1);
            }
        }

        private void maskedTextBoxTelpon1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTelpon1.Text == "+")
            {
                maskedTextBoxTelpon1.Text = "+6200000000000";
                maskedTextBoxTelpon1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxTelpon1.MaskCompleted)
                maskedTextBoxTelpon1.ForeColor = Color.DarkGray;

            if (!maskedTextBoxTelpon1.MaskCompleted || maskedTextBoxTelpon1.Text == "+6200000000000")
                pictureBoxErrorTelp.Visible = true;
            else
                pictureBoxErrorTelp.Visible = false;
        }

        private void maskedTextBoxNIM1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxNIM1.Text == "20000000000")
                maskedTextBoxNIM1.Text = "";

            if (!maskedTextBoxNIM1.MaskCompleted)
            {
                maskedTextBoxNIM1.ForeColor = Color.Black;
                Mask(maskedTextBoxNIM1);
            }
        }

        private void maskedTextBoxNIM1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxNIM1.Text.Trim() == "")
            {
                maskedTextBoxNIM1.Text = "20000000000";
                maskedTextBoxNIM1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxNIM1.MaskCompleted)
                maskedTextBoxNIM1.ForeColor = Color.DarkGray;

            if (maskedTextBoxNIM1.Text == "20000000000" || !maskedTextBoxNIM1.MaskCompleted)
                pictureBoxErrorTHN.Visible = true;
            else
                pictureBoxErrorTHN.Visible = false;
        }

        //private void maskedTextBoxEmail1_Enter(object sender, EventArgs e)
        //{
        //    if (maskedTextBoxEmail1.Text == "00000000000@student.com")
        //    {
        //        maskedTextBoxEmail1.Text = "";
        //        maskedTextBoxEmail1.ForeColor = Color.Black;
        //    }
        //}

        //private void maskedTextBoxEmail1_Leave(object sender, EventArgs e)
        //{
        //    if (maskedTextBoxEmail1.Text == "")
        //    {
        //        maskedTextBoxEmail1.Text = "00000000000@student.com";
        //        maskedTextBoxEmail1.ForeColor = Color.DarkGray;
        //    }

        //    if (!IsValidEmail(maskedTextBoxEmail1.Text) || maskedTextBoxEmail1.Text == "00000000000@student.com")
        //        pictureBoxErrorEmail1.Visible = true;
        //    else
        //        pictureBoxErrorEmail1.Visible = false;
        //}

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCarik.SelectedIndex == 0)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxCari.Text + "%'", dataGridViewPengguna, sql);

            if (comboBoxCarik.SelectedIndex == 1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Pho LIKE '%" + textBoxCari.Text + "%'", dataGridViewPengguna, sql);

            if (comboBoxCarik.SelectedIndex == 2)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Email LIKE '%" + textBoxCari.Text + "%'", dataGridViewPengguna, sql);
        }

        private void tabCariPengguna_Enter(object sender, EventArgs e)
        {
            textBoxCari.Clear();
            comboBoxCarik.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table;", dataGridViewPengguna,sql);
            dataGridViewPengguna.Columns[0].Visible = false;
            labelHitungPengguna.Text = dataGridViewPengguna.Rows.Count.ToString();
        }

        // ini eror lagi auuu

        //private void tabCariPengguna_Leave(object sender, EventArgs e)
        //{
        //    HideErrorPic();
        //    HideErrorPic1();
        //    ClearTextBox();
        //    ClearTextBox1();
        //}

        private void buttonTambahkan_Click(object sender, EventArgs e)
        {
            if (radioButtonLakilaki.Checked)
                Gender = "Laki-Laki";
            else
                Gender = "Perempuan";

            if (checkBoxAdmin.Checked)
                Role = "Admin";
            else
                Role = "User";

            if (textBoxNama.Text.Trim() == string.Empty || textBoxPass.Text.Trim() == string.Empty
                || !maskedTextBoxPho.MaskCompleted || maskedTextBoxPho.Text == "+6200000000000"
                || !maskedTextBoxNIM.MaskCompleted || maskedTextBoxNIM.Text == "20000000000"
                || !IsValidDate(maskedTextBoxTL.Text) || maskedTextBoxTL.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxTL.Text) > DateTime.Now
                || Gender == string.Empty
                || !IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "contoh@gmail.com")
            
                MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                bool check = Attendance.Attendance.AddRole(
                    textBoxNama.Text.Trim(), textBoxPass.Text.Trim(), maskedTextBoxPho.Text, maskedTextBoxNIM.Text, maskedTextBoxTL.Text, Gender, textBoxEmail.Text.Trim(), Role, textBoxAlamat.Text.Trim(), sql);
                if (check)
                    ClearTextBox();
            }
        }

        private void tabPageTambahPengguna_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
            HideErrorPic();
        }
        private void tabPageTambahPengguna_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        //private void tabPageUPPengguna_Leave(object sender, EventArgs e)
        //{
        //    HideErrorPic1();
        //    ClearTextBox1();
        //}

        private void dataGridViewPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewPengguna.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxNama1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
                maskedTextBoxTelpon1.Text = row.Cells[3].Value.ToString();
                maskedTextBoxTelpon1.ForeColor = Color.Black;
                maskedTextBoxNIM1.Text = row.Cells[4].Value.ToString();
                maskedTextBoxNIM1.ForeColor = Color.Black;
                maskedTextBoxTL1.Text = row.Cells[5].Value.ToString();
                maskedTextBoxTL1.ForeColor = Color.Black;
                
                Gender = row.Cells[6].Value.ToString();
                if (Gender == "Laki-Laki")
                    radioButtonLaki1.Checked = true;
                else
                    radioButtonPerempuan1.Checked = true;
                textBoxEmail1.Text = row.Cells[7].Value.ToString();
                Role = row.Cells[8].Value.ToString();
                if (Role == "Admin")
                    checkBoxAdmin1.Checked = true;
                textBoxAlamat1.Text = row.Cells[9].Value.ToString();
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonLaki1.Checked)
                    Gender = "Laki-Laki";
                else
                    Gender = "Perempuan";

                if (checkBoxAdmin1.Checked)
                    Role = "Admin";
                else
                    Role = "User";

                if (textBoxNama1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty
                    || !maskedTextBoxTelpon1.MaskCompleted || maskedTextBoxTelpon1.Text == "+6200000000000"
                    || !maskedTextBoxNIM1.MaskCompleted || maskedTextBoxNIM1.Text == "20000000000"
                    || !IsValidDate(maskedTextBoxTL1.Text) || maskedTextBoxTL1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxTL1.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "contoh@gmail.com")
                
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                else
                {
                    bool check = Attendance.Attendance.UpdateUser(ID,
                   textBoxNama.Text.Trim(), textBoxPass.Text.Trim(), maskedTextBoxPho.Text, maskedTextBoxNIM.Text, maskedTextBoxTL.Text, Gender, textBoxEmail.Text.Trim(), Role, textBoxAlamat.Text.Trim(), sql);
                    if (check)
                        ClearTextBox1();
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if(ID != "")
            {
                if (radioButtonLaki1.Checked)
                    Gender = "Laki-Laki";
                else
                    Gender = "Perempuan";

                if (checkBoxAdmin1.Checked)
                    Role = "Admin";
                else
                    Role = "User";

                if (textBoxNama1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty
                    || !maskedTextBoxTelpon1.MaskCompleted || maskedTextBoxTelpon1.Text == "+6200000000000"
                    || !maskedTextBoxNIM1.MaskCompleted || maskedTextBoxNIM1.Text == "20000000000"
                    || !IsValidDate(maskedTextBoxTL.Text) || maskedTextBoxTL.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxTL.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "contoh@gmail.com")
                {
                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Apakah kamu mau hapus pengguna ini?", "Hapus pengguna", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteUser(ID, sql);
                        if (check)
                        {
                            if (UID == ID)
                                Application.Exit();
                            ClearTextBox1();
                        }
                    }
                }
            }
        }

        private void maskedTextBoxTL_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxTL.Text == "00/00/0000")
                maskedTextBoxTL.Text = "contoh@gmail.com";

            if (!maskedTextBoxTL.MaskCompleted)
            {
                maskedTextBoxTL.ForeColor = Color.Black;
                Mask(maskedTextBoxTL);
            }
        }

        private void maskedTextBoxTL_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTL.Text.Trim() == "/  /")
            {
                maskedTextBoxTL.Text = "00/00/0000";
                maskedTextBoxTL.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxTL.MaskCompleted)
            {
                maskedTextBoxTL.ForeColor = Color.DarkGray;
            }

        }

        private void maskedTextBoxTL1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxTL1.Text == "00/00/0000")
                maskedTextBoxTL1.Text = "contoh@gmail.com";

            if (!maskedTextBoxTL1.MaskCompleted)
            {
                maskedTextBoxTL1.ForeColor = Color.Black;
                Mask(maskedTextBoxTL1);
            }
        }

        private void maskedTextBoxNIM_Enter_1(object sender, EventArgs e)
        {
            if (maskedTextBoxNIM.Text == "20000000000")
                maskedTextBoxNIM.Text = "contoh@gmail.com";

            if (!maskedTextBoxNIM.MaskCompleted)
            {
                maskedTextBoxNIM.ForeColor = Color.Black;
                Mask(maskedTextBoxNIM);
            }
        }

        private void maskedTextBoxNIM_Leave_1(object sender, EventArgs e)
        {
            if (maskedTextBoxNIM.Text.Trim() == "contoh@gmail.com")
            {
                maskedTextBoxNIM.Text = "20000000000";
                maskedTextBoxNIM.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxNIM.MaskCompleted)
                maskedTextBoxNIM.ForeColor = Color.DarkGray;

            if (maskedTextBoxNIM.Text == "20000000000" || !maskedTextBoxNIM.MaskCompleted)
                pictureBoxErrorTahun.Visible = true;
            else
                pictureBoxErrorTahun.Visible = false;
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "contoh@gmail.com")
            {
                textBoxEmail.Text = "contoh@gmail.com";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "contoh@gmail.com")
            {
                textBoxEmail.Text = "contoh@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }

        }

       

        private void maskedTextBoxTL1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTL1.Text.Trim() == "/  /")
            {
                maskedTextBoxTL1.Text = "00/00/0000";
                maskedTextBoxTL1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxTL1.MaskCompleted)
            {
                maskedTextBoxTL1.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxEmail1_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "contoh@gmail.com")
            {
                textBoxEmail1.Text = "contoh@gmail.com";
                textBoxEmail1.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail1_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "contoh@gmail.com")
            {
                textBoxEmail1.Text = "contoh@gmail.com";
                textBoxEmail1.ForeColor = Color.DarkGray;
            }
        }

        private void buttonHapus_Click_1(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonLaki1.Checked)
                    Gender = "Laki-Laki";
                else
                    Gender = "Perempuan";

                if (checkBoxAdmin1.Checked)
                    Role = "Admin";
                else
                    Role = "User";

                if (textBoxNama1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty
                    || !maskedTextBoxTelpon1.MaskCompleted || maskedTextBoxTelpon1.Text == "+6200000000000"
                    || !maskedTextBoxNIM1.MaskCompleted || maskedTextBoxNIM1.Text == "20000000000"
                    || !IsValidDate(maskedTextBoxTL.Text) || maskedTextBoxTL.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxTL.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "contoh@gmail.com")

                    MessageBox.Show("Isi semua kolom.", "Semua kolom harus diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Apakah kamu mau hapus penggguna ini?", "Hapus pengguna", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteUser(ID, sql);
                        if (check)
                        {
                            if (UID == ID)
                                Application.Exit();
                            ClearTextBox1();
                        }
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // gajadi dipake hehehe (simpen aja sapatau penting)

        private bool IsValidDate(string date)
        {
            DateTime d;
            bool chValidity;
            try
            {
                return chValidity = DateTime.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kehadiran.PAL.Forms
{
    public partial class FormForgotPassword : Form
    {

        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Absensi;
                            Integrated Security = True;";
        public FormForgotPassword()
        {
            InitializeComponent();
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == "Example@gmail.com") 
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }

            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "Example@gmail.com") 
            {
                pictureBoxError.Show();
            }
            else
            {
                pictureBoxError.Hide();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == string.Empty)
            {
                textBoxEmail.Text = "Example@gmail.com";
                textBoxEmail.ForeColor= Color.DarkGray;
            }
            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "Example@gmail.com")
            {
                pictureBoxError.Show();
            }
            else
            {
                pictureBoxError.Hide();
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if(IsValidEmail(textBoxEmail.Text.Trim()))
            {
                string userName = Attendance.Attendance.GetUsernamePassword("SELECT User_Name FROM User_Table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                string password = Attendance.Attendance.GetUsernamePassword("SELECT User_Pass FROM User_Table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                MessageBox.Show($"Nama Pengguna: {userName}\nKata Sandi: {password}", "Informasi Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }
    }
}

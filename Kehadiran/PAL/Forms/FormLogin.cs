﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kehadiran.PAL.Forms
{
    public partial class FormLogin : Form
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Kehadiran;
                            Integrated Security = True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
            labelError.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Check = Attendance.Attendance.IsValidNamePass(textBoxName.Text.Trim(), textBoxPassword.Text.Trim(), sql);
            if(textBoxName.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty )
            {
                if(Check != "")
                {
                    FormMain formMain = new FormMain();
                    formMain.Username = textBoxName.Text;
                    formMain.Role = Check;
                    textBoxName.Clear();
                    textBoxPassword.Clear();
                    textBoxName.Focus();
                    pictureBoxError.Hide();
                    labelError.Hide();
                    formMain.ShowDialog();
                }
                else
                {
                    pictureBoxError.Show();
                    labelError.Show();
                }
            }

        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled= true;
            }
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }
    }
}

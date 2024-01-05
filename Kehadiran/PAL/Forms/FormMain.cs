using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if(Role == "User")
            {
                userControlDashboard1.Visible = false;
                buttonDashboard.Hide();
                buttonKelas.Hide();
                buttonPelajar.Hide();
                buttonDaftar.Hide();
            }
        }

        public string Username, Role;

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 220);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlKelas1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
            userControlTambahPelajar1.Visible = false;
            userControlRegister1.Visible = false;
            userControlKehadiran1.Visible = false;
            userControlLaporan1.Visible = false;
        }

        private void buttonAbsensi_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAbsensi);
            userControlKelas1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlTambahPelajar1.Visible = false;
            userControlRegister1.Visible = false;
            userControlKehadiran1.Visible = true;
            userControlLaporan1.Visible = false;
        }

        private void buttonKelas_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonKelas);
            userControlKelas1.Visible = true;
            userControlDashboard1.Visible = false;
            userControlTambahPelajar1.Visible = false;
            userControlRegister1.Visible = false;
            userControlKehadiran1.Visible = false;
            userControlLaporan1.Visible = false;
        }

        private void buttonPelajar_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonPelajar);
            userControlKelas1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlTambahPelajar1.Visible = true;
            userControlRegister1.Visible = false;
            userControlRegister1.HideErrorPic();
            userControlKehadiran1.Visible = false;
            userControlLaporan1.Visible = false;
        } 

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonLaporan);
            userControlKehadiran1.Visible = false;
            userControlKelas1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlTambahPelajar1.Visible = false;
            userControlRegister1.Visible = false;
            userControlLaporan1.FirstTab();
            userControlLaporan1.Visible = true;
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDaftar);
            userControlKehadiran1.Visible = false;
            userControlKelas1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlTambahPelajar1.Visible = false;
            userControlRegister1.Visible = true;
            userControlLaporan1.Visible = false;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if(panelExpand.Visible)
                panelExpand.Visible = false;
            else panelExpand.Visible = true;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ingin Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();
            }
        }
    }
}

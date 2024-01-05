namespace Kehadiran.PAL.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.buttonLaporan = new System.Windows.Forms.Button();
            this.buttonPelajar = new System.Windows.Forms.Button();
            this.buttonKelas = new System.Windows.Forms.Button();
            this.buttonAbsensi = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlKehadiran1 = new Kehadiran.PAL.UserControlKehadiran.UserControlKehadiran();
            this.userControlRegister1 = new Kehadiran.PAL.UserControlKehadiran.UserControlRegister();
            this.userControlTambahPelajar1 = new Kehadiran.PAL.UserControlKehadiran.UserControlTambahPelajar();
            this.userControlKelas1 = new Kehadiran.PAL.UserControlKehadiran.UserControlKelas();
            this.userControlDashboard1 = new Kehadiran.PAL.UserControlKehadiran.UserControlDashboard();
            this.userControlLaporan1 = new Kehadiran.PAL.UserControlKehadiran.UserControlLaporan();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelExpand.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.buttonDaftar);
            this.panel1.Controls.Add(this.buttonLaporan);
            this.panel1.Controls.Add(this.buttonPelajar);
            this.panel1.Controls.Add(this.buttonKelas);
            this.panel1.Controls.Add(this.buttonAbsensi);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 499);
            this.panel4.TabIndex = 2;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(3, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 47);
            this.panelSlide.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 221);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sistem Kehadiran";
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.panelExpand);
            this.panelBack.Controls.Add(this.pictureBoxExpand);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(262, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(938, 218);
            this.panelBack.TabIndex = 1;
            // 
            // panelExpand
            // 
            this.panelExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpand.Controls.Add(this.buttonLogOut);
            this.panelExpand.Controls.Add(this.buttonMinimize);
            this.panelExpand.Controls.Add(this.panel3);
            this.panelExpand.Location = new System.Drawing.Point(715, 57);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(200, 100);
            this.panelExpand.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 5);
            this.panel3.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(22, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 23);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 84);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(938, 134);
            this.panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(234, 73);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(35, 23);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "{?}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Berperan Sebagai";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(234, 28);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 23);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "{?}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selamat Datang";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.White;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonLogOut.Image = global::Kehadiran.Properties.Resources.lohh;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 48);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(198, 43);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "  Log Out";
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.White;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonMinimize.Image = global::Kehadiran.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.buttonMinimize.Location = new System.Drawing.Point(0, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(198, 43);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.Text = "   Minimize";
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // pictureBoxExpand
            // 
            this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpand.Image = global::Kehadiran.Properties.Resources.bottom_arrow_icon_224639;
            this.pictureBoxExpand.Location = new System.Drawing.Point(878, 7);
            this.pictureBoxExpand.Name = "pictureBoxExpand";
            this.pictureBoxExpand.Size = new System.Drawing.Size(47, 50);
            this.pictureBoxExpand.TabIndex = 2;
            this.pictureBoxExpand.TabStop = false;
            this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click);
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDaftar.FlatAppearance.BorderSize = 0;
            this.buttonDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDaftar.ForeColor = System.Drawing.Color.White;
            this.buttonDaftar.Image = global::Kehadiran.Properties.Resources.reg;
            this.buttonDaftar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDaftar.Location = new System.Drawing.Point(10, 496);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(252, 55);
            this.buttonDaftar.TabIndex = 0;
            this.buttonDaftar.Text = "     Daftar";
            this.buttonDaftar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDaftar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDaftar.UseVisualStyleBackColor = true;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // buttonLaporan
            // 
            this.buttonLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLaporan.FlatAppearance.BorderSize = 0;
            this.buttonLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaporan.ForeColor = System.Drawing.Color.White;
            this.buttonLaporan.Image = global::Kehadiran.Properties.Resources.lapor;
            this.buttonLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLaporan.Location = new System.Drawing.Point(10, 441);
            this.buttonLaporan.Name = "buttonLaporan";
            this.buttonLaporan.Size = new System.Drawing.Size(252, 55);
            this.buttonLaporan.TabIndex = 0;
            this.buttonLaporan.Text = "     Laporan";
            this.buttonLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLaporan.UseVisualStyleBackColor = true;
            this.buttonLaporan.Click += new System.EventHandler(this.buttonLaporan_Click);
            // 
            // buttonPelajar
            // 
            this.buttonPelajar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPelajar.FlatAppearance.BorderSize = 0;
            this.buttonPelajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPelajar.ForeColor = System.Drawing.Color.White;
            this.buttonPelajar.Image = global::Kehadiran.Properties.Resources.psrta;
            this.buttonPelajar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPelajar.Location = new System.Drawing.Point(10, 386);
            this.buttonPelajar.Name = "buttonPelajar";
            this.buttonPelajar.Size = new System.Drawing.Size(252, 55);
            this.buttonPelajar.TabIndex = 0;
            this.buttonPelajar.Text = "     Tambah Pelajar";
            this.buttonPelajar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPelajar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPelajar.UseVisualStyleBackColor = true;
            this.buttonPelajar.Click += new System.EventHandler(this.buttonPelajar_Click);
            // 
            // buttonKelas
            // 
            this.buttonKelas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKelas.FlatAppearance.BorderSize = 0;
            this.buttonKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelas.ForeColor = System.Drawing.Color.White;
            this.buttonKelas.Image = global::Kehadiran.Properties.Resources.claz;
            this.buttonKelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKelas.Location = new System.Drawing.Point(10, 331);
            this.buttonKelas.Name = "buttonKelas";
            this.buttonKelas.Size = new System.Drawing.Size(252, 55);
            this.buttonKelas.TabIndex = 0;
            this.buttonKelas.Text = "     Tambah Kelas";
            this.buttonKelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKelas.UseVisualStyleBackColor = true;
            this.buttonKelas.Click += new System.EventHandler(this.buttonKelas_Click);
            // 
            // buttonAbsensi
            // 
            this.buttonAbsensi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbsensi.FlatAppearance.BorderSize = 0;
            this.buttonAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbsensi.ForeColor = System.Drawing.Color.White;
            this.buttonAbsensi.Image = global::Kehadiran.Properties.Resources.flek;
            this.buttonAbsensi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbsensi.Location = new System.Drawing.Point(10, 276);
            this.buttonAbsensi.Name = "buttonAbsensi";
            this.buttonAbsensi.Size = new System.Drawing.Size(252, 55);
            this.buttonAbsensi.TabIndex = 0;
            this.buttonAbsensi.Text = "     Kehadiran";
            this.buttonAbsensi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbsensi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbsensi.UseVisualStyleBackColor = true;
            this.buttonAbsensi.Click += new System.EventHandler(this.buttonAbsensi_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::Kehadiran.Properties.Resources.pc;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(10, 221);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(252, 55);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "     Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Kehadiran.Properties.Resources.iconfinder_481_university_bank_campus_court_4212926_114964;
            this.pictureBox1.Location = new System.Drawing.Point(62, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userControlKehadiran1
            // 
            this.userControlKehadiran1.BackColor = System.Drawing.Color.White;
            this.userControlKehadiran1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlKehadiran1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlKehadiran1.Location = new System.Drawing.Point(262, 218);
            this.userControlKehadiran1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlKehadiran1.Name = "userControlKehadiran1";
            this.userControlKehadiran1.Size = new System.Drawing.Size(938, 502);
            this.userControlKehadiran1.TabIndex = 0;
            this.userControlKehadiran1.Visible = false;
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.BackColor = System.Drawing.Color.White;
            this.userControlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRegister1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRegister1.Location = new System.Drawing.Point(262, 218);
            this.userControlRegister1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(938, 502);
            this.userControlRegister1.TabIndex = 0;
            this.userControlRegister1.Visible = false;
            // 
            // userControlTambahPelajar1
            // 
            this.userControlTambahPelajar1.BackColor = System.Drawing.Color.White;
            this.userControlTambahPelajar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTambahPelajar1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlTambahPelajar1.Location = new System.Drawing.Point(262, 218);
            this.userControlTambahPelajar1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlTambahPelajar1.Name = "userControlTambahPelajar1";
            this.userControlTambahPelajar1.Size = new System.Drawing.Size(938, 502);
            this.userControlTambahPelajar1.TabIndex = 0;
            this.userControlTambahPelajar1.Visible = false;
            // 
            // userControlKelas1
            // 
            this.userControlKelas1.BackColor = System.Drawing.Color.White;
            this.userControlKelas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlKelas1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlKelas1.Location = new System.Drawing.Point(262, 218);
            this.userControlKelas1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlKelas1.Name = "userControlKelas1";
            this.userControlKelas1.Size = new System.Drawing.Size(938, 502);
            this.userControlKelas1.TabIndex = 0;
            this.userControlKelas1.Visible = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlDashboard1.Location = new System.Drawing.Point(262, 218);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(938, 502);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlLaporan1
            // 
            this.userControlLaporan1.BackColor = System.Drawing.Color.White;
            this.userControlLaporan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLaporan1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlLaporan1.Location = new System.Drawing.Point(262, 218);
            this.userControlLaporan1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlLaporan1.Name = "userControlLaporan1";
            this.userControlLaporan1.Size = new System.Drawing.Size(938, 502);
            this.userControlLaporan1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.userControlLaporan1);
            this.Controls.Add(this.userControlKehadiran1);
            this.Controls.Add(this.userControlRegister1);
            this.Controls.Add(this.userControlTambahPelajar1);
            this.Controls.Add(this.userControlKelas1);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Kehadiran";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelExpand.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonAbsensi;
        private System.Windows.Forms.Button buttonKelas;
        private System.Windows.Forms.Button buttonPelajar;
        private System.Windows.Forms.Button buttonLaporan;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlKehadiran.UserControlDashboard userControlDashboard1;
        private UserControlKehadiran.UserControlKelas userControlKelas1;
        private UserControlKehadiran.UserControlTambahPelajar userControlTambahPelajar1;
        private UserControlKehadiran.UserControlRegister userControlRegister1;
        private UserControlKehadiran.UserControlKehadiran userControlKehadiran1;
        private UserControlKehadiran.UserControlLaporan userControlLaporan1;
    }
}
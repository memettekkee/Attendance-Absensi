namespace Kehadiran.PAL.UserControlKehadiran
{
    partial class UserControlKelas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlKelas = new System.Windows.Forms.TabControl();
            this.tabPageTambahKls = new System.Windows.Forms.TabPage();
            this.buttonTambahkan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPerempuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxLaki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxJumlahPljr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCariKls = new System.Windows.Forms.TabPage();
            this.labelHitungKls = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewKelas = new System.Windows.Forms.DataGridView();
            this.pictureBoxCari = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUPClass = new System.Windows.Forms.TabPage();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxUbhPrmpn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxUbhLK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxUbhPljr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxUbhNama = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlKelas.SuspendLayout();
            this.tabPageTambahKls.SuspendLayout();
            this.tabCariKls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCari)).BeginInit();
            this.tabPageUPClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlKelas
            // 
            this.tabControlKelas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlKelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlKelas.Controls.Add(this.tabPageTambahKls);
            this.tabControlKelas.Controls.Add(this.tabCariKls);
            this.tabControlKelas.Controls.Add(this.tabPageUPClass);
            this.tabControlKelas.Location = new System.Drawing.Point(0, 0);
            this.tabControlKelas.Name = "tabControlKelas";
            this.tabControlKelas.SelectedIndex = 0;
            this.tabControlKelas.Size = new System.Drawing.Size(942, 501);
            this.tabControlKelas.TabIndex = 0;
            // 
            // tabPageTambahKls
            // 
            this.tabPageTambahKls.Controls.Add(this.buttonTambahkan);
            this.tabPageTambahKls.Controls.Add(this.panel4);
            this.tabPageTambahKls.Controls.Add(this.textBoxPerempuan);
            this.tabPageTambahKls.Controls.Add(this.label5);
            this.tabPageTambahKls.Controls.Add(this.panel3);
            this.tabPageTambahKls.Controls.Add(this.textBoxLaki);
            this.tabPageTambahKls.Controls.Add(this.label4);
            this.tabPageTambahKls.Controls.Add(this.panel2);
            this.tabPageTambahKls.Controls.Add(this.textBoxJumlahPljr);
            this.tabPageTambahKls.Controls.Add(this.label3);
            this.tabPageTambahKls.Controls.Add(this.panel1);
            this.tabPageTambahKls.Controls.Add(this.textBoxNama);
            this.tabPageTambahKls.Controls.Add(this.label2);
            this.tabPageTambahKls.Controls.Add(this.label1);
            this.tabPageTambahKls.Location = new System.Drawing.Point(4, 4);
            this.tabPageTambahKls.Name = "tabPageTambahKls";
            this.tabPageTambahKls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTambahKls.Size = new System.Drawing.Size(934, 467);
            this.tabPageTambahKls.TabIndex = 0;
            this.tabPageTambahKls.Text = "Tambah Kelas";
            this.tabPageTambahKls.UseVisualStyleBackColor = true;
            this.tabPageTambahKls.Enter += new System.EventHandler(this.tabPageTambahKls_Enter);
            this.tabPageTambahKls.Leave += new System.EventHandler(this.tabPageTambahKls_Leave);
            // 
            // buttonTambahkan
            // 
            this.buttonTambahkan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTambahkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonTambahkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambahkan.FlatAppearance.BorderSize = 0;
            this.buttonTambahkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahkan.ForeColor = System.Drawing.Color.White;
            this.buttonTambahkan.Location = new System.Drawing.Point(115, 309);
            this.buttonTambahkan.Name = "buttonTambahkan";
            this.buttonTambahkan.Size = new System.Drawing.Size(120, 37);
            this.buttonTambahkan.TabIndex = 13;
            this.buttonTambahkan.Text = "Tambahkan";
            this.buttonTambahkan.UseVisualStyleBackColor = false;
            this.buttonTambahkan.Click += new System.EventHandler(this.buttonTambahkan_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(537, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 12;
            // 
            // textBoxPerempuan
            // 
            this.textBoxPerempuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPerempuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPerempuan.Location = new System.Drawing.Point(537, 244);
            this.textBoxPerempuan.Name = "textBoxPerempuan";
            this.textBoxPerempuan.Size = new System.Drawing.Size(270, 20);
            this.textBoxPerempuan.TabIndex = 11;
            this.textBoxPerempuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerempuan_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(534, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perempuan";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(115, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 9;
            // 
            // textBoxLaki
            // 
            this.textBoxLaki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLaki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLaki.Location = new System.Drawing.Point(115, 244);
            this.textBoxLaki.Name = "textBoxLaki";
            this.textBoxLaki.Size = new System.Drawing.Size(270, 20);
            this.textBoxLaki.TabIndex = 8;
            this.textBoxLaki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLaki_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(112, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Laki-Laki";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(538, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 6;
            // 
            // textBoxJumlahPljr
            // 
            this.textBoxJumlahPljr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxJumlahPljr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJumlahPljr.Location = new System.Drawing.Point(538, 151);
            this.textBoxJumlahPljr.Name = "textBoxJumlahPljr";
            this.textBoxJumlahPljr.Size = new System.Drawing.Size(270, 20);
            this.textBoxJumlahPljr.TabIndex = 5;
            this.textBoxJumlahPljr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJumlahPljr_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(535, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Berapa Pelajar?";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(115, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 3;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Location = new System.Drawing.Point(115, 151);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(270, 20);
            this.textBoxNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Kelas";
            // 
            // tabCariKls
            // 
            this.tabCariKls.BackColor = System.Drawing.Color.White;
            this.tabCariKls.Controls.Add(this.labelHitungKls);
            this.tabCariKls.Controls.Add(this.label8);
            this.tabCariKls.Controls.Add(this.dataGridViewKelas);
            this.tabCariKls.Controls.Add(this.pictureBoxCari);
            this.tabCariKls.Controls.Add(this.panel5);
            this.tabCariKls.Controls.Add(this.textBoxCari);
            this.tabCariKls.Controls.Add(this.label6);
            this.tabCariKls.Controls.Add(this.label7);
            this.tabCariKls.Location = new System.Drawing.Point(4, 4);
            this.tabCariKls.Name = "tabCariKls";
            this.tabCariKls.Padding = new System.Windows.Forms.Padding(3);
            this.tabCariKls.Size = new System.Drawing.Size(934, 467);
            this.tabCariKls.TabIndex = 1;
            this.tabCariKls.Text = "Cari Kelas";
            this.tabCariKls.Enter += new System.EventHandler(this.tabCariKls_Enter);
            // 
            // labelHitungKls
            // 
            this.labelHitungKls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHitungKls.AutoSize = true;
            this.labelHitungKls.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelHitungKls.Location = new System.Drawing.Point(837, 440);
            this.labelHitungKls.Name = "labelHitungKls";
            this.labelHitungKls.Size = new System.Drawing.Size(33, 21);
            this.labelHitungKls.TabIndex = 11;
            this.labelHitungKls.Text = "{?}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(737, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Kelas";
            // 
            // dataGridViewKelas
            // 
            this.dataGridViewKelas.AllowUserToAddRows = false;
            this.dataGridViewKelas.AllowUserToDeleteRows = false;
            this.dataGridViewKelas.AllowUserToResizeColumns = false;
            this.dataGridViewKelas.AllowUserToResizeRows = false;
            this.dataGridViewKelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKelas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewKelas.Location = new System.Drawing.Point(29, 143);
            this.dataGridViewKelas.Name = "dataGridViewKelas";
            this.dataGridViewKelas.ReadOnly = true;
            this.dataGridViewKelas.RowHeadersWidth = 51;
            this.dataGridViewKelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewKelas.RowTemplate.Height = 24;
            this.dataGridViewKelas.ShowCellErrors = false;
            this.dataGridViewKelas.ShowEditingIcon = false;
            this.dataGridViewKelas.ShowRowErrors = false;
            this.dataGridViewKelas.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewKelas.TabIndex = 9;
            this.dataGridViewKelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKelas_CellClick);
            // 
            // pictureBoxCari
            // 
            this.pictureBoxCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCari.Image = global::Kehadiran.Properties.Resources.serch;
            this.pictureBoxCari.Location = new System.Drawing.Point(406, 80);
            this.pictureBoxCari.Name = "pictureBoxCari";
            this.pictureBoxCari.Size = new System.Drawing.Size(19, 26);
            this.pictureBoxCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCari.TabIndex = 8;
            this.pictureBoxCari.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(155, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 7;
            // 
            // textBoxCari
            // 
            this.textBoxCari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCari.Location = new System.Drawing.Point(156, 86);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(270, 20);
            this.textBoxCari.TabIndex = 6;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(151, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label7.Location = new System.Drawing.Point(2, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cari Kelas";
            // 
            // tabPageUPClass
            // 
            this.tabPageUPClass.Controls.Add(this.buttonHapus);
            this.tabPageUPClass.Controls.Add(this.buttonUbah);
            this.tabPageUPClass.Controls.Add(this.panel6);
            this.tabPageUPClass.Controls.Add(this.textBoxUbhPrmpn);
            this.tabPageUPClass.Controls.Add(this.label10);
            this.tabPageUPClass.Controls.Add(this.panel7);
            this.tabPageUPClass.Controls.Add(this.textBoxUbhLK);
            this.tabPageUPClass.Controls.Add(this.label11);
            this.tabPageUPClass.Controls.Add(this.panel8);
            this.tabPageUPClass.Controls.Add(this.textBoxUbhPljr);
            this.tabPageUPClass.Controls.Add(this.label12);
            this.tabPageUPClass.Controls.Add(this.panel9);
            this.tabPageUPClass.Controls.Add(this.textBoxUbhNama);
            this.tabPageUPClass.Controls.Add(this.label13);
            this.tabPageUPClass.Controls.Add(this.label14);
            this.tabPageUPClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageUPClass.Name = "tabPageUPClass";
            this.tabPageUPClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUPClass.Size = new System.Drawing.Size(934, 467);
            this.tabPageUPClass.TabIndex = 2;
            this.tabPageUPClass.Text = "Rubah dan Hapus Kelas";
            this.tabPageUPClass.UseVisualStyleBackColor = true;
            this.tabPageUPClass.Leave += new System.EventHandler(this.tabPageUPClass_Leave);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHapus.FlatAppearance.BorderSize = 0;
            this.buttonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(265, 309);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(120, 37);
            this.buttonHapus.TabIndex = 28;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUbah.FlatAppearance.BorderSize = 0;
            this.buttonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.Location = new System.Drawing.Point(115, 309);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(120, 37);
            this.buttonUbah.TabIndex = 27;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(537, 268);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 26;
            // 
            // textBoxUbhPrmpn
            // 
            this.textBoxUbhPrmpn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUbhPrmpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUbhPrmpn.Location = new System.Drawing.Point(537, 244);
            this.textBoxUbhPrmpn.Name = "textBoxUbhPrmpn";
            this.textBoxUbhPrmpn.Size = new System.Drawing.Size(270, 20);
            this.textBoxUbhPrmpn.TabIndex = 25;
            this.textBoxUbhPrmpn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUbhPrmpn_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(534, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Perempuan";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(115, 268);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 23;
            // 
            // textBoxUbhLK
            // 
            this.textBoxUbhLK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUbhLK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUbhLK.Location = new System.Drawing.Point(115, 244);
            this.textBoxUbhLK.Name = "textBoxUbhLK";
            this.textBoxUbhLK.Size = new System.Drawing.Size(270, 20);
            this.textBoxUbhLK.TabIndex = 22;
            this.textBoxUbhLK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUbhLK_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(112, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Laki-Laki";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(538, 175);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 2);
            this.panel8.TabIndex = 20;
            // 
            // textBoxUbhPljr
            // 
            this.textBoxUbhPljr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUbhPljr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUbhPljr.Location = new System.Drawing.Point(538, 151);
            this.textBoxUbhPljr.Name = "textBoxUbhPljr";
            this.textBoxUbhPljr.Size = new System.Drawing.Size(270, 20);
            this.textBoxUbhPljr.TabIndex = 19;
            this.textBoxUbhPljr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUbhPljr_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(535, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Berapa Pelajar?";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(115, 175);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 2);
            this.panel9.TabIndex = 17;
            // 
            // textBoxUbhNama
            // 
            this.textBoxUbhNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUbhNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUbhNama.Location = new System.Drawing.Point(115, 151);
            this.textBoxUbhNama.Name = "textBoxUbhNama";
            this.textBoxUbhNama.Size = new System.Drawing.Size(270, 20);
            this.textBoxUbhNama.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(112, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nama";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label14.Location = new System.Drawing.Point(6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(230, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ubah dan Hapus Kelas";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Class_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Class_Name";
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Class_Total";
            this.Column3.HeaderText = "Berapa Pelajar?";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Class_Male";
            this.Column4.HeaderText = "Laki-Laki";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Class_Female";
            this.Column5.HeaderText = "Perempuan";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // UserControlKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlKelas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlKelas";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlKelas.ResumeLayout(false);
            this.tabPageTambahKls.ResumeLayout(false);
            this.tabPageTambahKls.PerformLayout();
            this.tabCariKls.ResumeLayout(false);
            this.tabCariKls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCari)).EndInit();
            this.tabPageUPClass.ResumeLayout(false);
            this.tabPageUPClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControlKelas;
        private System.Windows.Forms.TabPage tabPageTambahKls;
        private System.Windows.Forms.TabPage tabCariKls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxJumlahPljr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPerempuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxLaki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTambahkan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxCari;
        private System.Windows.Forms.DataGridView dataGridViewKelas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelHitungKls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageUPClass;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxUbhPrmpn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxUbhLK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxUbhPljr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxUbhNama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

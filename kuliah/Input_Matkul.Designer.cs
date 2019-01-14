namespace kuliah
{
    partial class Input_Matkul
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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sks_txt = new System.Windows.Forms.NumericUpDown();
            this.ruangan_txt = new System.Windows.Forms.ComboBox();
            this.waktu_txt = new System.Windows.Forms.ComboBox();
            this.semester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dosen_txt = new System.Windows.Forms.TextBox();
            this.matkul_txt = new System.Windows.Forms.TextBox();
            this.KodeMK_txt = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sks_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.ForestGreen;
            this.label13.Location = new System.Drawing.Point(11, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Universitas Nasional";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("News701 BT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.ForestGreen;
            this.label14.Location = new System.Drawing.Point(11, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mata Kuliah Mahasiswa";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.ForestGreen;
            this.label15.Location = new System.Drawing.Point(12, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Menginput";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.sks_txt);
            this.groupBox1.Controls.Add(this.ruangan_txt);
            this.groupBox1.Controls.Add(this.waktu_txt);
            this.groupBox1.Controls.Add(this.semester);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dosen_txt);
            this.groupBox1.Controls.Add(this.matkul_txt);
            this.groupBox1.Controls.Add(this.KodeMK_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 317);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menginput Mata Kuliah";
            // 
            // sks_txt
            // 
            this.sks_txt.Location = new System.Drawing.Point(116, 156);
            this.sks_txt.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sks_txt.Name = "sks_txt";
            this.sks_txt.Size = new System.Drawing.Size(64, 20);
            this.sks_txt.TabIndex = 4;
            // 
            // ruangan_txt
            // 
            this.ruangan_txt.FormattingEnabled = true;
            this.ruangan_txt.Items.AddRange(new object[] {
            "001 / BLOK 1",
            "002 / BLOK 1",
            "014 / BLOK 1",
            "004 / BLOK 1",
            "012 / BLOK 1",
            "003 / BLOK 1",
            "011 / BLOK 1",
            "005 / BLOK 1",
            "001 / BLOK 1",
            "010 / BLOK 1",
            "001 / BLOK 2",
            "002 / BLOK 2",
            "014 / BLOK 2",
            "004 / BLOK 2",
            "012 / BLOK 2",
            "003 / BLOK 2",
            "011 / BLOK 2",
            "005 / BLOK 2",
            "001 / BLOK 2",
            "010 / BLOK 2",
            "001 / BLOK 3",
            "002 / BLOK 3",
            "014 / BLOK 3",
            "004 / BLOK 3",
            "012 / BLOK 3",
            "003 / BLOK 3",
            "011 / BLOK 3",
            "005 / BLOK 3",
            "001 / BLOK 3",
            "010 / BLOK 3",
            "001 / BLOK 4",
            "002 / BLOK 4",
            "014 / BLOK 4",
            "004 / BLOK 4",
            "012 / BLOK 4",
            "003 / BLOK 4",
            "011 / BLOK 4",
            "005 / BLOK 4",
            "001 / BLOK 4",
            "RUANGAN DEKAN 1 / BLOK 5",
            "RUANGAN JARKOM / BLOK 4",
            "LABORATORIUM FISIP / BLOK 3",
            "AULA  / BLOK 1",
            "012 / MENARA UNAS 2",
            "003 / MENARA UNAS 2",
            "RUAGAN 012 LT 4 / MENARA UNAS 2",
            "RUAGAN 012 LT 2 / MENARA UNAS 2",
            "RUAGAN 123 LT 1 / MENARA UNAS 2",
            "RUAGAN 004 LT 6 / MENARA UNAS 2"});
            this.ruangan_txt.Location = new System.Drawing.Point(116, 240);
            this.ruangan_txt.Name = "ruangan_txt";
            this.ruangan_txt.Size = new System.Drawing.Size(169, 21);
            this.ruangan_txt.TabIndex = 6;
            // 
            // waktu_txt
            // 
            this.waktu_txt.FormattingEnabled = true;
            this.waktu_txt.Location = new System.Drawing.Point(116, 277);
            this.waktu_txt.Name = "waktu_txt";
            this.waktu_txt.Size = new System.Drawing.Size(169, 21);
            this.waktu_txt.TabIndex = 7;
            // 
            // semester
            // 
            this.semester.FormattingEnabled = true;
            this.semester.Items.AddRange(new object[] {
            "Semester-1",
            "Semester-2",
            "Semester-3",
            "Semester-4",
            "Semester-5",
            "Semester-6",
            "Semester-7"});
            this.semester.Location = new System.Drawing.Point(116, 115);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(141, 21);
            this.semester.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Waktu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SKS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ruangan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dosen Pengajar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Matkul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode MK";
            // 
            // dosen_txt
            // 
            this.dosen_txt.Location = new System.Drawing.Point(116, 194);
            this.dosen_txt.Name = "dosen_txt";
            this.dosen_txt.Size = new System.Drawing.Size(169, 20);
            this.dosen_txt.TabIndex = 5;
            // 
            // matkul_txt
            // 
            this.matkul_txt.Location = new System.Drawing.Point(116, 76);
            this.matkul_txt.Name = "matkul_txt";
            this.matkul_txt.Size = new System.Drawing.Size(169, 20);
            this.matkul_txt.TabIndex = 2;
            // 
            // KodeMK_txt
            // 
            this.KodeMK_txt.BackColor = System.Drawing.Color.ForestGreen;
            this.KodeMK_txt.Location = new System.Drawing.Point(116, 36);
            this.KodeMK_txt.Name = "KodeMK_txt";
            this.KodeMK_txt.Size = new System.Drawing.Size(169, 20);
            this.KodeMK_txt.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(266, 472);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(84, 36);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(166, 471);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(77, 36);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::kuliah.Properties.Resources.images_1;
            this.pictureBox2.Location = new System.Drawing.Point(-9, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Input_Matkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(369, 520);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(385, 558);
            this.MinimumSize = new System.Drawing.Size(385, 558);
            this.Name = "Input_Matkul";
            this.Text = "Menginput  Database Mata Kuliah";
            this.Load += new System.EventHandler(this.Input_Matkul_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sks_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown sks_txt;
        private System.Windows.Forms.ComboBox waktu_txt;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dosen_txt;
        private System.Windows.Forms.TextBox matkul_txt;
        private System.Windows.Forms.TextBox KodeMK_txt;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox ruangan_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save_btn;
    }
}
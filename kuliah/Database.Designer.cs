namespace kuliah
{
    partial class Database
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyword_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.list_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.database_gridview = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kategori_st = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.keyword_st = new System.Windows.Forms.TextBox();
            this.list_st = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_gridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.keyword_cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.list_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tampilkan data berdasarkan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // keyword_cb
            // 
            this.keyword_cb.FormattingEnabled = true;
            this.keyword_cb.Location = new System.Drawing.Point(386, 34);
            this.keyword_cb.Name = "keyword_cb";
            this.keyword_cb.Size = new System.Drawing.Size(146, 21);
            this.keyword_cb.TabIndex = 14;
            this.keyword_cb.SelectedIndexChanged += new System.EventHandler(this.keyword_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "*masukan keyword terlebih dahulu ,kemudian klick searching";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // list_txt
            // 
            this.list_txt.FormattingEnabled = true;
            this.list_txt.Location = new System.Drawing.Point(79, 34);
            this.list_txt.Name = "list_txt";
            this.list_txt.Size = new System.Drawing.Size(150, 21);
            this.list_txt.TabIndex = 13;
            this.list_txt.SelectedIndexChanged += new System.EventHandler(this.list_txt_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(545, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Searching";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keyword";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(511, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(410, 19);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(76, 40);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // database_gridview
            // 
            this.database_gridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.database_gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.database_gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.database_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.database_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_gridview.GridColor = System.Drawing.SystemColors.Highlight;
            this.database_gridview.Location = new System.Drawing.Point(12, 313);
            this.database_gridview.Name = "database_gridview";
            this.database_gridview.Size = new System.Drawing.Size(632, 188);
            this.database_gridview.TabIndex = 7;
            this.database_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_gridview_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(581, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Database";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // kategori_st
            // 
            this.kategori_st.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.kategori_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori_st.Location = new System.Drawing.Point(146, 563);
            this.kategori_st.Multiline = true;
            this.kategori_st.Name = "kategori_st";
            this.kategori_st.Size = new System.Drawing.Size(153, 28);
            this.kategori_st.TabIndex = 10;
            this.kategori_st.Text = " ";
            this.kategori_st.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(-1, 563);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(57, 28);
            this.textBox16.TabIndex = 11;
            this.textBox16.Text = "Status ";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "Biodata Mahasiswa",
            "Biodata Dosen",
            "Daftar Mata Kuliah",
            "Daftar Nilai Mahasiswa",
            "Daftar Matkul Mahasiswa"});
            this.kategori.Location = new System.Drawing.Point(92, 30);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(177, 21);
            this.kategori.TabIndex = 13;
            this.kategori.SelectedIndexChanged += new System.EventHandler(this.kategori_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.kategori);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 76);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("News701 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Database Universitas Nasional";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("News701 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Sistem Akademik Offline";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("News701 BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Selamat Datang...";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(51, 563);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Database";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // keyword_st
            // 
            this.keyword_st.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.keyword_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyword_st.Location = new System.Drawing.Point(398, 563);
            this.keyword_st.Multiline = true;
            this.keyword_st.Name = "keyword_st";
            this.keyword_st.Size = new System.Drawing.Size(262, 28);
            this.keyword_st.TabIndex = 10;
            this.keyword_st.Text = " ";
            this.keyword_st.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // list_st
            // 
            this.list_st.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.list_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_st.Location = new System.Drawing.Point(295, 563);
            this.list_st.Multiline = true;
            this.list_st.Name = "list_st";
            this.list_st.Size = new System.Drawing.Size(109, 28);
            this.list_st.TabIndex = 10;
            this.list_st.Text = " ";
            this.list_st.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MediumAquamarine;
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::kuliah.Properties.Resources.images_1;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(666, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(659, 592);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.list_st);
            this.Controls.Add(this.keyword_st);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kategori_st);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.database_gridview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Database";
            this.Text = "Database Universitas Nasional";
            this.Load += new System.EventHandler(this.Database_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_gridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView database_gridview;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kategori_st;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox list_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox keyword_cb;
        private System.Windows.Forms.TextBox keyword_st;
        private System.Windows.Forms.TextBox list_st;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
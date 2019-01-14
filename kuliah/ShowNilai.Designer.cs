namespace kuliah
{
    partial class ShowNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowNilai));
            this.button2 = new System.Windows.Forms.Button();
            this.close_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Viewall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seaching = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(375, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // close_show
            // 
            this.close_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_show.Location = new System.Drawing.Point(544, 445);
            this.close_show.Name = "close_show";
            this.close_show.Size = new System.Drawing.Size(76, 41);
            this.close_show.TabIndex = 1;
            this.close_show.Text = "Close";
            this.close_show.UseVisualStyleBackColor = true;
            this.close_show.Click += new System.EventHandler(this.close_show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(14, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(606, 333);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nama_txt
            // 
            this.nama_txt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nama_txt.Location = new System.Drawing.Point(192, 55);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(177, 20);
            this.nama_txt.TabIndex = 1;
            this.nama_txt.TextChanged += new System.EventHandler(this.nama_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Masukan Npm Mahasiswa :";
            // 
            // Viewall
            // 
            this.Viewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewall.Location = new System.Drawing.Point(544, 46);
            this.Viewall.Name = "Viewall";
            this.Viewall.Size = new System.Drawing.Size(60, 37);
            this.Viewall.TabIndex = 4;
            this.Viewall.Text = "View All";
            this.Viewall.UseVisualStyleBackColor = true;
            this.Viewall.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "*mohon masukan keyword dengan benar.";
            // 
            // seaching
            // 
            this.seaching.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seaching.Location = new System.Drawing.Point(457, 46);
            this.seaching.Name = "seaching";
            this.seaching.Size = new System.Drawing.Size(66, 38);
            this.seaching.TabIndex = 3;
            this.seaching.Text = "Seaching";
            this.seaching.UseVisualStyleBackColor = true;
            this.seaching.Click += new System.EventHandler(this.seaching_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Daftar Nilai Mahasiswa";
            // 
            // ShowNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 498);
            this.Controls.Add(this.seaching);
            this.Controls.Add(this.Viewall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_show);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(670, 548);
            this.Name = "ShowNilai";
            this.Text = "Daftar Nilai Mahasiswa";
            this.Load += new System.EventHandler(this.ShowNilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button close_show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Viewall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seaching;
        private System.Windows.Forms.Label label3;
    }
}
namespace kuliah
{
    partial class Daftar_Dosen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kategori_dosen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // View_btn
            // 
            this.View_btn.Location = new System.Drawing.Point(288, 28);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(54, 32);
            this.View_btn.TabIndex = 1;
            this.View_btn.Text = "View";
            this.View_btn.UseVisualStyleBackColor = true;
            this.View_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori";
            // 
            // kategori_dosen
            // 
            this.kategori_dosen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kategori_dosen.FormattingEnabled = true;
            this.kategori_dosen.Items.AddRange(new object[] {
            "Semester-1",
            "Semester-2",
            "Semester-3",
            "Semester-4",
            "Semester-5",
            "Semester-6",
            "Semester-7"});
            this.kategori_dosen.Location = new System.Drawing.Point(107, 35);
            this.kategori_dosen.Name = "kategori_dosen";
            this.kategori_dosen.Size = new System.Drawing.Size(155, 21);
            this.kategori_dosen.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.View_btn);
            this.groupBox1.Controls.Add(this.kategori_dosen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tampilkan daftar Dosen berdasarkan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Daftar_Dosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Daftar_Dosen";
            this.Text = "Daftar_Dosen";
            this.Load += new System.EventHandler(this.Daftar_Dosen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kategori_dosen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
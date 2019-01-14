namespace kuliah
{
    partial class Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            this.button1 = new System.Windows.Forms.Button();
            this.npm1_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.status_txt1 = new System.Windows.Forms.ComboBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Signup1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(437, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // npm1_txt
            // 
            this.npm1_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.npm1_txt.Location = new System.Drawing.Point(352, 108);
            this.npm1_txt.Name = "npm1_txt";
            this.npm1_txt.Size = new System.Drawing.Size(152, 20);
            this.npm1_txt.TabIndex = 1;
            this.npm1_txt.TextChanged += new System.EventHandler(this.npm1_txt_TextChanged);
            this.npm1_txt.Enter += new System.EventHandler(this.npm1_txt_Enter);
            this.npm1_txt.Leave += new System.EventHandler(this.npm1_txt_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "NPM / NIK";
            // 
            // status_txt1
            // 
            this.status_txt1.FormattingEnabled = true;
            this.status_txt1.Items.AddRange(new object[] {
            "Mahasiswa",
            "Dosen"});
            this.status_txt1.Location = new System.Drawing.Point(352, 206);
            this.status_txt1.Name = "status_txt1";
            this.status_txt1.Size = new System.Drawing.Size(114, 21);
            this.status_txt1.TabIndex = 2;
            // 
            // pass_txt
            // 
            this.pass_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pass_txt.Location = new System.Drawing.Point(352, 156);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(152, 20);
            this.pass_txt.TabIndex = 1;
            this.pass_txt.UseSystemPasswordChar = true;
            this.pass_txt.Enter += new System.EventHandler(this.pass_txt_Enter);
            this.pass_txt.Leave += new System.EventHandler(this.pass_txt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "as  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "LAMAN LOGIN  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(240, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(302, 44);
            this.label12.TabIndex = 1;
            this.label12.Text = "SISTEM AKADEMIK OFFLINE\r\n   UNIVERSITAS NASIONAL";
            // 
            // Signup1
            // 
            this.Signup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup1.Location = new System.Drawing.Point(319, 275);
            this.Signup1.Name = "Signup1";
            this.Signup1.Size = new System.Drawing.Size(87, 34);
            this.Signup1.TabIndex = 0;
            this.Signup1.Text = "Sign Up";
            this.Signup1.UseVisualStyleBackColor = true;
            this.Signup1.Click += new System.EventHandler(this.Signup1_Click);
            // 
            // Login1
            // 
            this.BackgroundImage = global::kuliah.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(775, 392);
            this.Controls.Add(this.status_txt1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.npm1_txt);
            this.Controls.Add(this.Signup1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login1";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox npm_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login1_btn;
        private System.Windows.Forms.ComboBox status_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox npm1_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox status_txt1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Signup1;
    }
}
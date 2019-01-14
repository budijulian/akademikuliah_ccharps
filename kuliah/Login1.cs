using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace kuliah
{
    public partial class Login1 : Form
    {

        public Login1()
        {
            InitializeComponent();
        }

        
        /*public string LoginNPM
        {
            get { return this.NPM; }
            set { this.NPM = value; }
        }
        public string Loginpassword
        {
            get { return this.password; }
            set { this.password = value; }
        }
        */
        private void Login1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pass_txt; // mengalihkan kunsor aktive  daritexbox npmtext
            npm1_txt.GotFocus += new EventHandler(this.npmtext_fokus);
            npm1_txt.LostFocus += new EventHandler(this.npmtext_lost);

            this.ActiveControl = npm1_txt; // mengalihkan kunsor aktive  daritexbox npmtext
            pass_txt.GotFocus += new EventHandler(this.passtext_fokus);
            pass_txt.LostFocus += new EventHandler(this.passtext_lost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void login1_btn_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NPM_txt_Enter(object sender, EventArgs e)
        {
            

        }
    
        private void npm_text_TextChanged(object sender, EventArgs e)
        {

        }
        public void npmtext_fokus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "Masukan NPM / NIK Anda")
            {
                t.Text = "";
                npm1_txt.ForeColor = Color.Black;
            }
        }

        public void npmtext_lost(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = "Masukan NPM / NIK Anda";
                npm1_txt.ForeColor = Color.Silver;
            }
        }
        public void passtext_fokus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "********")
            {
                t.Text = "";
                npm1_txt.ForeColor = Color.Black;
            }
        }
        public void passtext_lost(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = "********";
                npm1_txt.ForeColor = Color.Silver;
            }
        }

        private void npm1_txt_Enter(object sender, EventArgs e)
        {  /* // membuat bayangan dalam textbox
            if (npm1_txt.Text == "Masukan NPM / NIK Anda")
            {
                npm1_txt.Text = "";
                npm1_txt.ForeColor = Color.Black;
            }
            */
        }

        private void npm1_txt_Leave(object sender, EventArgs e)
        {   
            
            
        }

        private void pass_txt_Enter(object sender, EventArgs e)
        {    
        }

        private void pass_txt_Leave(object sender, EventArgs e)
        {
            
        }
         
        public string NPM;
        public string password;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   // sumber database
                string data = "datasource=localhost;database=data_mahasiswa;username=root;password=";

                if (status_txt1.Text == "Dosen")
                {
                    string akun = "SELECT NIK, password FROM akun_dosen";
                    MySqlConnection konek = new MySqlConnection(data);
                    // inisialisasi mysqlcomand
                    MySqlCommand CMD = new MySqlCommand(akun, konek);
                    konek.Open();
                    MySqlDataReader reader = CMD.ExecuteReader();

                    NPM = npm1_txt.Text;
                    password = pass_txt.Text;


                    while (reader.Read())
                    {
                        if ((NPM == reader.GetString(0)) && (password == reader.GetString(1)))
                        {
                            MessageBox.Show("Anda Berhasil Masuk");
                            //jika nik dan password benar ,program akan membuka form dosen

                            Home open1 = new Home();
                            open1.ShowDialog();
                            this.Hide();


                            konek.Close(); // menutup koneksi


                        }
                        else if ((NPM != reader.GetString(0)) && (password != reader.GetString(1)))
                        {

                        }
                    }
                    MessageBox.Show("NIK/NPM atau Password Anda Salah");// message akan muncul jika login anda salah

                }


                if (status_txt1.Text == "Mahasiswa")
                {
                    string akun = "SELECT NPM, password FROM akun_mahasiswa";
                    MySqlConnection konek = new MySqlConnection(data);
                    // inisialisasi mysqlcomand
                    MySqlCommand CMD = new MySqlCommand(akun, konek);
                    konek.Open();
                    MySqlDataReader reader = CMD.ExecuteReader();

                    string NPM = npm1_txt.Text;
                    string password = pass_txt.Text;


                    while (reader.Read())
                    {
                        if ((NPM == reader.GetString(0)) && (password == reader.GetString(1)))
                        {
                            MessageBox.Show("Anda Berhasil Masuk");
                            //jika nik dan password benar ,program akan membuka form mahasiswa



                            Mahasiswa open1 = new Mahasiswa();
                            open1.ShowDialog();
                            this.Hide();

                            konek.Close();

                        }
                        else if ((NPM != reader.GetString(0)) && (password != reader.GetString(1)))
                        {

                        }
                    }
                    MessageBox.Show("NIK/NPM atau Password Anda Salah"); // message akan muncul jika login anda salah
                }
            }
            catch (Exception)
            {

            }

        }

        private void Signup1_Click(object sender, EventArgs e)
        {
            SignUp open = new SignUp();
            open.ShowDialog();
        }

        private void npm1_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


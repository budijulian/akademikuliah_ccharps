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
    public partial class Input_Jadwal_Mahasiswa : Form
    {
        public Input_Jadwal_Mahasiswa()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sks_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sks_nup_ValueChanged(object sender, EventArgs e)
        {

                
            
        }

        private void Input_Jadwal_Mahasiswa_Load(object sender, EventArgs e)
        {

            string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
            //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
            string Query = "SELECT Npm FROM biodata";
            MySqlConnection koneksi = new MySqlConnection(MyConnet);
            MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
            //  membuka koneksi mycommand
            MySqlDataReader my;

            koneksi.Open();
            my = MyCommand.ExecuteReader();
            if (my.HasRows)
            {
                while (my.Read())
                {
                    // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                    //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                    Npm_txt.Text = my[0].ToString();
                }
            }

            // mematikan koneksi
            koneksi.Close();
            Npm_txt.Text = "";
            
            /*
             try
            {
                // mengisi data nama di combobox

                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                string Query = "SELECT NamaDepan,NamaBelakang FROM biodata;";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                //  membuka koneksi mycommand
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                        // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                        //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                        namaK_txt.Items.Add(my[3].ToString() + " " + my[4].ToString());
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            try
            {
                string Connect = "server=localhost;database=data_mahasiswa;username=root;password=";
                string TSKS = "SELECT SKS FROM mata_kuliah";
                MySqlConnection konek = new MySqlConnection(Connect);
                MySqlCommand Command1 = new MySqlCommand(TSKS, konek);
                MySqlDataReader sks;

                konek.Open();
                sks = Command1.ExecuteReader();
                if (sks.HasRows)
                {
                    while (sks.Read())
                    {
                        double sksmatkul1 = double.Parse(my[3].ToString());
                    }
                }

                // mematikan koneksi
                konek.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             * 
            if ((matkul1_txt.Text != null)||(matkul2_txt.Text != null)||(matkul3_txt.Text != null)||(matkul4_txt.Text != null)||(matkul5_txt.Text != null)||(matkul6_txt.Text != null)||(matkul7_txt.Text != null)||(matkul8_txt.Text != null)||(matkul9_txt.Text != null)||(matkul10_txt.Text != null))
            {
                double Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5 + sksmatkul6 + sksmatkul7 + sksmatkul8 + sksmatkul9 + sksmatkul10;
                 
                Tsks_ambil.Text = Tsks.ToString();
            }*/
            
        }
            
        private void tampil_txt_Click(object sender, EventArgs e)
        {
            if (semester_txt.Text == "Semester-1")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());

                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (semester_txt.Text == "Semester-2")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());

                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (semester_txt.Text == "Semester-3")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (semester_txt.Text == "Semester-4")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (semester_txt.Text == "Semester-5")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (semester_txt.Text == "Semester-6")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " / " + my[2].ToString() + " / " + my[3].ToString() + " SKS / " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());

                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (semester_txt.Text == "Semester-7")
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    //string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    string Query = "SELECT * FROM `mata_kuliah` WHERE Semester='" + semester_txt.Text + "';";
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open();
                    my = MyCommand.ExecuteReader();
                    if (my.HasRows)
                    {
                        while (my.Read())
                        {
                            // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                            //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                            matkul1_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul2_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul3_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul4_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul5_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul6_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul7_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul8_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul9_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());
                            matkul10_txt.Items.Add("[" + my[0].ToString() + "] " + my[1].ToString() + " | " + my[2].ToString() + " / " + my[3].ToString() + "SKS | " + my[4].ToString() + " / " + my[5].ToString() + " / " + my[6].ToString());

                        }
                    }

                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void semester_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public double sksmatkul1, sksmatkul2, sksmatkul3, sksmatkul4, sksmatkul5, sksmatkul6, sksmatkul7, sksmatkul8, sksmatkul9, sksmatkul10;
        public double Tsks;
        private void matkul1_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {   // mengambil nilai di table mata_kuliah dari urutan kolom ke [3]
                        sksmatkul1 = double.Parse(my[3].ToString());
                        // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                        Tsks_ambil.Text = sksmatkul1.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                string Query = "INSERT INTO `matkul_mahasiswa`(`Npm`, `NamaMahasiswa`,`Semester`,`TotalSKS`,`Mata_Kuliah_1`, `Mata_Kuliah_2`, `Mata_Kuliah_3`, `Mata_Kuliah_4`, `Mata_Kuliah_5`, `Mata_Kuliah_6`, `Mata_Kuliah_7`, `Mata_Kuliah_8`, `Mata_Kuliah_9`, `Mata_Kuliah_10`) VALUES ('" + this.Npm_txt.Text + "','" + this.Nama_txt.Text + "','" + this.semester_txt.Text + "','" + this.Tsks_txt.Text + "','" +this.matkul1_txt.Text + "','"+ this.matkul2_txt.Text + "','" + this.matkul3_txt.Text + "','" + this.matkul4_txt.Text + "','" + this.matkul5_txt.Text + "','" + this.matkul6_txt.Text + "','" + this.matkul7_txt.Text + "','" + this.matkul8_txt.Text + "','" + this.matkul9_txt.Text + "','" + this.matkul10_txt.Text + "');";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                       
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            MessageBox.Show("Apakah Anda Yakin Menyinpan Matkul ini","Save Data",MessageBoxButtons.YesNo);
            
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void matkul2_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul2 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul3 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2+sksmatkul3;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul4_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul4 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul5_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul5 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul6_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul6 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5 + sksmatkul6;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul7_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul6 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5 + sksmatkul6 + sksmatkul7;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul8_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul7 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5 + sksmatkul6 + sksmatkul7 + sksmatkul8;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul9_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul9 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5 + sksmatkul6 + sksmatkul7 + sksmatkul8 + sksmatkul9;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matkul10_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM mata_kuliah";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;

                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                         sksmatkul10 = double.Parse(my[3].ToString());
                         // menginput nilai SKS yang di dapatkan dari table SKS untuk di jumlahkan
                         Tsks = sksmatkul1 + sksmatkul2 + sksmatkul3 + sksmatkul4 + sksmatkul5 + sksmatkul6 + sksmatkul7 + sksmatkul8 + sksmatkul9 + sksmatkul10;
                         Tsks_ambil.Text = Tsks.ToString();
                    }
                }

                // mematikan koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Nama_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Npm_txt_Leave(object sender, EventArgs e)
        {
            if (Npm_txt.Text =="")
            {
                Npm_txt.Text = " masukan npm anda";
                Npm_txt.ForeColor = Color.Silver;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Nama_txt_Enter(object sender, EventArgs e)
        {
            if (Nama_txt.Text == " masukan nama lengkap anda")
            {
                Nama_txt.Text = "";
                Nama_txt.ForeColor = Color.Black;
            }
        }

        private void Nama_txt_Leave(object sender, EventArgs e)
        {
            if (Nama_txt.Text == "")
            {
                Nama_txt.Text = " masukan nama lengkap anda";
                Nama_txt.ForeColor = Color.Silver;
            }
        }
    }
}


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
    public partial class JadwalMahasiswa : Form
    {
        public JadwalMahasiswa()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void tambah_txt_Click(object sender, EventArgs e)
        {
            Input_Jadwal_Mahasiswa open = new Input_Jadwal_Mahasiswa();
            open.ShowDialog();
            this.Show();
        }

        private void tampil_txt_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JadwalMahasiswa_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // membersihkan listmatkul
                listmatkul_txt.Items.Clear();

                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                string Query = "SELECT * FROM matkul_mahasiswa WHERE NamaMahasiswa='" + this.nama_mahasiswa.Text + "';";
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                //data mulai dibaca oleh mysql
                MySqlDataReader my;
                
                koneksi.Open();
                my = MyCommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                        // berguna untuk menampilkan semua isi table mata_kuliah didalam database data_mahasiswa
                        //+ my[0].ToString() + berarti menampilkan semua value yang ad di dalam baris di kolom pertama
                        listmatkul_txt.Items.Add(my[4].ToString());
                        listmatkul_txt.Items.Add(my[5].ToString());
                        listmatkul_txt.Items.Add(my[6].ToString());
                        listmatkul_txt.Items.Add(my[7].ToString());
                        listmatkul_txt.Items.Add(my[8].ToString());
                        listmatkul_txt.Items.Add(my[9].ToString());
                        listmatkul_txt.Items.Add(my[10].ToString());
                        listmatkul_txt.Items.Add(my[11].ToString());
                        listmatkul_txt.Items.Add(my[12].ToString());
                        listmatkul_txt.Items.Add(my[13].ToString());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Daftar_Dosen open = new Daftar_Dosen();
            open.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listmatkul_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   
     }
}


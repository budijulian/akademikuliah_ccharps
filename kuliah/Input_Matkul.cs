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
    public partial class Input_Matkul : Form
    {
        public Input_Matkul()
        {
            InitializeComponent();
        }

        private void Input_Matkul_Load(object sender, EventArgs e)
        {
            // meninputkan waktu pda combo box waktu_txt
            waktu_txt.Items.Add("Senin / 08:00 - 10:00");
            waktu_txt.Items.Add("Senin / 10:10 - 12:10");
            waktu_txt.Items.Add("Senin / 13:20 - 15:00");
            waktu_txt.Items.Add("Senin / 15:10 - 17:00");
            waktu_txt.Items.Add("Senin / 18:00 - 19:30");
            waktu_txt.Items.Add("Senin / 19:40 - 20:30");
            waktu_txt.Items.Add("Senin / 20:30 - 22:00");
            waktu_txt.Items.Add("Selasa / 08:00 - 10:00");
            waktu_txt.Items.Add("Selasa / 10:10 - 12:10");
            waktu_txt.Items.Add("Selasa / 13:20 - 15:00");
            waktu_txt.Items.Add("Selasa / 15:10 - 17:00");
            waktu_txt.Items.Add("Selasa / 18:00 - 19:30");
            waktu_txt.Items.Add("Selasa / 19:40 - 20:30");
            waktu_txt.Items.Add("Selasa / 20:30 - 22:00");
            waktu_txt.Items.Add("Rabu / 08:00 - 10:00");
            waktu_txt.Items.Add("Rabu / 10:10 - 12:10");
            waktu_txt.Items.Add("Rabu / 13:20 - 15:00");
            waktu_txt.Items.Add("Rabu / 15:10 - 17:00");
            waktu_txt.Items.Add("Rabu / 18:00 - 19:30");
            waktu_txt.Items.Add("Rabu / 19:40 - 20:30");
            waktu_txt.Items.Add("Rabu / 20:30 - 22:00");
            waktu_txt.Items.Add("Kamis / 08:00 - 10:00");
            waktu_txt.Items.Add("Kamis / 10:10 - 12:10");
            waktu_txt.Items.Add("Kamis / 13:20 - 15:00");
            waktu_txt.Items.Add("Kamis / 15:10 - 17:00");
            waktu_txt.Items.Add("Kamis / 18:00 - 19:30");
            waktu_txt.Items.Add("Kamis / 19:40 - 20:30");
            waktu_txt.Items.Add("Kamis / 20:30 - 22:00");
            waktu_txt.Items.Add("Jumat / 08:00 - 10:00");
            waktu_txt.Items.Add("Jumat / 10:10 - 12:10");
            waktu_txt.Items.Add("Jumat / 13:20 - 15:00");
            waktu_txt.Items.Add("Jumat / 15:10 - 17:00");
            waktu_txt.Items.Add("Jumat / 18:00 - 19:30");
            waktu_txt.Items.Add("Jumat / 19:40 - 20:30");
            waktu_txt.Items.Add("Jumat / 20:30 - 22:00");
            waktu_txt.Items.Add("Sabtu / 08:00 - 10:00");
            waktu_txt.Items.Add("Sabtu / 10:10 - 12:10");
            waktu_txt.Items.Add("Sabtu / 13:20 - 15:00");
            waktu_txt.Items.Add("Sabtu / 15:10 - 17:00");
            waktu_txt.Items.Add("Sabtu / 18:00 - 19:30");
            waktu_txt.Items.Add("Sabtu / 19:40 - 20:30");
            waktu_txt.Items.Add("Sabtu / 20:30 - 22:00");
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // This is my Connection string  ke dalam koneksi database yang kita buat
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "insert into mata_kuliah(Kode_MK,Mata_Pelajaran,Semester,SKS,Dosen,Ruangan,Waktu) VALUE('" + KodeMK_txt.Text + "','" + matkul_txt.Text + "','" + semester.Text + "','" + sks_txt.Value.ToString() + "','" + dosen_txt.Text + "','" + ruangan_txt.Text + "','" + waktu_txt.Text + "');";

                // ini adalah syntax menghubungkan database dan menciptakan objek
                MySqlConnection koneksi = new MySqlConnection(MyConnet);

                MySqlCommand Command = new MySqlCommand(Query, koneksi);

                MySqlDataReader MyReader;

                koneksi.Open();
                MyReader = Command.ExecuteReader();

                while (MyReader.Read())
                {
                     
                }
                //kondisi data 
                if ((KodeMK_txt.Text == "") && (dosen_txt.Text == "") && (matkul_txt.Text == "") && (sks_txt.Value.ToString() == "") && (waktu_txt.Text == "") && (ruangan_txt.Text == ""))
                {
                    MessageBox.Show("Anda belum Menginputkan Satu Matkul Apapun");
                }
                else 
                {
                      MessageBox.Show("Anda Telah Menginputkan Satu Matkul");
                }
                //menutup koneksi ke database
                koneksi.Close();
                // membersihhkan layar
                KodeMK_txt.Text = "";
                dosen_txt.Text = "";
                matkul_txt.Text = "";
                waktu_txt.Text = "";
                ruangan_txt.Text = "";
                semester.Text = "";
                
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

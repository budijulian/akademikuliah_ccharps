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
    public partial class Daftar_Dosen : Form
    {
        public Daftar_Dosen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kategori_dosen.Text != null)
            {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query = "select * from mata_kuliah WHERE Semester='" + this.kategori_dosen.Text + "';";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);

                    // membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menyiapkan datatable  untuk menampung data dari datatable
                    DataTable tb = new DataTable();
                    //ambil data dari database
                    Mydataadapter.Fill(tb);

                    //bind data atau input data ke combobox
                    dataGridView1.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                    // sumber data dari nama kolom table

                    //menutup koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { }
        }

        private void Daftar_Dosen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select * from mata_kuliah WHERE 1;";

                // menghubungkan ke database server
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);

                // membuka koneksi mycommand
                koneksi.Open();
                MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                Mydataadapter.SelectCommand = MyCommand;

                //menyiapkan datatable  untuk menampung data dari datatable
                DataTable tb = new DataTable();
                //ambil data dari database
                Mydataadapter.Fill(tb);

                //bind data atau input data ke combobox
                dataGridView1.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

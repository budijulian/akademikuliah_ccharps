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
    public partial class Show_Nsiswa : Form
    {
        
        public Show_Nsiswa()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*string NPM2;
        public Show_Nsiswa(string terima)
        :this()
        {
            NPM2 = terima;
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            // menampilkan database ke datagridview
            string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
            string NPM2 = nama_S.Text; // berguna untuk mencari data di database yang kita ingin tampilkan
            string Query = "select * from nilai where NPM='" + NPM2 + "';";
            //string Query = "select * from nilai limit 3,4;"; // membatasi keluaran baris pada database >> ini urutan baris ke 4

            MySqlConnection koneksi = new MySqlConnection(MyConnet);
            MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);


            // 1 membuka koneksi mycommand
            koneksi.Open();
            MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
            Mydataadapter.SelectCommand = MyCommand;

            //menciptakan data table
            DataTable table = new DataTable();

            Mydataadapter.Fill(table);
            //menampilkan data yang tersimpan ke datagriview1
            dataGridView1.DataSource = table;

            //menutup koneksi
            koneksi.Close();
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Show_Nsiswa_Load(object sender, EventArgs e)
        {
            nama_S.Focus();
        }
    }
}

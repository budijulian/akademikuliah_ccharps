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
    public partial class ShowNilai : Form
    {
        public ShowNilai()
        {
            InitializeComponent();
        }

        private void ShowNilai_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void close_show_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                // This is my Connection string  ke dalam koneksi database yang kita buat
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                
                string nama = nama_txt.Text; // nama keyword yang akan dicari dan di delete

                string Query = "select * from nilai where NamaMahasiwa='" + nama.ToString() + "';";
                // ini adalah syntax menghubungkan database dan menciptakan objek
                MySqlConnection koneksi = new MySqlConnection(MyConnet);

                MySqlCommand Command = new MySqlCommand(Query, koneksi);

                // 1 membuka koneksi mycommand
                koneksi.Open();
                MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                Mydataadapter.SelectCommand = Command;

                //menciptakan data table
                DataTable table = new DataTable();

                Mydataadapter.Fill(table);
                //menampilkan data yang tersimpan ke datagriview1
                dataGridView1.DataSource = table;

                //menutup koneksi
                koneksi.Close();
                dataGridView1.ClearSelection();
                                
            }
            catch (Exception)
            {
                
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                // dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == berguna untuk menghapus kolom dan baris yang di seleksi
                string Query = "delete from nilai where Npm ='" + nama_txt.Text +"';";
                //  "','" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + 

                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                MySqlDataReader my;
                koneksi.Open(); //koneksi dihidupkan
                my = MyCommand.ExecuteReader(); // eksekusi di baca
                MessageBox.Show("Are you sure to remove this data?","Deleted",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                while (my.Read())
                { }

                MyCommand.ExecuteNonQuery();

                koneksi.Close();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            // menampilkan database ke datagridview
            string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";

            string Query = "select * from nilai;";
            //string Query = "select * from nilai limit 3,4;"; // membatasi keluaran baris pada database >> ini urutan baris ke 4

            // menghubungkan ke database server
            MySqlConnection koneksi = new MySqlConnection(MyConnet);
            MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);

            // membuka koneksi mycommand
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
            
        }

        private void nama_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seaching_Click(object sender, EventArgs e)
        {
            // menampilkan database ke datagridview
            string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
            string NPM = nama_txt.Text; // berguna untuk mencari data di database yang kita ingin tampilkan
            string Query = "select * from nilai where NPM='" + NPM + "';";
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
    }
}

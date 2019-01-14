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
    public partial class Database_nilai : Form
    {
        public Database_nilai()
        {
            InitializeComponent();
            
        }
        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Database_nilai_Load(object sender, EventArgs e)
        {
            try
            {  
                
                // menampilkan database ke combobox
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select NamaMahasiswa from nilai";

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
                namasiswa_txt.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                namasiswa_txt.DisplayMember = "NamaMahasiswa"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); // mendeteksi jika terjadi error / kesalahan
            }

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void namasiswa_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                try
                {
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    //query akan membaca semua nilai yang ada di dalam table nilai tergantung nama mahasiswa yang di pilih
                    string Query = "select * from nilai where NamaMahasiswa='" + namasiswa_txt.Text.ToString() + "';";

                    MySqlConnection koneksi = new MySqlConnection(MyConnet);
                    MySqlCommand MyCommand = new MySqlCommand(Query, koneksi);
                    MySqlDataReader my;

                    koneksi.Open(); //koneksi dihidupkan
                    my = MyCommand.ExecuteReader(); // eksekusi di baca

                    while (my.Read()) //sukse kebaca
                    {
                        
                        // metode fill
                        //nama_txt.Text = my.GetValue(index).ToString();
                        // berfungsi untuk mengambil nilai di table di kolom (index) 
                        // npm_txt.Text = my[0].ToString();
                        // getValue berfungsi untuk mengambil nilai yang ada di dala tabel dari indext kolom
                        npm_txt.Text = my.GetValue(0).ToString();
                        nama_txt.Text = my.GetValue(1).ToString();
                        sikap_txt.Text = my.GetValue(2).ToString();
                        tugas1_txt.Text = my.GetValue(3).ToString();
                        uts_txt.Text = my.GetValue(4).ToString();
                        tugas2_txt.Text = my.GetValue(5).ToString();
                        uas_txt.Text = my.GetValue(6).ToString();
                        total_nilai_txt.Text = my.GetValue(7).ToString();
                        grade_txt.Text = my.GetValue(8).ToString();
                        ip_txt.Text = my.GetValue(9).ToString();

                        
                    }

                    // menyamakan nama yang di cari ke status
                    st_nama.Text = namasiswa_txt.Text + "/" + npm_txt.Text;
                    // mematikan koneksi
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void npm_txt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }  
}

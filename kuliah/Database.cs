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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void kategori_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Database_Load(object sender, EventArgs e)
        {
            


        }

        private void list_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void database_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
       
        private void nilai_rb_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void matkul_rb_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void keyword_cb_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // LIST DARI BIODATA DOSEN
            
                if (list_txt.Text == "JenisKelaminD")
                {
                    string MyConnet1 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query1 = "SELECT NamaDepan,NamaBelakang,JenisKelaminD from dosen where JenisKelamin='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet1);
                    MySqlCommand MyCommand = new MySqlCommand(Query1, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";
                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "TahunLulusD")
                {
                    string MyConnet2 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query2 = "SELECT NamaDepan,NamaBelakang,TahunLulusD from dosen where TahunLulus='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet2);
                    MySqlCommand MyCommand = new MySqlCommand(Query2, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";
                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Gelar")
                {
                    string MyConnet3 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query3 = "SELECT NamaDepan,NamaBelakang,Gelar from dosen where Gelar='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet3);
                    MySqlCommand MyCommand = new MySqlCommand(Query3, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";
                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "UniversitasAsal")
                {
                    string MyConnet4 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query4 = "SELECT NamaDepan,NamaBelakang,UniversitasAsal from dosen where UniversitasAsal='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet4);
                    MySqlCommand MyCommand = new MySqlCommand(Query4, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();

                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;
                }
                else if (list_txt.Text == "FalkultasD")
                {
                    string MyConnet5 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query5 = "SELECT NamaDepan,NamaBelakang,FalkultasD from dosen where FalkultasD='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet5);
                    MySqlCommand MyCommand = new MySqlCommand(Query5, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "JurusanD")
                {
                    string MyConnet6 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query6 = "SELECT NamaDepan,NamaBelakang,JurusanD from dosen where JurusanD='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet6);
                    MySqlCommand MyCommand = new MySqlCommand(Query6, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;
                }
            
                //LIST DARI MATA KULIAH
                else if (list_txt.Text == "SKS")
                {
                    string MyConnet7 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query7 = "SELECT Kode_MK,Mata_Pelajaran,Dosen,SKS from mata_kuliah where SKS='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet7);
                    MySqlCommand MyCommand = new MySqlCommand(Query7, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Semester")
                {
                    string MyConnet7 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query7 = "SELECT Kode_MK,Mata_Pelajaran,Dosen,Semester from mata_kuliah where Semester='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet7);
                    MySqlCommand MyCommand = new MySqlCommand(Query7, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Ruangan")
                {
                    string MyConnet7 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query7 = "SELECT Kode_MK,Mata_Pelajaran,Dosen,Ruangan from mata_kuliah where Ruangan='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet7);
                    MySqlCommand MyCommand = new MySqlCommand(Query7, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Waktu")
                {
                    string MyConnet7 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query7 = "SELECT Kode_MK,Mata_Pelajaran,Dosen,Waktu from mata_kuliah where Waktu='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet7);
                    MySqlCommand MyCommand = new MySqlCommand(Query7, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
            
            
                // LIST DARI BIODATA MAHASISWA
                else if (list_txt.Text == "Jalur")
                {
                    string MyConnet6 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query6 = "SELECT NamaDepan,NamaBelakang,Jalur from biodata where Jalur='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet6);
                    MySqlCommand MyCommand = new MySqlCommand(Query6, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "JenisKelamin")
                {
                    string MyConnet8 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query8 = "SELECT NamaDepan,NamaBelakang,JenisKelamin from biodata where JenisKelamin='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet8);
                    MySqlCommand MyCommand = new MySqlCommand(Query8, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "TempatLahir")
                {
                    string MyConnet9 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query9 = "SELECT NamaDepan,NamaBelakang,TempatLahir from biodata where TempatLahir='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet9);
                    MySqlCommand MyCommand = new MySqlCommand(Query9, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;
                }
                else if (list_txt.Text == "TahunLulus")
                {
                    string MyConnet10 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query10 = "SELECT NamaDepan,NamaBelakang,TahunLulus from biodata where TahunLulus='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet10);
                    MySqlCommand MyCommand = new MySqlCommand(Query10, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Jurusan")
                {
                    string MyConnet11 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query11 = "SELECT namaDepan,NamaBelakang,Jurusan from biodata where Jurusan='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet11);
                    MySqlCommand MyCommand = new MySqlCommand(Query11, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Falkultas")
                {
                    string MyConnet12 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query12 = "SELECT NamaDepan,NamaBelakang,Falkultas from biodata where Falkultas='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet12);
                    MySqlCommand MyCommand = new MySqlCommand(Query12, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
                else if (list_txt.Text == "Angkatan")
                {
                    string MyConnet12 = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query12 = "SELECT NamaDepan,NamaBelakang,Angkatan from biodata where Angkatan='" + keyword_cb.Text + "'; ";

                    // menghubungkan ke database server
                    MySqlConnection koneksi = new MySqlConnection(MyConnet12);
                    MySqlCommand MyCommand = new MySqlCommand(Query12, koneksi);

                    // 1 membuka koneksi mycommand
                    koneksi.Open();
                    MySqlDataAdapter Mydataadapter = new MySqlDataAdapter();
                    Mydataadapter.SelectCommand = MyCommand;

                    //menciptakan data table
                    DataTable table = new DataTable();

                    Mydataadapter.Fill(table);
                    //menampilkan data yang tersimpan ke datagriview1
                    database_gridview.DataSource = table;

                    //menutup koneksi
                    koneksi.Close();
                    database_gridview.ClearSelection();
                    keyword_cb.Text = "";
                    list_txt.Text = "";

                    // membuat status bar
                    list_st.Text = list_txt.Text;
                    keyword_st.Text = keyword_cb.Text;

                }
            }
        
         
        private void update_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dosen_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void biodata_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void list_txt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
                //list dari biodata dosen
             if (list_txt.Text == "JenisKelaminD")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select JenisKelaminD from dosen";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "JenisKelaminD"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
             }
                
             if (list_txt.Text == "TahunLulusD")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select TahunLulusD from dosen";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "TahunLulusD"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "UniversitasAsal")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select UniversitasAsal from dosen";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "UniversitasAsal"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();

            }
            else if (list_txt.Text == "Gelar")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Gelar from dosen";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Gelar"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }

            else if (list_txt.Text == "FalkultasD")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select FalkultasD from dosen";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "FalkultasD"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "JurusanD")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select JurusanD from dosen";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "JurusanD"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            // memnampilkan data mata kuliah di keyword combobox
            else if (list_txt.Text == "SKS")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select SKS from mata_kuliah";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "SKS"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Semester")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Semester from mata_kuliah";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Semester"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Ruangan")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Ruangan from mata_kuliah";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Ruangan"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Waktu")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Waktu from mata_kuliah";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Waktu"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }

            // menampilkan data ke combox keyword dari table biodata mahasiswa
            else if (list_txt.Text == "JenisKelamin")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select JenisKelamin from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "JenisKelamin"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "TempatLahir")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select TempatLahir from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "TempatLahir"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "TahunLulus")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select TahunLulus from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "TahunLulus"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Falkultas")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Falkultas from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Falkultas"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Angkatan")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Angkatan from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Angkatan"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Jurusan")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Jurusan from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Jurusan"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
            else if (list_txt.Text == "Jalur")
            {
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "select Jalur from biodata";

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
                keyword_cb.DataSource = tb;  // sumber datatable disimpan ke combobox namasiswa_txt
                keyword_cb.DisplayMember = "Jalur"; // sumber data dari nama kolom table

                //menutup koneksi
                koneksi.Close();
            }
        }
        
        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (kategori.Text == "Daftar Nilai Mahasiswa")
            {
                Database_nilai open = new Database_nilai();
                open.ShowDialog();
                this.Show();
            }
            else if (kategori.Text == "Biodata Dosen")
            {
                //memberisihkan item list

                list_txt.Items.Clear();

                // menampilkan database ke datagridview
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";

                string Query = "SELECT `NIK`, `NamaDepan`, `NamaBelakang`, `TanggalLahirD`, `JenisKelaminD`, `TempatLahirD`, `TahunLulusD`, `Gelar`, `UniversitasAsal`, `FalkultasD`, `JurusanD`, `Alamat`, `Telepon`, `Password` FROM `dosen` WHERE 1";

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
                database_gridview.DataSource = table;
                database_gridview.ClearSelection();

                //menutup koneksi
                koneksi.Close();

                {   // mengisi item di list kategori dosen
                    list_txt.Items.Add("JenisKelaminD");
                    list_txt.Items.Add("TahunLulusD");
                    list_txt.Items.Add("Gelar");
                    list_txt.Items.Add("UniversitasAsal");
                    list_txt.Items.Add("FalkultasD");
                    list_txt.Items.Add("JurusanD");
                }
                // membuat status bar
                kategori_st.Text = kategori.Text;

            }
            else if (kategori.Text == "Daftar Mata Kuliah")
            {
                //memberisihkan item list

                list_txt.Items.Clear();


                // menampilkan database ke datagridview
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";

                string Query = "select * from mata_kuliah;";

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
                database_gridview.DataSource = table;

                database_gridview.ClearSelection(); // membersihkan sumber data
                //menutup koneksi
                koneksi.Close();

                // mengisi item di list kategori mata kuliah
                list_txt.Items.Add("SKS");
                list_txt.Items.Add("Semester");
                list_txt.Items.Add("Ruangan");
                list_txt.Items.Add("Waktu");
                // membuat status bar
                kategori_st.Text = kategori.Text;
            }
            else if (kategori.Text == "Biodata Mahasiswa")
            {
                //memberisihkan item list
                list_txt.Text = null;
                list_txt.Items.Clear();


                // menampilkan database ke datagridview
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT `Npm`, `Password`, `NamaDepan`, `NamaBelakang`, `TanggalLahir`, `JenisKelamin`, `TempatLahir`, `AsalSekolah`, `TahunLulus`, `Jurusan`, `Falkultas`, `Angkatan`, `Jalur`, `Alamat`, `Telepon` FROM `biodata` WHERE 1";

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
                database_gridview.DataSource = table;

                database_gridview.ClearSelection(); // membersihkan sumber data

                //menutup koneksi
                koneksi.Close();

                {   // mengisi item di list kategori  biodata
                    list_txt.Items.Add("Jalur");
                    list_txt.Items.Add("JenisKelamin");
                    list_txt.Items.Add("TempatLahir");
                    list_txt.Items.Add("TahunLulus");
                    list_txt.Items.Add("Jurusan");
                    list_txt.Items.Add("Falkultas");
                    list_txt.Items.Add("Angkatan");
                }
                // membuat status bar
                kategori_st.Text = kategori.Text;
            }
            else if (kategori.Text == "Daftar Matkul Mahasiswa")
            {
                //memberisihkan item list
                list_txt.Text = null;
                list_txt.Items.Clear();


                // menampilkan database ke datagridview
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "SELECT * FROM matkul_mahasiswa";
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
                database_gridview.DataSource = table;

                database_gridview.ClearSelection(); // membersihkan sumber data

                //menutup koneksi
                koneksi.Close();

                {   // mengisi item di list kategori  biodata
                    list_txt.Items.Add("Semester");
                }
                // membuat status bar
                kategori_st.Text = kategori.Text;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void keyword_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}

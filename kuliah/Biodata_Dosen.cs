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
using System.IO;

namespace kuliah
{
    public partial class Biodata_Dosen : Form
    {
        public Biodata_Dosen()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream open = new MemoryStream();
                pictureBox1.Image.Save(open, pictureBox1.Image.RawFormat);
                byte[] img = open.ToArray();

                // Query dan koneksi ke database
                string tanggal_lahir = "" + tgl.Text + "/" + bln.Text + "/" + thn.Text;
                // This is my Connection string  ke dalam koneksi database yang kita buat
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                string Query = "insert into dosen(NIK,NamaDepan,NamaBelakang,Image,TanggalLahir,JenisKelamin,TempatLahir,TahunLulus,Gelar,UniversitasAsal,Falkultas,Jurusan,Alamat,Telepon,Password) VALUE(@nik,@namad,@namab,@image,@tgllahir,@sex,@tmplahir,@lulus,@gelar,@universitas,@falkultas,@jurusan,@alamat,@telepon,@password)";

                // ini adalah syntax menghubungkan database dan menciptakan objek
                MySqlConnection koneksi = new MySqlConnection(MyConnet);
                koneksi.Open();

                MySqlCommand Command = new MySqlCommand(Query, koneksi);

                // meninputkan value ke database dari parameter
                Command.Parameters.Add("@nik", MySqlDbType.VarChar, 25);
                Command.Parameters.Add("@namad", MySqlDbType.VarChar, 20);
                Command.Parameters.Add("@namab", MySqlDbType.VarChar, 30);
                Command.Parameters.Add("@image", MySqlDbType.Blob);
                Command.Parameters.Add("@tgllahir", MySqlDbType.VarChar, 25);
                Command.Parameters.Add("@sex", MySqlDbType.VarChar, 5);
                Command.Parameters.Add("@tmplahir", MySqlDbType.VarChar, 20);
                Command.Parameters.Add("@lulus", MySqlDbType.VarChar, 20);
                Command.Parameters.Add("@gelar", MySqlDbType.VarChar, 5);
                Command.Parameters.Add("@universitas", MySqlDbType.VarChar, 40);
                Command.Parameters.Add("@falkultas", MySqlDbType.VarChar, 40);
                Command.Parameters.Add("@jurusan", MySqlDbType.VarChar, 20); 
                Command.Parameters.Add("@alamat", MySqlDbType.VarChar, 50);
                Command.Parameters.Add("@telepon", MySqlDbType.VarChar, 20);
                Command.Parameters.Add("@password", MySqlDbType.VarChar, 20);

                // mengambil  nilai dari program
                Command.Parameters["@nik"].Value = npmB_txt.Text;
                Command.Parameters["@namad"].Value = namad_txt.Text;
                Command.Parameters["@namab"].Value = namab_txt.Text;
                Command.Parameters["@image"].Value = img;
                Command.Parameters["@tgllahir"].Value = tgl.Text;
                Command.Parameters["@sex"].Value = sex_txt.Text;
                Command.Parameters["@tmplahir"].Value = tmptlahir.Text;
                Command.Parameters["@gelar"].Value = gelar_txt.Text;
                Command.Parameters["@universitas"].Value = Univer_txt.Text;
                Command.Parameters["@lulus"].Value = tahun_lulus_txt.Text;
                Command.Parameters["@jurusan"].Value = jurusan_txt.Text;
                Command.Parameters["@falkultas"].Value = falkultas_txt.Text;
                Command.Parameters["@alamat"].Value = alamat_txt.Text;
                Command.Parameters["@telepon"].Value = telepon_txt.Text;
                Command.Parameters["@password"].Value = password_txt.Text;

                if (Command.ExecuteNonQuery() == 1) //kondisi jika file dimasukan satu kali maka pernyataan bernilai benar
                {
                    MessageBox.Show("Apakah kamu yakin menyimpan data ini??","Simpan Data",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                }

                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //  membersihkan textbox dan combobox dan picture
            npmB_txt.Text = "";
            gambar.Text = "";
            namad_txt.Text = "";
            namab_txt.Text = "";
            pictureBox1.Image = null;
            tgl.Text = "";
            bln.Text = "";
            thn.Text = "";
            tmptlahir.Text = "";
            sex_txt.Text = "";
            gelar_txt.Text = "";
            Univer_txt.Text = "";
            tahun_lulus_txt.Text = "";
            jurusan_txt.Text = "";
            falkultas_txt.Text = "";
            tahun_lulus_txt.Text = "";
            gelar_txt.Text = "";
            alamat_txt.Text = "";
            telepon_txt.Text = "";
            password_txt.Text = "";
        
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog(); //membuat objek untuk memanggil file
            openFile.Filter = "Choose Image(*.*;*.jpg;*.png;*.gif)|*.*;*.jpg;*.png;*.gif"; //type dari file gambar
            if (openFile.ShowDialog() == DialogResult.OK) //memunculkan form dialog untuk memnuculkan objek gambar 
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

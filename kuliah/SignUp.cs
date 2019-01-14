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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Mahasiswa_rb.Checked)
            {
                try
                {

                    string tanggal_lahir = "" + tgl.Text + "/" + bln.Text + "/" + thn.Text;

                    // This is my Connection string  ke dalam koneksi database yang kita buat
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query = "insert into akun_mahasiswa(Npm,Password,NamaDepan,NamaBelakang,TanggalLahir,JenisKelamin,Jurusan,Falkultas,TahunMasuk) VALUE('" + this.npm_text.Text + "','" + this.pass_text.Text + "','" + this.namad_text.Text + "','" + this.namab_text.Text + "','" + tanggal_lahir.ToString() + "','" + this.sex_txt.SelectedItem.ToString() + "','" + this.jurusan.Text + "','" + this.falkultas.Text + "','" + this.angkatan_text.SelectedItem.ToString() + "');";

                    // ini adalah syntax menghubungkan database dan menciptakan objek
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);

                    MySqlCommand Command = new MySqlCommand(Query, koneksi);

                    MySqlDataReader MyReader;

                    koneksi.Open();
                    MyReader = Command.ExecuteReader();

                    while (MyReader.Read())
                    {
                    }
                    koneksi.Close();

                    MessageBox.Show("Anda Terdaftar!!");

                    // mengkosongkan text
                    npm_text.Text = "";
                    pass_text.Text = "";
                    namab_text.Text = "";
                    namad_text.Text = "";
                    tgl.Text = "";
                    bln.Text = "";
                    thn.Text = "";
                    sex_txt.Text = "";
                    jurusan.Text = "";
                    falkultas.Text = "";
                    angkatan_text.Text = "";

                   

                }
                catch (Exception)
                {
                    MessageBox.Show("Akun Berhasil Dibuat");
                }
            }
            if (dosen_rb.Checked)
            {
                try
                {

                    string tanggal_lahir = "" + tgl.Text + "/" + bln.Text + "/" + thn.Text;

                    // This is my Connection string  ke dalam koneksi database yang kita buat
                    string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";
                    string Query = "INSERT INTO `akun_dosen`(`NIK`, `Password`, `Nama Depan`, `NamaBelakang`, `JenisKelamin`, `TahunMasuk`, `TanggalLahir`, `Falkultas`, `Jurusan`) VALUE('" + this.npm_text.Text + "','" + this.pass_text.Text + "','" + this.namad_text.Text + "','" + this.namab_text.Text + "','" + this.sex_txt.SelectedItem.ToString() + "','" + tanggal_lahir.ToString() + "','" + this.falkultas.Text + "','" + this.jurusan.Text + "','" + this.angkatan_text.SelectedItem.ToString() + "');";

                    // ini adalah syntax menghubungkan database dan menciptakan objek
                    MySqlConnection koneksi = new MySqlConnection(MyConnet);

                    MySqlCommand Command = new MySqlCommand(Query, koneksi);

                    MySqlDataReader MyReader;

                    koneksi.Open();
                    MyReader = Command.ExecuteReader();

                    while (MyReader.Read())
                    {
                    }
                    koneksi.Close();

                    MessageBox.Show("Anda Terdaftar!!");

                    // mengkosongkan text
                    npm_text.Text = "";
                    pass_text.Text = "";
                    namab_text.Text = "";
                    namad_text.Text = "";
                    tgl.Text = "";
                    bln.Text = "";
                    thn.Text = "";
                    sex_txt.Text = "";
                    jurusan.Text = "";
                    falkultas.Text = "";
                    angkatan_text.Text = "";
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("Akun Berhasil Dibuat");
                }
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // meletakan kunsor ke texbok NPm
            npm_text.Focus();
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void angkatan_text_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

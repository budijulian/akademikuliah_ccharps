using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuliah
{
    public partial class Mahasiswa : Form
    {
        public Mahasiswa()
        {
            InitializeComponent();
        }
        /*string nilainpm;
        public Mahasiswa(string terima)
        :this()
        {
            nilainpm = terima;
        }
       /* public string kirimMahasiswa
        {
            get
            {
                 string npm_login = "";
                return npm_login;
            }
        }*/
        private void cREATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputBiodata open = new InputBiodata();
            open.ShowDialog();
            this.Show();
        }

        private void Mahasiswa_Load(object sender, EventArgs e)
        {  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Show_Nsiswa open = new Show_Nsiswa();
            open.Show();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login1 login = new Login1();// kembali ke menu home atau login
            login.Show();
            this.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }


        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Show_Nsiswa open = new Show_Nsiswa();
            open.ShowDialog();
            this.Show();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp open = new SignUp();
            open.ShowDialog();
            this.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah kamu yakin menyimpan data ini??", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void showStudentCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void time_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputBiodata open = new InputBiodata();
            open.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JadwalMahasiswa open = new JadwalMahasiswa();
            open.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daftar_Dosen open = new Daftar_Dosen();
            open.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createStudentSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Home : Form
    {
        
        public Home()
        {
            
            InitializeComponent();
            
        }
        
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tAMPILToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Biodata_Dosen open = new Biodata_Dosen();
            open.ShowDialog();
            this.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input_Matkul open = new Input_Matkul();
            open.ShowDialog();
            this.Show();

        }

       
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login1 login = new Login1();
            login.Show(); // kembali ke menu home atau login
            
        }

        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login1 open = new Login1();
            open.ShowDialog();
            this.Show();
        }

        private void studentScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Nilai open = new Input_Nilai();
            open.ShowDialog();
            this.Show();
        }

        private void cREATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowNilai open = new ShowNilai();
            open.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void sTUDENTIDENTITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBiodata open = new InputBiodata();
            open.ShowDialog();
            this.Show();
        }

        private void createCurriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Matkul open = new Input_Matkul();
            open.ShowDialog();
            this.Show();
        }

        private void createTeachersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Biodata_Dosen open = new Biodata_Dosen();
            open.ShowDialog();
            this.Show();
        }

        private void showStudentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void time_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Database open = new Database();
            open.ShowDialog();
            this.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah kamu yakin menyimpan data ini??", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Input_Nilai open = new Input_Nilai();
            open.ShowDialog();
            this.Show();
        }
    }
}

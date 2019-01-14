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
    public partial class Input_Nilai : Form
    {
             
   
        public Input_Nilai()
        {
            InitializeComponent();
        }

        private void Input_Nilai_Load(object sender, EventArgs e)
        {
           
           nama_txt.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uts_TextChanged(object sender, EventArgs e)
        {

        }

        public void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }
        
        private void tambah_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                // mencari nilai total_nilai, grade, dan IPK
                double total;
                string grade=null;
                string ipk=null;
                double sikap, tugas_1, tugas_2, uts, uas;

                 sikap = double.Parse(sikap_text.Text);
                 tugas_1 = double.Parse(tugas1.Text);
                 tugas_2 = double.Parse(tugas2.Text);
                 uts = double.Parse(uts_txt.Text);
                 uas = double.Parse(uas_txt.Text);

                // mencari nilai total 
                total = sikap + tugas_1 + tugas_2 + uts + uas;
                                
                if (total >= 450)
                {
                    grade = "A";
                    ipk = "4,0";
                }
                else if ((total < 450) && (total >= 400))
                {
                    grade = "A-";
                    ipk = "3,7";
                }
                else if ((total < 400) && (total >= 350))
                {
                    grade = "B";
                    ipk = "3,5";
                }
                else if ((total < 350) && (total >= 300))
                {
                    grade = "B-";
                    ipk = "3,0";
                }
                else if ((total < 300) && (total >= 250))
                {
                    grade = "C";
                    ipk = "2,7";
                }
                else if ((total < 250) && (total >= 200))
                {
                    grade = "D";
                    ipk = "2,0";
                }
                   
                // This is my Connection string  ke dalam koneksi database yang kita buat
                string MyConnet = "server=localhost;database=data_mahasiswa;username=root;password=";

                string Query = "insert into nilai(Npm,NamaMahasiswa,Sikap,Tugas1,Uts,Tugas2,Uas,Total_Nilai,Grade,Ipk,Keterangan) VALUE('" + this.npm_txt.Text + "','" + this.nama_txt.Text + "','" + this.sikap_text.SelectedItem.ToString() + "','" + this.tugas1.Text + "','" + this.uts_txt.Text + "','" + this.tugas2.Text + "','" + this.uas_txt.Text + "','" + total.ToString() + "','" + grade.ToString() + "','" + ipk.ToString() + "','" + this.catatan_txt.Text + "');";

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

                MessageBox.Show("Data Tersimpan");
                // mengkosongkan text
                nama_txt.Text = "";
                npm_txt.Text = "";
                sikap_text.Text = "";
                tugas1.Text = "";
                uts_txt.Text = "";
                tugas2.Text = "";
                uas_txt.Text = "";
                catatan_txt.Text = "";

                // fokus ke texbox
                nama_txt.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
          
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowNilai open = new ShowNilai();
            open.Show();
            this.Show();
            
        }

        private void catatan_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

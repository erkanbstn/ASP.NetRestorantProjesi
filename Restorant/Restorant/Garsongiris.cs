using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restorant
{
    public partial class Garsongiris : Form
    {
        public Garsongiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand com;
        SqlDataAdapter da;
        SqlDataReader dr;
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Garsongiris_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            baglanti = new SqlConnection("Data Source=DESKTOP-320QSOJ;Initial Catalog=Restorant2;Integrated Security=True");
            com = new SqlCommand();
            baglanti.Open();
            com.Connection = baglanti;
            com.CommandText = "select * from Garson where Kullanıcı_Adı ='" + textBox1.Text + "'and Sifre ='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("giriş başarılı");
                GarsonPanel frm = new GarsonPanel();
                this.Hide();
                frm.ShowDialog();
                this.Close();



            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            baglanti.Close();

        }
    }
}

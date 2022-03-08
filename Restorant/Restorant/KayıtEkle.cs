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
    public partial class KayıtEkle : Form
    {
        public KayıtEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-320QSOJ;Initial Catalog=Restorant2;Integrated Security=True");
        DataTable tablo = new DataTable();  // tablo isiminde bir Datatable tanımladık.
        SqlCommand komut = new SqlCommand();
        private void listeleYonetici() //listele adında bir class belirledik. 
        {
            tablo.Clear(); //tabloyu temizledik 
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Yonetici", baglanti);
            // verileri SQL sorgusu ile adaptöre aktardık. 
            adtr.Fill(tablo); //adaptördeki verileri tablonun içine doldurduk. 
            dataGridView1.DataSource = tablo; //tablodaki verileri datagridview'e aktardık.
        }

        private void listeleGarson() //listele adında bir class belirledik. 
        {
            tablo.Clear(); //tabloyu temizledik 
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Garson", baglanti);
            // verileri SQL sorgusu ile adaptöre aktardık. 
            adtr.Fill(tablo); //adaptördeki verileri tablonun içine doldurduk. 
            dataGridView1.DataSource = tablo; //tablodaki verileri datagridview'e aktardık.
        }
        
        private void KayıtEkle_Load(object sender, EventArgs e)
        {
            listeleYonetici();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tikla;
            if (comboBox1.Text == "Garson")
            {

                if (textBox1.Text != "" & textBox2.Text != "")
                {
                    tikla = "Insert into garson(Kullanıcı_Adı,Sifre)values(@kul,@sif)";

                    SqlCommand komut = new SqlCommand(tikla, baglanti);
                    
                    komut.Parameters.AddWithValue("@kul", textBox1.Text);
                    komut.Parameters.AddWithValue("@sif", textBox2.Text);
                    komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.
                    MessageBox.Show("KAYIT EDİLDİ");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("düzgün girin");
                }
            }

            else
            {

                if (textBox1.Text != "" & textBox2.Text != "" )
                {

                    tikla = "Insert into Yonetici(Kullanıcı_Adı,Sifre)values(@kul,@sif)";

                    SqlCommand komut = new SqlCommand(tikla, baglanti);
                    komut.Parameters.AddWithValue("@kul", textBox1.Text);
                    komut.Parameters.AddWithValue("@sif", textBox2.Text);
                    komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.
                    MessageBox.Show("KAYIT EDİLDİ");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("düzgün girin");
                }

            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listeleGarson();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listeleYonetici();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                string sorgu = "DELETE FROM Yonetici WHERE Kullanıcı_Adı=@kln";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kln", dataGridView1.CurrentRow.Cells[0].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listeleYonetici();
            
           
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            YöneticiPanel frm = new YöneticiPanel();
            this.Close();
            frm.Show();
        }
    }
}

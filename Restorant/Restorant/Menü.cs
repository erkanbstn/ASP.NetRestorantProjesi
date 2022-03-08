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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-320QSOJ;Initial Catalog=Restorant2;Integrated Security=True");
        DataTable tablo = new DataTable();  // tablo isiminde bir Datatable tanımladık.
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
       public void verisil()
        {
            baglanti.Open();
            komut = new SqlCommand("DELETE FROM Urunler where UrunAdı ='" + textBox4.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" ÜRÜN SİLİNDİ");
            textBox4.Clear();


        }
        private void Menü_Load(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tikla;
           
                tikla = "Insert into Urunler(Kategori_ID,UrunAdı,Fiyat)values(@katıd,@ad,@fiyat)";
                SqlCommand komut = new SqlCommand(tikla, baglanti);
                komut.Parameters.AddWithValue("@katıd", textBox1.Text);
                komut.Parameters.AddWithValue("@ad", textBox2.Text);
                komut.Parameters.AddWithValue("@fiyat", textBox3.Text);
                tablo.Clear(); //tabloyu temizledik 
               

                komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.           
                MessageBox.Show("ÜRÜN EKLENDİ");
                textBox1.Clear(); 
                baglanti.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler Where Kategori_ID=1 ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler Where Kategori_ID=2 ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler Where Kategori_ID=3 ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler Where Kategori_ID=4 ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler Where Kategori_ID=5 ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler Where Kategori_ID=6 ", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From Urunler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "urunler");
            baglanti.Close();
            dataGridView2.DataSource = ds.Tables["Urunler"];
            dataGridView2.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verisil();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant
{
    public partial class YöneticiPanel : Form
    {
        public YöneticiPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtEkle kyt = new KayıtEkle();
            kyt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Yönetici_Giriş frm = new Yönetici_Giriş();
            this.Close();
            frm.Show();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Menü frm2 = new Menü();
            frm2.ShowDialog();
        }
    }
}

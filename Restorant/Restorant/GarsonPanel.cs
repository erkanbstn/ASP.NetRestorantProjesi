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
    public partial class GarsonPanel : Form
    {
        public GarsonPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GarsonPanel_Load(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Green;//butonun arkaplan renginin yeşil olmasını sağlıyoruz
            button3.BackColor = System.Drawing.Color.Green;
            button4.BackColor = System.Drawing.Color.Green;
            button5.BackColor = System.Drawing.Color.Green;
            button6.BackColor = System.Drawing.Color.Green;

        }
    }
}

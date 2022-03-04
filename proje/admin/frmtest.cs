using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje.admin
{
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text= sonuc.ToString();
        }

        private void btntekmiçiftmi_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            if(sayi%2==0)
            {
                label1.Text = "çift";
            }
            else
            {
                label1.Text = "tek";
            }
            
        }

        private void btnbasamak_Click(object sender, EventArgs e)
        {
            int sayi, birler, onlar, yüzler, toplam;
            sayi=Convert.ToInt32(textBox1.Text);
            birler = sayi %10;
            onlar = sayi / 10;
            yüzler = sayi / 10 % 10;
            toplam = birler + onlar + yüzler;
            label1.Text=toplam.ToString();
        }

        private void btnbakteri_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for(int i = 1;i<24;i++)
            {
                sayi = sayi * 2;
            }
            label1.Text=sayi.ToString();
        }
    }
}

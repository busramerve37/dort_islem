using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek12
{
    public partial class lblCarpim : Form
    {
        public lblCarpim()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, fark,carpim, bolme;

            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolme = sayi1 / sayi2;

            lblToplam.Text = "Toplam: " + toplam;
            lblFark.Text = "Fark:  " + fark;
            lblCarpma.Text = "Carpim:  " + carpim;
            lblBolme.Text = "Bolme: " + bolme;

        }
    }
}

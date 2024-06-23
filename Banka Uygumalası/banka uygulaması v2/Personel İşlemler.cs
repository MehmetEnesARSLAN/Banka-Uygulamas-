using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_uygulaması_v2
{
    public partial class Personel_İşlemler : Form
    {
        public Personel_İşlemler()
        {
            InitializeComponent();
        }

        private void btnGelirGiderRapor_Click(object sender, EventArgs e)
        {
            Banka_Gelir_Gider_Raporu banka_Gelir_Gider_Raporu = new Banka_Gelir_Gider_Raporu();
            banka_Gelir_Gider_Raporu.Show();
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            Hesap_Sil hesap_Sil = new Hesap_Sil();
            hesap_Sil.Show();
        }
    }
}

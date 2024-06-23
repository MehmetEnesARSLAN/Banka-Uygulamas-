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
    public partial class frmBankaUygulaması : Form
    {
        public frmBankaUygulaması()
        {
            InitializeComponent();
        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giriş_ekranı giriş_Ekranı = new giriş_ekranı();
            giriş_Ekranı.MdiParent = this;
            giriş_Ekranı.Show();
            
            
        }

        private void girişYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ticari_giriş_ekranı ticari_Giriş_Ekranı = new ticari_giriş_ekranı();
            ticari_Giriş_Ekranı.MdiParent = this;
            ticari_Giriş_Ekranı.Show();
        }

        private void girişYapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            personel_giriş_ekranı personel_Giriş_Ekranı = new personel_giriş_ekranı();
            personel_Giriş_Ekranı.MdiParent = this;
            personel_Giriş_Ekranı.Show();
        }

        private void bireyselToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bireysel_Hesap_Oluştur bireysel_Hesap_Oluştur = new Bireysel_Hesap_Oluştur();
            bireysel_Hesap_Oluştur.MdiParent = this;
            bireysel_Hesap_Oluştur.Show();

        }

        private void ticariToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ticari_hesap_oluştur ticari_Hesap_Oluştur = new Ticari_hesap_oluştur();
            ticari_Hesap_Oluştur.MdiParent = this;
            ticari_Hesap_Oluştur.Show();

        }
    }
}

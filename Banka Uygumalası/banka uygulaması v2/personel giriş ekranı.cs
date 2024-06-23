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
    public partial class personel_giriş_ekranı : Form
    {
        public personel_giriş_ekranı()
        {
            InitializeComponent();
        }

        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            if (txtŞifre.Text == "4321")
            {
            Personel_İşlemler personel_İşlemler = new Personel_İşlemler();
            personel_İşlemler.Show();
            }
            else
            {
                MessageBox.Show("Giriş yapılamadı.");
            }

            
        }
    }
}

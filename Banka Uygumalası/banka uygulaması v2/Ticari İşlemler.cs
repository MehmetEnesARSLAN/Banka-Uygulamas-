using Npgsql;
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
    public partial class Ticari_İşlemler : Form
    {
        public Ticari_İşlemler()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnÇekme_Click(object sender, EventArgs e)
        {
            Para_Çekme_Ticari para_Çekme_Ticari = new Para_Çekme_Ticari();
            para_Çekme_Ticari.Show();
        }

        private void btnYatırma_Click(object sender, EventArgs e)
        {
            Para_Yatırma_Ticari para_Yatırma_Ticari = new Para_Yatırma_Ticari();
            para_Yatırma_Ticari.Show();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            Havale_Yap_Ticari havale_Yap_Ticari = new Havale_Yap_Ticari();
            havale_Yap_Ticari.Show();
        }

        private void btnÖzet_Click(object sender, EventArgs e)
        {
            Hesap_Özeti hesap_Özeti = new Hesap_Özeti();
            hesap_Özeti.Show();
        }

        private void Ticari_İşlemler_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komutgiris = new NpgsqlCommand("select * from bireyselmusteri where hesapno like '" + txtHesapno.Text + "' ", baglantı);
            NpgsqlDataReader reader = komutgiris.ExecuteReader();


            while (reader.Read())
            {
                txtAd.Text = reader["ad"].ToString();
                txtSoyad.Text = reader["soyad"].ToString();
                txtHesapno.Text = reader["hesapno"].ToString();
                txtBakiye.Text = reader["bakiye"].ToString();


                if (reader[1] != null)
                {
                    txtAd.Enabled = true;
                    txtSoyad.Enabled = true;
                    txtHesapno.Enabled = true;
                    txtBakiye.Enabled = true;

                }
            }
            baglantı.Close();
        }
    }
    
}

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
    public partial class bireysel_işlemler : Form
    {
        public bireysel_işlemler()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnÇekme_Click(object sender, EventArgs e)
        {
            Para_Çekme para_Çekme = new Para_Çekme();
            para_Çekme.Show();
        }

        private void btnYatırma_Click(object sender, EventArgs e)
        {
            Para_Yatırma para_Yatırma = new Para_Yatırma();
            para_Yatırma.Show();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            Havale_Yap havale_Yap = new Havale_Yap();
            havale_Yap.Show();
        }

        private void btnÖzet_Click(object sender, EventArgs e)
        {
            Hesap_Özeti hesap_Özeti = new Hesap_Özeti();
            hesap_Özeti.Show();
        }

        private void bireysel_işlemler_Load(object sender, EventArgs e)
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

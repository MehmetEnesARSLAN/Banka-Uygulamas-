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
    public partial class ticari_giriş_ekranı : Form
    {
        public ticari_giriş_ekranı()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnGirişYapTicari_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from ticarimusteri where hesapno like  '" + txtHesapno.Text + "'", baglantı);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtAdTicari.Text == read["ad"].ToString())
                {
                    if (txtSoyadTicari.Text == read["soyad"].ToString())
                    {
                        if (txtŞifreTicari.Text == read["şifre"].ToString())
                        {
                            Ticari_İşlemler ticari_İşlemler = new Ticari_İşlemler();
                            ticari_İşlemler.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Giriş");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş");
                    }
                }
                else
                {
                    Ticari_İşlemler ticari_İşlemler = new Ticari_İşlemler();
                    ticari_İşlemler.Show();
                }

            }
            baglantı.Close();
        }
    }
}

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
    public partial class giriş_ekranı : Form
    {
        public giriş_ekranı()
        {
            InitializeComponent();
        }

        NpgsqlConnection con = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            con.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM bireyselmusteri WHERE hesapno=@hesapno AND şifre=@şifre", con);
            komut.Parameters.AddWithValue("@hesap_numarasi", txtHesapno.Text);
            komut.Parameters.AddWithValue("@sifre", txtŞifre.Text);

            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                bireysel_işlemler bireysel_İşlemler = new bireysel_işlemler();
                bireysel_İşlemler.Show();
            }
            else
            {
                MessageBox.Show("Hesap numaranız ya da şifreniz hatalı. Tekrar deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
    }
}

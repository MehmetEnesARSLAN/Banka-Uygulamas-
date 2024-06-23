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
    public partial class Bireysel_Hesap_Oluştur : Form
    {
        public Bireysel_Hesap_Oluştur()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnOluştur_Click(object sender, EventArgs e)
        {

            
            long previousRandomNumber = 0;

            Random rnd = new Random();
            int randomNumber = rnd.Next(100000000, 999999999);

            while (randomNumber == previousRandomNumber)
            {
                randomNumber = rnd.Next(100000000, 999999999);
            }
            previousRandomNumber = randomNumber;

            baglantı.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into bireyselmusteri (ad,soyad,şifre,telefon,hesapno,bakiye) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtŞifre.Text);
            komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", randomNumber);
            komut.Parameters.AddWithValue("@p6", 0);



            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(" HESAP OLUŞTURMA BAŞARILI." + 
                            "Hesap NO :" + randomNumber);
        }
    }
}

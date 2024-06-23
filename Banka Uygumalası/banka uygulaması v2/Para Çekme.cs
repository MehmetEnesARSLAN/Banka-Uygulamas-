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
    public partial class Para_Çekme : Form
    {
        public Para_Çekme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnÇek_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection())
            {
                connection.Open();

                string accountNumber = "";

                // Bakiyeyi oku
                string sql = "SELECT bakiye FROM bireyselmusteri WHERE hesapno = @account_number";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@account_number", accountNumber);
                decimal balance = (decimal)cmd.ExecuteScalar();
                // Girilen değeri ekle
                decimal amount = decimal.Parse(txtÇekme.Text);
                while (true)
                {
                    if (balance + amount > 750)
                    {
                        MessageBox.Show("Günlük para çekim limiti (750 TL) aşıldı!");
                        break;
                    }
                    else
                        balance -= amount;
                }


                // Bakiyeyi güncelle
                sql = "UPDATE bireyselmusteri SET bakiye = @balance WHERE hesapno = @account_number";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@account_number", accountNumber);
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Para Çekme işlemi başarıyla tamamlandı.");
            }
        }
    }
}

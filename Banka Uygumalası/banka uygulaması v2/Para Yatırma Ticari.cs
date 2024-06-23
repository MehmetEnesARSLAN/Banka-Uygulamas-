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
    public partial class Para_Yatırma_Ticari : Form
    {
        public Para_Yatırma_Ticari()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void btnYatır_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection())
            {
                connection.Open();

                string accountNumber = "";

                // Bakiyeyi oku
                string sql = "SELECT bakiye FROM ticarimusteri WHERE hesapno = @account_number";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@account_number", accountNumber);
                decimal balance = (decimal)cmd.ExecuteScalar();
                // Girilen değeri ekle
                decimal amount = decimal.Parse(txtYatırTutar.Text);
                balance += amount;

                // Bakiyeyi güncelle
                sql = "UPDATE ticarimusteri SET bakiye = @balance WHERE hesapno = @account_number";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@account_number", accountNumber);
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Para Yatırma işlemi başarıyla tamamlandı.");
            }
        }
    }
}

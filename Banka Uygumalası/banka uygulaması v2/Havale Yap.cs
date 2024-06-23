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
    public partial class Havale_Yap : Form
    {
        public Havale_Yap()
        {
            InitializeComponent();
        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            int senderAccountNumber = 90909090;

            string recipientAccountNumber = txtHesapno.Text;

            string connString = "server = localhost; port = 5432; Database =dbBanka; user ID = postgres; password = 1234";

            decimal recipientBalance = 0;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT bakiye FROM bireyselmusteri WHERE hesapno = @recipientAccountNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@recipientAccountNumber", txtHesapno.Text);
                    recipientBalance = (decimal)cmd.ExecuteScalar();
                }
            }


            decimal senderBalance = 0;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT bakiye FROM bireyselmusteri WHERE hesapno = @senderAccountNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@senderAccountNumber", txtHesapno.Text);
                    senderBalance = (decimal)cmd.ExecuteScalar();
                }
                conn.Close();
            }


            decimal amount = decimal.Parse(txtHavaleTutar.Text);


            recipientBalance += amount;
            senderBalance -= amount;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("UPDATE bireyselmusteri SET bakiye = @recipientBalance WHERE hesapno = @recipientAccountNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@recipientBalance", recipientBalance);
                    cmd.Parameters.AddWithValue("@recipientAccountNumber", txtHesapno.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("UPDATE bireyselmusteri SET bakiye = @senderBalance WHERE hesapno = @senderAccountNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@senderBalance", senderBalance);
                    cmd.Parameters.AddWithValue("@senderAccountNumber", txtHesapno.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            
        
        }
    }
}

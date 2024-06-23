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
    public partial class Banka_Gelir_Gider_Raporu : Form
    {
        public Banka_Gelir_Gider_Raporu()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost; port = 5432; Database=dbBanka; user ID=postgres;  password=1234");


        private void Banka_Gelir_Gider_Raporu_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from bankagelirgider";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

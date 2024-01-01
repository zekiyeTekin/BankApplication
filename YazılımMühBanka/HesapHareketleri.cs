using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMühBanka
{
    public partial class HesapHareketleri : Form
    {
        public HesapHareketleri()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        NpgsqlConnection baglanti =new NpgsqlConnection("server=localHost; posrt=5432; " +
          "Database=VeriTabanıBankaProje; user ID=postgres; password= Zekiye.26");
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from urunler";
            // urunler adında olmayacak seninkisi tabloadını yazacaksın
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

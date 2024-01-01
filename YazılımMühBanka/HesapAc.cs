using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace YazılımMühBanka
{
    public partial class HesapAc : Form
    {
        public HesapAc()
        {
            InitializeComponent();
        }


        NpgsqlConnection con = new NpgsqlConnection("server=localhost; port=5432; Database=dbBankProject;" +
             "user ID=postgres; password=Zekiye.26");


        private void HesapAc_Load(object sender, EventArgs e)
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from hesapac2 ", con);
         


            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                dataGridView2.DataSource = dataTable;

            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {




            NpgsqlCommand cmd1 = new NpgsqlCommand("insert into hesapac2(ano,ibn,'balanceTotal','districtName','cityName','accountName')  values('" + txt_hesapNo.Text + "','" + txt_iban.Text + "','" + txt_bakiye.Text + "','" + txt_ilce.Text + "','" + txt_il.Text + "','" + txt_hsptur.Text + "') ", con);

            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Hesap Eklendi", " ", MessageBoxButtons.OK);

        }

        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {


            

        }
    }
}


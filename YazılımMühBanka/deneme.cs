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
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("server=localHost; port=5432; Database=dbBankProject;" +
               "user ID=postgres; password=Zekiye.26");

        public void loadData()
        {
            DataTable dataTable = new DataTable();
            con.Open();

            NpgsqlCommand command = new NpgsqlCommand("select * from person", con);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(dataTable);

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  con.Open();
            //NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO person(pname,psurname,ptc,ppasword,pphone) " +
            //  "values (@p1,@p2,@p3,@p4,@p5)", con);

            ////cmd.Parameters.AddWithValue("@p1", txt_ad.Text);
            ////cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
            ////cmd.Parameters.AddWithValue("@p3", txt_tc.Text);
            ////cmd.Parameters.AddWithValue("@p4", txt_sifre.Text);
            ////cmd.Parameters.AddWithValue("@p5", txt_tel.Text);


            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Müşteri Eklendi", " ", MessageBoxButtons.OK);
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("call kullaniciTumKayitlar()" + aragir.Text, con);
            //adapter.Fill(dt);
            //con.Close();
            //dataGridView1.DataSource = dt;

          //  con.Open();
            string aranacakDeger = aragir.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("ptc like '%"+aragir.Text+"%'", aranacakDeger);
            con.Close();
        }

        private void deneme_Load(object sender, EventArgs e)
        {

            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from person", con);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
          

            //DataGridView selectedRow = dataGridView1.SelectedRows[0];
            int selectedRowId = (int)dataGridView1.SelectedRows[0].Cells["ptc"].Value;
            string delete = "delete from person where 'ptc' = @ptc";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(delete, con);
            npgsqlCommand.Parameters.AddWithValue("@ptc", selectedRowId);
            npgsqlCommand.ExecuteNonQuery();
            loadData();
            con.Close();
        }
    }
}

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
    public partial class transfer : Form
    {

        NpgsqlConnection con = new NpgsqlConnection("server=localHost; port=5432; Database=dbBankProject;" +
                "user ID=postgres; password=Zekiye.26");

        public transfer()
        {
            InitializeComponent();
        }
         
  
        public void CheckBalance()
        {
            con.Open();
            NpgsqlCommand cmd1 = new NpgsqlCommand("select * from account where 'accountNo'= '" + textBox3.Text + "' ", con);
            
            DataTable dt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(cmd1);
            nda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox1.Text = "Rs"+dr["amount"].ToString();
            }


            con.Close();    
        }



      

        private void simpleButton1_Click(object sender, EventArgs e)
        {

;
            using (var cmd = new NpgsqlCommand("ALTER TABLE transfer ENABLE TRIGGER transfertrigger;", con))
            {

                cmd.ExecuteNonQuery();
            }





        }

        private void transfer_Load(object sender, EventArgs e)
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from transfer", con);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            dataGridView2.DataSource = dataTable;
        }

        private void check_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == "")
            {
                MessageBox.Show("hesap no gir");
            }
            else
            {
                CheckBalance();
                if(textBox1.Text == "Your balance")
                {
                    MessageBox.Show("hesap nosu blunamadı");
                    textBox1.Text = "";

                }
            }
        }
    }
}

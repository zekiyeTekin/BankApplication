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
    public partial class SignUp : Form
    {


            NpgsqlConnection con = new NpgsqlConnection("server=localHost; port=5432; Database=dbBankProject;" +
                "user ID=postgres; password=Zekiye.26");



            public SignUp()
            {
                InitializeComponent();
            }

            private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            con.Open();


            //NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO person(pname,psurname,ptc,ppasword,pphone) " +
            //  "values (@p1,@p2,@p3,@p4,@p5)", con);

            NpgsqlCommand cmd = new NpgsqlCommand("call eklekisi('"+txt_ad.Text+"','"+txt_soyad.Text+"','"+txt_tc.Text+"','"+txt_sifre.Text+"','"+txt_tel.Text+"') " , con);


            //cmd.Parameters.AddWithValue("@p1", txt_ad.Text);
            //cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
            //cmd.Parameters.AddWithValue("@p3", txt_tc.Text);
            //cmd.Parameters.AddWithValue("@p4", txt_sifre.Text);
           // cmd.Parameters.AddWithValue("@p5", txt_tel.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Eklendi", " ", MessageBoxButtons.OK);


            this.Hide();
                Login login = new Login();
                login.Show();


            }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class bankalar : Form
    {

        public bankalar()
        {
            InitializeComponent();

        }
        public static string GidenBilgi = "";

        NpgsqlConnection con = new NpgsqlConnection("server=localhost; port=5432; Database=dbBankProject;" +
               "user ID=postgres; password=Zekiye.26");
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show();
        }
        public void Girenisim()
        {
            bool isTrue = true;
            con.Open();
            label1.Text = Login.GidenBilgiLogin.ToString();
            NpgsqlCommand cmd1 = new NpgsqlCommand("select * from person where pname= '" + label1.Text + "' ", con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                isTrue = true;
                label1.Text = reader1["pname"].ToString();
            }
            else if (isTrue == false)
            {
                label1.Text = "veri  cekmedi";
            }
            con.Close();
        }

        //public void tumbankalar()
        //{
        //    con.Open();

        //    NpgsqlCommand cmd = new NpgsqlCommand("select * from banks where name=@name ", con);
        //    // cmd.ExecuteNonQuery();
        //    NpgsqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.Read())
        //    {

        //        label4.Text = reader["name"].ToString();
        //        //GidenBilgi1 = "Garanti Bankası";
        //    }
        //    else
        //    {
        //        label4.Text = "veri çekilemedi";
        //    }
        //    con.Close();
        //}
        public void garantiButon()
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from banks where name='Garanti Bankası' ", con);
            // cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label4.Text = reader["name"].ToString();
                //GidenBilgi1 = "Garanti Bankası";
            }
            else
            {
                label4.Text = "veri çekilemedi";
            }
            con.Close();
            Girenisim();

        }
        public void ziraatButon()
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from banks where name='Ziraat Bankası' ", con);
            // cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label4.Text = reader["name"].ToString();
                //GidenBilgi1 = "Garanti Bankası";
            }
            else
            {
                label4.Text = "veri çekilemedi";
            }
            con.Close();
            Girenisim();
        }
        public void işBankasıButonu()
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from banks where name='İş Bankası' ", con);
            // cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label4.Text = reader["name"].ToString();
                //GidenBilgi1 = "Garanti Bankası";
            }
            else
            {
                label4.Text = "veri çekilemedi";
            }
            con.Close();
        }

        public void HalkBankasıButonu()
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from banks where name='Halk Bankası' ", con);
            // cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label4.Text = reader["name"].ToString();
                //GidenBilgi1 = "Garanti Bankası";
            }
            else
            {
                label4.Text = "veri çekilemedi";
            }
            con.Close();
        }
              public void FinansBankasıButonu()
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from banks where name='Finans Bankası' ", con);
            // cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label4.Text = reader["name"].ToString();
                //GidenBilgi1 = "Garanti Bankası";
            }
            else
            {
                label4.Text = "veri çekilemedi";
            }
            con.Close();
            Girenisim();
        }



        private void bankalar_Load(object sender, EventArgs e)
        {
            label1.Text = Login.GidenBilgiLogin.ToString();

            //if (GnlGorunum.GidenBilgi1.ToString() == "Garanti Bankası")
            //{
            //    label4.Text = "Garanti Bankası";
            //}
            //else if(GnlGorunum.GidenBilgi2 == "Ziraat Bankası")
            //{
            //    label4.Text = GnlGorunum.GidenBilgi2.ToString();
            //}
            //else if(GnlGorunum.GidenBilgi3 == "İş Bankası")
            //{
            //    label4.Text = GnlGorunum.GidenBilgi3.ToString();
            //}
            //else if (GnlGorunum.GidenBilgi4 == "Halk Bankası")
            //{
            //    label4.Text = GnlGorunum.GidenBilgi4.ToString();
            //}
            //else if(GnlGorunum.GidenBilgi5 == "Finans Bankası")
            //{
            //    label4.Text = GnlGorunum.GidenBilgi5.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Başaramadın", " ", MessageBoxButtons.OK);
            //}
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}

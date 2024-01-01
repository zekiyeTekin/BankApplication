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
    public partial class GnlGorunum : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("server=localHost; port=5432; Database=dbBankProject;" +
               "user ID=postgres; password=Zekiye.26");

        public static string GidenBilgiLogin = "";

        //public static string GidenBilgi1 = " ";
        //public static string GidenBilgi2 = "";
        //public static string GidenBilgi3 = "";
        //public static string GidenBilgi4 = "";
        //public static string GidenBilgi5 = "";



        //public void VeriGetir1()
        //{
        //    con.Open();
        //    NpgsqlCommand cmd = new NpgsqlCommand("select bankaName from banks where bankaName='Garanti Bankası' ", con);      
        //   // cmd.ExecuteNonQuery();
        //    NpgsqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.Read())
        //    {


        //        GidenBilgi1 = reader["bankaName"].ToString();

        //    }
        //    else
        //    {
        //        GidenBilgi1 = "veri çekilemedi";
        //    }
        //    con.Close();
        //}


        public GnlGorunum()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            HesapHareketleri hesapHareketleri = new HesapHareketleri();
            hesapHareketleri.Show();
        }

        private void bnt_islemler_Click(object sender, EventArgs e)
        {
            bankalar islemler = new bankalar();
            islemler.Show();
        }

        private void bnt_garantibank_Click(object sender, EventArgs e)
        {
       
            bankalar banklar = new bankalar();
            banklar.garantiButon();          
            banklar.ShowDialog();

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            
            HesapAc hesapAc = new HesapAc();
            hesapAc.Show();
        }

        private void btn_ziraatbank_Click(object sender, EventArgs e)
        {
          
            bankalar banklar = new bankalar();
            banklar.ziraatButon();
            banklar.ShowDialog();
        }

        private void btn_isbank_Click(object sender, EventArgs e)
        {
            
            bankalar banklar = new bankalar();
            banklar.işBankasıButonu();
            banklar.ShowDialog();
        }

        private void btn_halkbank_Click(object sender, EventArgs e)
        {
           
            //VeriGetir();
            bankalar banklar = new bankalar();
            banklar.HalkBankasıButonu();
            banklar.ShowDialog();
        }

        private void btn_finansbank_Click(object sender, EventArgs e)
        {
            //VeriGetir();
            bankalar banklar = new bankalar();
            banklar.FinansBankasıButonu();
            banklar.Girenisim();
            banklar.ShowDialog();
        }

        private void GnlGorunum_Load(object sender, EventArgs e)
        {
            labelControl2.Text = Login.GidenBilgiLogin.ToString();
            label1.Visible = true;
            bankalar banklar = new bankalar();
            banklar.Girenisim();
        }
    }
}

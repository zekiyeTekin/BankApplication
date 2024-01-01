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
using Devart.Data.PostgreSql;
using Devart.Data;
using Devart.Common;

namespace YazılımMühBanka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string GidenBilgiLogin = "";
        public static string GidenBilgitransfer = ""; 
       

        NpgsqlConnection con = new NpgsqlConnection("server=localHost; port=5432; Database=dbBankProject;" +
            "user ID=postgres; password=Zekiye.26 ");

        //public void VeriGetirLogin()
        //{
        //    NpgsqlCommand cmd = new NpgsqlCommand("Select * from personn where persontcc= '" + textBox1.Text + "' and passworddd = '" + textBox2.Text + "'", con);
            
        //    NpgsqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        GidenBilgiLogin = reader["persontcc"].ToString();

        //    }
        //    else
        //    {
        //        GidenBilgiLogin = "veri çekilemedi";
        //    }
            
        //}
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        bool isTrue = false;
            con.Open();
         
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from person where ptc= '" + textBox1.Text + "' and ppasword = '" + textBox2.Text + "'", con);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            
         

            if ( dr.Read())
            {
                isTrue = true;      
                this.Hide();
                GidenBilgiLogin = dr["pname" ].ToString();
                GidenBilgitransfer = dr["ptc"].ToString();

                GnlGorunum fr2 = new GnlGorunum();
                fr2.Show();

            }
            else if (isTrue == false) 
            {
                GidenBilgiLogin = "veri çekilemedi";
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalıdır!  ", "okey ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);       
            }
            dr.Close();
            con.Close();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            simpleButton2.Visible = false;  
            simpleButton3.Visible = true;
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            simpleButton3.Visible = false;
            simpleButton2.Visible = true;
        }
    }
}

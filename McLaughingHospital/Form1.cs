using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McLaughingHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username = "admin";
        string password = "12345";
        MainMenu mm = new MainMenu();
        PasswordHash phs = new PasswordHash();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KO6K2BO;Initial Catalog=LaughingHospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@uname", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = txtUsername.Text;
            SqlParameter param2 = new SqlParameter("@pwd", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value =txtPassword.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if (a > 0)
            {
                MessageBox.Show("InValid User");
                
            }
            else
            {
                MessageBox.Show("Valid User");
                MainMenu crud = new MainMenu();
                crud.Show();
                this.Hide();
            }
            con.Close();
        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}

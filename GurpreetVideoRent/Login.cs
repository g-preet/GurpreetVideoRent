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

namespace GurpreetVideoRent
{
    public partial class Login : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["gopiConn"].ToString();
        SqlConnection conn = new SqlConnection(); 
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "SPUserLogin";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.NVarChar)).Value = usernameTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.NVarChar)).Value = passwordTxt.Text;
            int usercount = (Int32)cmd.ExecuteScalar();// for taking single value

            if (usercount == 1)  // comparing users from table 
            {
                this.Hide();
                RentalVideosForm _tabs = new RentalVideosForm();
                _tabs.ShowDialog();
            }
            else
            {
                usernameTxt.Text = "";
                passwordTxt.Text = "";
                MessageBox.Show("Login ID and Password is incorrect.");
            }

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}

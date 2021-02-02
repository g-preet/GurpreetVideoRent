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
    public partial class RentalForm : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["gopiConn"].ToString();
        SqlConnection conn = new SqlConnection();//Connection object
        public RentalForm()
        {
            InitializeComponent();
            //binding customer,movie and rented movie lists
            CustomerList();
            MovieList();
            RentalList();
            this.dGWCustomerList.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGWCustomerList.DefaultCellStyle.BackColor = Color.Beige;
            this.dGWMovieList.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGWMovieList.DefaultCellStyle.BackColor = Color.Beige;
            this.dgWMovieRentalList.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgWMovieRentalList.DefaultCellStyle.BackColor = Color.Beige;
        }

        //function for bind customer
        private void CustomerList()
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPGetCustomerList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWCustomerList.DataSource = dt;

        }

        //function for bind Movie
        private void MovieList()
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPGetMovieList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWMovieList.DataSource = dt;

        }

        //function for bind Rental list
        private void RentalList()
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPGetRentalList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgWMovieRentalList.DataSource = dt;

        }

        //function for issue movie to the customer
        private void issueMovieBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPInsertRentalIssueMovie";
            cmd.Parameters.Add(new SqlParameter("@customerID", SqlDbType.NVarChar)).Value = textCustID.Text;
            cmd.Parameters.Add(new SqlParameter("@movieID", SqlDbType.NVarChar)).Value = textBoxMovieID.Text;
            MessageBox.Show("Movie rented to the customer");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            RentalList();
        }

        //function for bind return movie from the customer
        private void returnMovieBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPUpdateRentalReturnMovie";
            cmd.Parameters.Add(new SqlParameter("@rentalID", SqlDbType.NVarChar)).Value = textBoxRentalID.Text;
            MessageBox.Show("Movie returned from the customer");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            RentalList();
        }
        //function for back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalVideosForm _tabs = new RentalVideosForm();
            _tabs.ShowDialog();
        }

        //Code for putting the data in textboxes through grid view when we click on gridview's row
        private void dgWMovieRentalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgWMovieRentalList.Rows[e.RowIndex];
                textBoxRentalID.Text = row.Cells[0].Value.ToString();
                textBoxFName.Text = row.Cells[1].Value.ToString();
                textBoxLName.Text = row.Cells[2].Value.ToString();
                textBoxRentalCost.Text = row.Cells[5].Value.ToString();
            }
        }
        //Code for putting the data in textboxes through grid view when we click on gridview's row
        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
            textCustID.Text = row.Cells[0].Value.ToString();
            textBoxFName.Text = row.Cells[1].Value.ToString();
            textBoxLName.Text = row.Cells[2].Value.ToString();
        }
        //Code for putting the data in textboxes through grid view when we click on gridview's row
        private void dGWMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMovieList.Rows[e.RowIndex];
            textBoxMovieID.Text = row.Cells[0].Value.ToString();
            textBoxTitle.Text = row.Cells[1].Value.ToString();
            textBoxGenre.Text = row.Cells[2].Value.ToString();
            textBoxRentalCost.Text = row.Cells[3].Value.ToString();
            textBoxPlot.Text = row.Cells[4].Value.ToString();
        }

        private void radioButtonAllRented_CheckedChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //Here I am definied command type is Stored Procedure.
            cmd.CommandType = CommandType.StoredProcedure;
            //Here I mentioned the Stored Procedure Name.
            cmd.CommandText = "GetMoviesRentalList";
            //Here I fix the variable values to Stored Procedure Parameters. You can easily understand if you can see the Stored Procedure Code.
            cmd.Parameters.Add(new SqlParameter("@rentalType", SqlDbType.NVarChar)).Value = "A";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWMovieList.DataSource = dt;
        }

        private void radioButtonOutRented_CheckedChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetMoviesRentalList";
            cmd.Parameters.Add(new SqlParameter("@rentalType", SqlDbType.NVarChar)).Value = "O";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGWMovieList.DataSource = dt;
        }
    }
}

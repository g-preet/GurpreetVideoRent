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
    public partial class MovieForm : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["gopiConn"].ToString();
        SqlConnection conn = new SqlConnection();//Connection object
        public MovieForm()
        {
            InitializeComponent();
            //Caling the movie data when form will load
            MovieList();
            this.movieListDGV.DefaultCellStyle.ForeColor = Color.Blue;
            this.movieListDGV.DefaultCellStyle.BackColor = Color.Beige;
        }
        //Binding the movie in this function
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
            movieListDGV.DataSource = dt;

        }
        //Code for adding the movies
        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPInsertUpdateMovies";
            cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar)).Value = titleTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Rental_Cost", SqlDbType.NVarChar)).Value = rentalCostTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Genre", SqlDbType.NVarChar)).Value = genreTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Plot", SqlDbType.NVarChar)).Value = plotTxt.Text;
            MessageBox.Show("Movie added successfully");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MovieList();
        }

        //Code for update the movies
        private void updateMovieBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPInsertUpdateMovies";
            cmd.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar)).Value = titleTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Rental_Cost", SqlDbType.NVarChar)).Value = rentalCostTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Genre", SqlDbType.NVarChar)).Value = genreTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Plot", SqlDbType.NVarChar)).Value = plotTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@MovieID", SqlDbType.NVarChar)).Value = movieIDTxt.Text;
            MessageBox.Show("Movie updated successfully");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MovieList();
        }

        private void deleteMovieBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPDeleteMovies";
            cmd.Parameters.Add(new SqlParameter("@movieID", SqlDbType.NVarChar)).Value = movieIDTxt.Text;
            int numRes = cmd.ExecuteNonQuery();
            if (numRes > 0)
            {
                MessageBox.Show("Record Deleted Successfully !!!");
                titleTxt.Text = "";
                rentalCostTxt.Text = "";
                genreTxt.Text = "";
                plotTxt.Text = "";
                movieIDTxt.Text = "";
                MovieList();
            }
            else
            {
                MessageBox.Show("Please Try Again !!!");
            }
        }

        private void movieListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.movieListDGV.Rows[e.RowIndex];
            movieIDTxt.Text = row.Cells[0].Value.ToString();
            titleTxt.Text = row.Cells[1].Value.ToString();
            genreTxt.Text = row.Cells[2].Value.ToString();
            rentalCostTxt.Text = row.Cells[3].Value.ToString();
            plotTxt.Text = row.Cells[4].Value.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalVideosForm _tabs = new RentalVideosForm();
            _tabs.ShowDialog();
        }
    }
}

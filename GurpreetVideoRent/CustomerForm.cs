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
    public partial class CustomerForm : Form
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["gopiConn"].ToString();
        SqlConnection conn = new SqlConnection();//Connection object
        public CustomerForm()
        {
            InitializeComponent();
            //Caling the customer data when form will load
            CustomerList();
        }
        //Binding the customers in this function
        private void CustomerList()
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //Stored Procedure access code.
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPGetCustomerList";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customerListDGV.DataSource = dt;
        }

        //Code for adding the customers
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPInsertUpdateCustomer";
            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = firstNameTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = lastNameTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar)).Value = addressTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar)).Value = phoneNumberTxt.Text;
            MessageBox.Show("Customer added successfully");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            CustomerList();
        }

        //Code for updating the customers
        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPInsertUpdateCustomer";
            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = firstNameTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = lastNameTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar)).Value = addressTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar)).Value = phoneNumberTxt.Text;
            cmd.Parameters.Add(new SqlParameter("@CustID", SqlDbType.NVarChar)).Value = custIDTxt.Text;
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            addressTxt.Text = "";
            phoneNumberTxt.Text = "";
            custIDTxt.Text = "";
            MessageBox.Show("Customer updated successfully");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            CustomerList();
        }

        //Code for deleting the customers
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(appsetting);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPDeleteCustomers";
            cmd.Parameters.Add(new SqlParameter("@customerID", SqlDbType.NVarChar)).Value = custIDTxt.Text;
            int numRes = cmd.ExecuteNonQuery();
            if (numRes > 0)
            {
                MessageBox.Show("Record Deleted Successfully !!!");
                firstNameTxt.Text = "";
                lastNameTxt.Text = "";
                addressTxt.Text = "";
                phoneNumberTxt.Text = "";
                custIDTxt.Text = "";
                CustomerList();
            }
            else
            {
                MessageBox.Show("Please Try Again !!!");
            }
        }

        //Code for putting the data in textboxes through grid view when we click on gridview's row
        private void customerListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerListDGV.Rows[e.RowIndex];
                custIDTxt.Text = row.Cells[0].Value.ToString();
                firstNameTxt.Text = row.Cells[1].Value.ToString();
                lastNameTxt.Text = row.Cells[2].Value.ToString();
                addressTxt.Text = row.Cells[3].Value.ToString();
                phoneNumberTxt.Text = row.Cells[4].Value.ToString();
            }
        }

        //Code for Back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalVideosForm _tabs = new RentalVideosForm();
            _tabs.ShowDialog();
        }
    }
}

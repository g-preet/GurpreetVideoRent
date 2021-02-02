using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GurpreetVideoRent
{
    public partial class RentalVideosForm : Form
    {
        public RentalVideosForm()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customers = new CustomerForm();
            customers.ShowDialog();
        }

        private void MovieBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieForm movies = new MovieForm();
            movies.ShowDialog();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalForm rental = new RentalForm();
            rental.ShowDialog();
        }
    }
}

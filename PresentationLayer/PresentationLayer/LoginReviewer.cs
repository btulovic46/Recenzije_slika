using BuisnessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LoginReviewer : Form
    {
        private readonly ReviewerBuisness reviewerBusiness;
        public LoginReviewer()
        {
            InitializeComponent();
            this.reviewerBusiness = new ReviewerBuisness();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Reviewer r = null;
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxPassword.Text))
            {
                r = this.reviewerBusiness.GetReviewerLogin(textBoxName.Text, textBoxPassword.Text);
                if (r != null)
                {
                    Form1.currentReviewer = r;
                    this.Dispose();
                    ReviewerView rv = new ReviewerView();
                    rv.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Pogresan naziv ili lozinka");
                }
            }
        }
    }
}

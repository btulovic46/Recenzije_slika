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
    public partial class Form1 : Form
    {
        public static Gallery currentGallery;
        public static Reviewer currentReviewer;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegisterReviewer_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterReviewer rr = new RegisterReviewer();
            rr.ShowDialog();
            this.Show();
        }

        private void buttonRegisterGallery_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterGallery rr = new RegisterGallery();
            rr.ShowDialog();
            this.Show();
        }

        private void buttonLoginGallery_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGallery lg = new LoginGallery();
            lg.ShowDialog();
            this.Show();
        }

        private void buttonLoginReviewer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginReviewer lr = new LoginReviewer();
            lr.ShowDialog();
            this.Show();
        }
    }
}

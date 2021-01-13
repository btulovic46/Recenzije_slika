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
    public partial class LoginGallery : Form
    {
        private readonly GalleryBuisness galleryBusiness;
        public LoginGallery()
        {
            InitializeComponent();
            this.galleryBusiness = new GalleryBuisness();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Gallery g = null;
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxPassword.Text)) 
            {
                g = this.galleryBusiness.GetGalleryLogin(textBoxName.Text, textBoxPassword.Text);
                if (g != null)
                {
                    Form1.currentGallery = g;
                    this.Dispose();
                    GalleryView gv = new GalleryView();
                    gv.ShowDialog();                    
                }
                else 
                {
                    MessageBox.Show("Pogresan naziv ili lozinka");
                }
            }
        }
    }
}

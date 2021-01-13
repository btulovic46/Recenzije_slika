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
    public partial class RegisterGallery : Form
    {
        private readonly GalleryBuisness galleryBusiness;
        public RegisterGallery()
        {
            InitializeComponent();
            this.galleryBusiness = new GalleryBuisness();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxEmail.Text) && !String.IsNullOrEmpty(textBoxPassword.Text) && !String.IsNullOrEmpty(textBoxAddress.Text) && !String.IsNullOrEmpty(textBoxCity.Text))
            {
                Gallery g = new Gallery()
                {
                    Name = textBoxName.Text,
                    Adress = textBoxAddress.Text,
                    City = textBoxCity.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                };
                if (this.galleryBusiness.InsertGallery(g))
                {
                    ClearBoxes();
                    MessageBox.Show("Uspesno unesena galerija u bazu podataka");
                }
            }
            else 
            {
                MessageBox.Show("Popunite sva polja");
            }
        }

        private void ClearBoxes()
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxAddress.Text = "";
            textBoxCity.Text = "";
        }
    }
}

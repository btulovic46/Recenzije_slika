using BuisnessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class GalleryView : Form
    {
        private FileStream fs;
        private BinaryReader br;
        private string fileName;
        private readonly PictureBuisness pictureBuisness;
        public GalleryView()
        {
            InitializeComponent();
            this.pictureBuisness = new PictureBuisness();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxCreator.Text) && !String.IsNullOrEmpty(textBoxDescription.Text) && !String.IsNullOrEmpty(textBoxAverageGrade.Text) && pictureBox1.BackgroundImage != null)
            {
               
                Picture p = new Picture()
                {
                    Name = textBoxName.Text,
                    Creator = textBoxCreator.Text,
                    AverageGrade = Convert.ToDecimal(textBoxAverageGrade.Text),
                    Description = textBoxDescription.Text,
                    GalleryId = Form1.currentGallery.Id,
                    Image = null
                };
                if (this.pictureBuisness.InsertPicture(p))
                {
                    MessageBox.Show("Uspesno uneta slika u bazu podataka");
                }
            }
            else 
            {
                MessageBox.Show("Popunite sva polja");
            }
        }
    }
}

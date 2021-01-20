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
    public partial class ReviewerView : Form
    {
        private readonly PictureBuisness pictureBusiness;
        private readonly ReviewBuisness reviewBuisness;

        public ReviewerView()
        {
            InitializeComponent();
            this.pictureBusiness = new PictureBuisness();
            this.reviewBuisness = new ReviewBuisness();
        }

        private void ReviewerView_Load(object sender, EventArgs e)
        {
            List<Picture> list = this.pictureBusiness.GetAllPictures();
            dataGridViewPictures.DataSource = list;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox1.Text) && !String.IsNullOrEmpty(textBoxAverageGrade.Text) && dataGridViewPictures.SelectedRows[0] != null) 
            {
                Review r = new Review()
                {
                    PictureId = Convert.ToInt32(dataGridViewPictures.SelectedRows[0].Cells[0].Value),
                    ReviewerId = Form1.currentReviewer.Id,
                    Grade = Convert.ToDecimal(textBoxAverageGrade.Text),
                    Comment = richTextBox1.Text
                };
                if (this.reviewBuisness.InsertReview(r)) 
                {
                    MessageBox.Show("Unesen komentar za sliku");
                    ClearBoxes();
                }
            }
        }

        private void ClearBoxes() 
        {
            textBoxAverageGrade.Text = "";
            richTextBox1.Text = "";
        }
    }
}

using BuisnessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer
{
  
    
        public partial class Registracija : System.Web.UI.Page {
        private ReviewerBuisness reviewerBusiness = new ReviewerBuisness();
        protected void Page_Load(object sender,EventArgs e)
        {

        }
            protected void btnInsert_Click(object sender, EventArgs e)
            {


            Reviewer r = new Reviewer();
            r.Name = TextBoxName.Text;
            r.LastName = TextBoxLastName.Text;
            r.Email = TextBoxEmail.Text;
            r.Adress = TextBoxAdress.Text;
            r.City = TextBoxCity.Text;
            r.PhoneNumber = TextBoxPhoneNumber.Decimal;//Ovde nesto nije u redu




            this.reviewerBusiness.InsertReviewer(r);
            }
            
        }
   

    
}
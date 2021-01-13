using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class GalleryBuisness
    {
        private readonly GalleryRepository galleryRepository;

        public GalleryBuisness()
        {
            this.galleryRepository = new GalleryRepository();
        }
        public List<Gallery> GetAllGalleries()
        {
            return this.galleryRepository.GetAllGalleries();
        }

        public Gallery GetGalleryLogin(string name, string password) 
        {
            return this.galleryRepository.GetAllGalleries().FirstOrDefault(g => g.Name == name && g.Password == password);
        }
        public bool InsertGallery(Gallery g)
        {
            if (this.galleryRepository.InsertGallery(g) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateGallery(Gallery g)
        {
            if (this.galleryRepository.UpdateGallery(g) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteGallery(Gallery g)
        {
            if (this.galleryRepository.DeleteGallery(g) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
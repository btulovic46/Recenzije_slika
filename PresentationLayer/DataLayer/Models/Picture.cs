using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public decimal AverageGrade { get; set; }
        public int GalleryId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public decimal Grade { get; set; }
        public int ReviewerId { get; set; }
        public int PictureId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string StokKodu { get; set; }
        public string ProductName { get; set; } 
        public string ProductDescription { get; set; }
        public string subDescription { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
       // public double Discount { get; set; }
        //public bool DiscountStatus { get; set; }
        public bool CategoryStatus { get; set; }
        public int Likes { get; set; }
        public int Dislike { get; set; }
        public int StokAdedi { get; set; }
        public string image { get; set; }
        public int turKodu { get; set; }
        //public string Size { get; set; }
        //public string color { get; set; }

        //public string Cinsiyet { get; set; }
       
        public List<ProductItem> ProductItems { get; set; }
    }
}

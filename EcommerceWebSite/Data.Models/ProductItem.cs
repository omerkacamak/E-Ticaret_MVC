using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ProductItem
    {
        [Key]
        public int ProductItemID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int? ProductCategoryID { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        public string Size { get; set; }
        public string? Color { get; set; }
        public decimal price { get; set; }
        public int StokAdedi { get; set; }
        public bool status { get; set; }
        public int Discount { get; set; }
        public bool DiscountStatus { get; set; }
        
        public decimal old_price { get; set; }
        
        public decimal new_price { get; set; }
        public string image { get; set; }
        public DateTime CreatedTime { get; set; }
        public int SatilanMiktar { get; set; }


        public decimal anlikFiyat()
        {
            if(this.DiscountStatus==true)
            {
                var yuzde = (this.price * this.Discount) / 100;
                var yeniFiyat = this.price - yuzde;
                this.new_price = yeniFiyat;
                this.old_price = this.price;
                
                return yeniFiyat;
            }

            else
            {
                this.new_price=this.price;
                this.old_price = 0;
                return this.price;
            }
        }
        
    }
}

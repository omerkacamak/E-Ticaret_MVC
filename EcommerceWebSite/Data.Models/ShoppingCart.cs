using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartID { get; set; }
        public string SepetKodu { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public decimal totalPrice { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool Status { get; set; }
        public List<ShoppingCartItems> ShoppingCartItems { get; set; }


        //public decimal toplamFiyat()
        //{
        //    decimal toplam = 0;
        //    foreach (var item in this.ShoppingCartItems)
        //    {
        //        toplam += (item.Adet) * (item.ProductItem.new_price);
        //    }
        //    this.totalPrice = toplam;
        //    return this.totalPrice;
        //}


    }
}

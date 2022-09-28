using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ShoppingCartItems
    {
        [Key]
        public int ShoppingCartItemsID { get; set; }
        public int ShoppingCartID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
       
        public int Adet { get; set; }
        public int ProductItemID { get; set; }
        public ProductItem ProductItem { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.WriteSql
{
    public class ProductItemSql 
    {
        public string ProductName { get; set; }
        public int Likes { get; set; }
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }

        public int ProductItemID { get; set; }
        public int ProductID { get; set; }
        
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

    }
}

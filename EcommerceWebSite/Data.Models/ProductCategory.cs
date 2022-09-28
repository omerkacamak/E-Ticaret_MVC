using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ProductCategory // erkek kadın vs vs 
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public string ProductCategoryName { get; set; }
        public string Description { get; set; }
        public bool  Status { get; set; }
        public List<ProductItem> ProductItems { get; set; }

    }
}

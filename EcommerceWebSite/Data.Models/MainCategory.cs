using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MainCategory
    {
        [Key]
        public int MainCategoryID { get; set; }
        public string Name { get; set; }
        public string img { get; set; }
        public string description { get; set; }

        public List<Category> AltKategoriler { get; set; }
    }
}

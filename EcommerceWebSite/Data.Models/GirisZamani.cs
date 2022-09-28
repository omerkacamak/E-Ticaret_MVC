using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class GirisZamani
    {
        [Key]
        public int GirisZamaniID { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }
        public bool Status { get; set; }

    }
}

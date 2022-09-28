using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public bool PaymentStatus { get; set; }

    }
}

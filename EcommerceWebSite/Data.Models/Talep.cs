using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Talep
    {
        [Key]
        public int KeyID { get; set; }
        [Required(ErrorMessage ="mail alanı zorunludur")]
        public string GondericiEmail { get; set; }
        [Required(ErrorMessage = "konu alanı zorunludur")]
        public string Konu { get; set; }
        [Required(ErrorMessage = "açıklama alanı zorunludur")]
        public string Description { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SliderBars
    {
        [Key]
        public int ID { get; set; }
        public string LocationPage { get; set; }
        public string üstBaslik { get; set; }
        public string altBaslik { get; set; }
        public string Description { get; set; }
        public string href { get; set; }
        public string Image { get; set; }
        public string buttonText { get; set; }
    }
}

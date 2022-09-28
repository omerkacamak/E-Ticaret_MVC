using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderCreateDate { get; set; }
        public DateTime SevkiyatTarihi { get; set; }
        [Required(ErrorMessage ="Ödeme türünü seçmelisiniz")]
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public decimal ToplamFiyat { get; set; }
        public bool OrderStatus { get; set; }
        [Required(ErrorMessage = "Adres Boş Olamaz!")]
        public string OrderAddress { get; set; }
        public bool TeslimDurumu { get; set; }
        

    }

}

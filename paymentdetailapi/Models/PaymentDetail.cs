using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paymentdetailapi.Models
{

    public class PaymentDetail {
        [Key]
        public int PDId { get; set; }
        [Required]
        [Column(TypeName="nvarchar(100)")]
        public string CardName { get; set; }
        [Required]
        [Column(TypeName="varchar(16)")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName="varchar(5)")] // MM/DD
        public string ExpirationDate { get; set; }
        [Required]
        [Column(TypeName="varchar(3)")]
        public string CVV { get; set; }
    }

}
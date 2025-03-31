using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDelivery_Infra.Models
{
    public class PurchaseDetail
    {
        [Key]
        public int PurchaseId { get; set; }
        public string EmailId { get; set; }
        public int ProductId { get; set; }
        public int QntyPurchased { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
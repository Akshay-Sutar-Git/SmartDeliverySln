using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDelivery_Infra.Models
{
    public class User
    {
        [Key]
        public string EmailId { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }

        public Role Role { get; set; }
        public ICollection<PurchaseDetail> purchaseDetails { get; set; }
    }
}

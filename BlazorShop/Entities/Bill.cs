using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Entities
{
    public class Bill
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Total { get; set; }
        public Voucher Voucher { get; set; }
        public string UserId { get; set; } 
        [ForeignKey("UserId")]
        public Customer User { get; set; }

        public List<BillDetail> BillDetails { get; set; }

        public int StatusBill { get; set; }
    }
}

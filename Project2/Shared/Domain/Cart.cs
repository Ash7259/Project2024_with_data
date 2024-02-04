using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Shared.Domain
{
    public class Cart : BaseDomainModel
    {
        public int PurchaseId { get; set; }
        public int CustomerId { get; set; }
        public string CarName { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public bool IsCompleted { get; set; } // Flag to indicate whether the purchase is completed
    }
}

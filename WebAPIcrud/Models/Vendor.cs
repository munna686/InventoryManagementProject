using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Orders = new HashSet<Order>();
            Purchases = new HashSet<Purchase>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; } = null!;
        public string VendorContact { get; set; } = null!;
        public string? VendorAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}

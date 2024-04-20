using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Order
    {
        public Order()
        {
            Sales = new HashSet<Sale>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int VendorId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public bool IsEmergency { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? EmDeliveryDate { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Vendor Vendor { get; set; } = null!;
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

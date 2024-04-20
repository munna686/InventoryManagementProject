using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Purchase
    {
        public int PurchaseId { get; set; }
        public int VendorId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Vendor Vendor { get; set; } = null!;
    }
}

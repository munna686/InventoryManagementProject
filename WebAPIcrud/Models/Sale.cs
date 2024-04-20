using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public bool IsDeliver { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}

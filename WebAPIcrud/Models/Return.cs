using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Return
    {
        public int ReturnId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int CustomerId { get; set; }
        public int DamageId { get; set; }
        public string ReturnReason { get; set; } = null!;
        public bool IsDamage { get; set; }
        public DateTime ReturnDate { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Damage Damage { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}

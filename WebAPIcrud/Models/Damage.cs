using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Damage
    {
        public Damage()
        {
            Returns = new HashSet<Return>();
        }

        public int DamageId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string DamageDescription { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<Return> Returns { get; set; }
    }
}

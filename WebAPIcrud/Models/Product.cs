using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Product
    {
        public Product()
        {
            Damages = new HashSet<Damage>();
            Orders = new HashSet<Order>();
            Purchases = new HashSet<Purchase>();
            Returns = new HashSet<Return>();
            Sales = new HashSet<Sale>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int? ReorderQty { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Damage> Damages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

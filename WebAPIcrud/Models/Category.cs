using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPIcrud.Models
{
    public partial class Category
    {
        public Category()
        {
            Damages = new HashSet<Damage>();
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
            Purchases = new HashSet<Purchase>();
            Returns = new HashSet<Return>();
            Sales = new HashSet<Sale>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<Damage> Damages { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
        [JsonIgnore]
        public virtual ICollection<Purchase> Purchases { get; set; }
        [JsonIgnore]
        public virtual ICollection<Return> Returns { get; set; }
        [JsonIgnore]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

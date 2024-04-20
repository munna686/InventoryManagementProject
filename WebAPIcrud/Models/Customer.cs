using System;
using System.Collections.Generic;

namespace WebAPIcrud.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Returns = new HashSet<Return>();
            Sales = new HashSet<Sale>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string CustomerContact { get; set; } = null!;

        public virtual ICollection<Return> Returns { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

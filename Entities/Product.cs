using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceData.EfCore
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public virtual Category ProductNavigation { get; set; }
    }
}

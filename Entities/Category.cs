using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceData.EfCore
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Product Product { get; set; }
    }
}

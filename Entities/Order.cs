using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceData.EfCore
{
    public partial class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string OrderNote { get; set; }
    }
}

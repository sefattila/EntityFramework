using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class CustomerOrdersSummary
    {
        public string CustomerId { get; set; } = null!;
        public string? ContactName { get; set; }
        public int? Toplam { get; set; }
    }
}

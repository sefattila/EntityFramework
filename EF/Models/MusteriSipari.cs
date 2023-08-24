using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class MusteriSipari
    {
        public string CompanyName { get; set; } = null!;
        public double? Toplam { get; set; }
    }
}

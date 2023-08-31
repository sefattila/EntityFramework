using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EF_Inheretance.Entities
{
    public class Customer : BasePerson
    {
        public DateTime LastPurchaseDate { get; set; }
        public int TotalVisits { get; set; }

    }
}

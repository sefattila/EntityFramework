using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EF_Inheretance.Entities
{
    public class Employee : BasePerson
    {
        public DateTime AdmissionDate { get; set; }
        public string JobDescription { get; set; }
    }
}

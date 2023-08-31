using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EF_UniYonetimOrnek.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }


        public List<Course> Courses { get; set; }
    }
}

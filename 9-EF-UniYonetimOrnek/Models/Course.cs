using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EF_UniYonetimOrnek.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}

using _9_EF_UniYonetimOrnek.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EF_UniYonetimOrnek.Models
{
    public class Teacher : BaseEntity
    {
        [Column("Name",TypeName ="nvarchar(50)")]
        [Required(ErrorMessage ="İsim alanı zorunlu olmalıdır")]
        public string Name { get; set; }

        public Course Course { get; set; }
    }
}

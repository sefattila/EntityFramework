using _8_EF_DataAnnotationAndFluentApi.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EF_DataAnnotationAndFluentApi.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime AuthorDateTime { get; set; }

        [NotMapped] //tabloya ekleme 
        public int AuthorAge { get; set; }

        public ICollection<Book> Books { get; set; }
    }

    [NotMapped]
    public class Deneme
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

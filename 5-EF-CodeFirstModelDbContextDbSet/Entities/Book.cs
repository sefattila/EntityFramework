using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_EF_CodeFirstModelDbContextDbSet.Entities
{
    public class Book
    {
        public int BookId { get; set; }//otomatik olarak entity pk yapıcak ve identity vericek
        public string Title { get; set; }
        public string Subject { get; set; }
        public int AuthorId { get; set; } //foreign key olarak algılayacak

        //navigation property
        public virtual Author Author { get; set; }
    }
}

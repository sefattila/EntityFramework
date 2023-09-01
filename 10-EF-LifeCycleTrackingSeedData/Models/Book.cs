using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EF_LifeCycleTrackingSeedData.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int  AuthorID { get; set; }

        public Author Author { get; set; }
    }
}

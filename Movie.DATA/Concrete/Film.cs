using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DATA.Concrete
{
    public class Film:BaseFilm
    {
        public string FilmName { get; set; }
        public double FilmDuration { get; set; }
        public DateTime? PublishDate { get; set; }
        public int CategoryId { get; set; }
        

        public virtual FilmDetail FilmDetail { get; set; }
        public virtual FilmCategory FilmCategory { get; set; }
        public virtual IList<FilmActor> FilmActors { get; set; }
    }
}

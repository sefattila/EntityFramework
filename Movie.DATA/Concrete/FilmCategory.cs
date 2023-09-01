using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DATA.Concrete
{
    public class FilmCategory : BaseFilm
    {

        [Required]
        [MaxLength(50, ErrorMessage = "Maksimum 50 Karakter Olmalıdır")]
        [MinLength(3, ErrorMessage = "Minumum 3 Karakter Olmalıdır")]
        public string CategoryName { get; set; }
        
        [NotMapped]
        public string CategoryURL
        {
            get
            {
                return TurkishToEnglish(CategoryName); ;
            }
        }

        public virtual IList<Film> Films { get; set; }

        public string TurkishToEnglish(string character)
        {
            string turkishChar = "ığüşöç ";
            string englishChar = "igusoc-";

            for (int i = 0; i < turkishChar.Length; i++)
            {
                character = character.ToLower().Replace(turkishChar[i], englishChar[i]);
            }

            return character;
        }
    }
}

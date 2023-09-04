using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class EventDetail
    {
        [Key]
        public int EventDetailId { get; set; }

        [RegularExpression(@"^(0(\d{3}) (\d{3}) (\d{2}) (\d{2}))$",ErrorMessage ="Hatalı Girdiniz. 555 55 55")]
        public string EventPhone { get; set; }

        [EmailAddress(ErrorMessage ="Yanlış Formatta girdiniz. mail@mail.com")]
        public string EventMail { get; set; }

        //ref
        public virtual Event Event { get; set; }
    }
}

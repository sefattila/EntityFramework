using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class Ticket
    {
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public DateTime TicketDate { get; set; }=DateTime.Now;

        public virtual Customer Customer { get; set; }
        public virtual Event Event { get; set; }
    }
}

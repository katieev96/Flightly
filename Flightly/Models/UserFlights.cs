using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flightly.Models
{
    public class UserFlights
    {
        public Guid Id { get; set; }
        public virtual ICollection<FlightInfo> Flights { get; set; }
        public virtual User User { get; set; }
    }
}

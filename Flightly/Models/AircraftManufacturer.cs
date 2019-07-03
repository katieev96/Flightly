﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flightly.Models
{
    public class AircraftManufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Aircraft> Aircraft { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Domain
{
    public class Traveller: Passenger
    {
        public string HealthInformation { get; set; }
        public String Nationality { get; set; }
    }
}

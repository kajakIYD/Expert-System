﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEiED_1.Model
{
    public class Predicate
    {
        public string Name { get; set; }
        public bool Value { get; set; } = false;
        public bool IsKnown { get; set; }
        public bool IsSet { get; set; }
    }
}

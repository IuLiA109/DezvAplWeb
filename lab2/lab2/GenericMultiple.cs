﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class GenericMultiple<Tkey, Tvalue>
    {
        public Tkey? Key { get; set; }
        public Tvalue Value { get; set;}

    }
}

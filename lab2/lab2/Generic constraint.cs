using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Generic_constraint<T> where T : class
    {
        public T Value { get; set; } = default!;   
        
    }
}

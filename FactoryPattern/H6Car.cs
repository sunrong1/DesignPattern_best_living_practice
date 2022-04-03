using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class H6Car
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public abstract bool Produce();

    }
}

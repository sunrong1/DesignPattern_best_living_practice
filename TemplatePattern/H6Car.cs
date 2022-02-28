using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class H6Car
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public bool Produce()
        {
            ProduceEngine();
            ProduceTyre();
            ProduceChassis();
            return true;
        }

        public abstract void ProduceChassis();

        public abstract void ProduceTyre();
        public abstract void ProduceEngine();
    }
}

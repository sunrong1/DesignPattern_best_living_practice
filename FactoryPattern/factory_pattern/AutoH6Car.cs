using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.factory_pattern
{
    public class AutoH6CarFactory : IH6Factory
    {
        public H6Car CreateH6Car()
        {
            return new AutoH6Car();
        }
    }
}

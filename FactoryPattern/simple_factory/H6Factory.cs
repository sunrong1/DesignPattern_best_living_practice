using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.simple_factory
{
    public class H6Factory
    {
        public static H6Car CreateH6Car(string version)
        {
            H6Car car = null;
            switch (version)
            {
                case "Max":car = new MaxH6Car(); break;
                case "Auto":car = new AutoH6Car(); break;
                case "Superme":car = new SupermeH6Car(); break;
                default:
                    break;
            }
            return car;

        }
    }
}

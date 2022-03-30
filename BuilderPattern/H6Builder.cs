using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class H6Builder
    {
        public void Engine()
        {
            Console.WriteLine("生产H6发动机");
        }
        public void UnderPan()
        {
            Console.WriteLine("生产H6底盘");
        }
        public void GearBox()
        {
            Console.WriteLine("生产H6的变速箱");
        }
        public abstract void Appearance();

        public abstract void Intelligence();
    }
}

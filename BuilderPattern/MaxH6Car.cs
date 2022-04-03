using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MaxH6Car : H6Builder
    {
        public override void Appearance()
        {
            Console.WriteLine("增加Max的网状前脸外观");
            Console.WriteLine("增加Max的颜色");
        }

        public override void Intelligence()
        {
            Console.WriteLine("增加Max的L2水平智能");
            Console.WriteLine("增加Max的雷达系统：后雷达");
        }
    }
}

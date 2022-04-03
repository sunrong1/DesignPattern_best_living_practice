using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SupermeH6Car : H6Builder
    {
        public override void Appearance()
        {
            Console.WriteLine("增加Superme的星空前脸外观");
            Console.WriteLine("增加Superme的颜色：青蓝色");
        }

        public override void Intelligence()
        {
            Console.WriteLine("增加Superme的L2+水平智能");
            Console.WriteLine("增加Superme的雷达系统：前后雷达");
        }
    }
}

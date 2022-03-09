using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.task1_before
{
    public class SportPants : IFinery
    {
        public void Show()
        {
            Console.WriteLine("穿上运动裤");
        }
    }
}

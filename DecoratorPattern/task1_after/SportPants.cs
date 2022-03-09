using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.task1_after
{
    public class SportPants : Finery2
    {
        public SportPants(string name) : base(name)
        {
        }

         
        public override void Show()
        {
            Console.WriteLine("穿上运动裤");
            base.Show();
        }
    }
}

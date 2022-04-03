using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.task1_after
{
    public class UnderPants : Finery2
    {
        public UnderPants(string name) : base(name)
        {
        }

         
        public override void Show()
        {
            Console.WriteLine("穿上底裤");
            base.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.task1_after
{
    public class TShirt : Finery2
    {
        public TShirt(string name) : base(name)
        {
        }

         
        public override void Show()
        {
            Console.WriteLine("穿上T_shirt");
            base.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SupermeH6Car:H6Car
    {
        public override bool Produce()
        {
            this.Name = "Superme版本";
            this.Price = "13w";
            Console.WriteLine(string.Format("{0}完成装配{1}", this.Name, this.Price));
            return true;
        }
    }
}

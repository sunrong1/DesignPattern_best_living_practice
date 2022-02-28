using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class SupremeH6Car : H6Car
    {
        public SupremeH6Car()
        {
            this.Name = "Supreme Version H6";
        }
        public override void ProduceChassis()
        {
            Console.WriteLine(this.Name + "的地盘生产");
        }

        public override void ProduceEngine()
        {
            Console.WriteLine(this.Name + "的发动机生产");
        }

        public override void ProduceTyre()
        {
            Console.WriteLine(this.Name + "的轮胎生产");
        }
    }
}

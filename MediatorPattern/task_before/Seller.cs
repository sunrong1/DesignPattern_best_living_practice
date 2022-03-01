using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.task_before
{
    public class Seller
    {
        public string Name { get; set; }

        public Buyer BuyerMan { get; set; }

        public Seller(string name)
        {
            Name = name;
        }

        public bool Answer(string question)
        {
            Console.WriteLine("收到问题："+ question);
            Console.WriteLine("回答：我是地主，我有很多房子，我卖");
            return true;
        }

        public bool Query(string question)
        {
            BuyerMan.Answer(question);
            return true;
        }
    }
}

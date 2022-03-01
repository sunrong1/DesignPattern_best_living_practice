using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.task_after
{
    public class Seller
    {
        public string Name { get; set; }

        public Mediator MediatorMan { get; set; }

        public Seller(string name, Mediator mediator)
        {
            Name = name;
            MediatorMan = mediator;
        }

        public bool Answer(string question)
        {
            Console.WriteLine("收到问题：" + question);
            Console.WriteLine("回答：我是地主，我有很多房子，我卖");
            return true;
        }

        public bool Query(string question)
        {
            MediatorMan.Answer(Name,question);
            return true;
        }
    }
}

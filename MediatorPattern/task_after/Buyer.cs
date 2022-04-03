using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.task_after
{
    public class Buyer
    {
        public string Name { get; set; }

        public Mediator MediatorMan { get; set; }

        public Buyer(string name, Mediator mediator)
        {
            Name = name;
            MediatorMan = mediator;
        }
        public bool Query(string question)
        {
            MediatorMan.Answer(Name,question);
            return true;
        }

        public bool Answer(string question)
        {
            Console.WriteLine("收到问题：" + question);
            Console.WriteLine("回答：我有钱，我买");
            return true;
        }
    }
}

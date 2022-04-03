using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.task_before
{
    public class Buyer
    {
        public string Name { get; set; }

        public Seller SellerMan { get; set; }
        public Buyer(string name)
        {
            Name = name;
        }
        public bool Query(string question)
        {
            SellerMan.Answer(question);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.task_after
{
    public class Mediator
    {
        public Seller SellerMan { get; set; }
        public Buyer BuyerMan { get; set; }
        public string Name { get; set; }
        public Mediator(string name)
        {
            Name = name;
        }

        public void Answer(string name, string question)
        {
            if (name == "dave")
            {
                SellerMan.Answer(question);
            }
            else if (name == "地主")
            {
                BuyerMan.Answer(question);
            }
        }
    }
}

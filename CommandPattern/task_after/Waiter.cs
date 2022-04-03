using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.task_after
{
    public class Waiter
    {
        private List<Command> orders;

        public Waiter()
        {
            orders = new List<Command>();
        }

        public void RecieveOrder(Command order)
        { 
            orders.Add(order);
        }

        public void NotifyOrder()
        {
            foreach (var item in orders)
            {
                item.ExecteCommand();
            }
        }
    }
}

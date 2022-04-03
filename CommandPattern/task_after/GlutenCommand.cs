using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.task_after
{
    public class GlutenCommand : Command
    {
        public GlutenCommand(Chef chef) : base(chef)
        {
        }

        public override void ExecteCommand()
        {
            chef.ExecuteGlutenCommand();
        }
    }
}

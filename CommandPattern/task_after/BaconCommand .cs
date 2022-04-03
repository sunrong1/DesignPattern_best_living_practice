using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.task_after
{
    public class BaconCommand : Command
    {
        public BaconCommand(Chef chef) : base(chef)
        {
        }

        public override void ExecteCommand()
        {
            chef.ExecuteBaconCommand();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.task_after
{
    public abstract class Command
    {
        protected Chef chef;
        public Command(Chef chef)
        {
            this.chef = chef;
        }
        public abstract void ExecteCommand();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain.task_after
{
    public interface IManager
    {
        public void SetSuperiorManager(IManager manager);
        public bool Handle(Request request);
    }
}

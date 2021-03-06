using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain.task_after
{
    public class CEOManager : IManager
    {
        public string Positon { get; set; }

        private IManager superiorManager;

        public void SetSuperiorManager(IManager manager)
        {
            this.superiorManager = manager;
        }
        public bool Handle(Request request)
        {
            if (request.RequestType == "请假")
            {
                if (request.Number <= 30)
                {
                    Console.WriteLine(Positon + "批准了" + request.RequestType);
                    return true;
                }
                else
                {
                    Console.WriteLine(Positon + "不批准" + request.RequestType);
                    if (superiorManager != null)
                    {
                        return superiorManager.Handle(request);
                    }
                    else
                    { return false;
                    }
                }
            }
            else if (request.RequestType == "加薪")
            {
                if (request.Number <= 2000)
                {
                    Console.WriteLine(Positon + "批准了" + request.RequestType);
                    return true;
                }
                else
                {
                    Console.WriteLine(Positon + "不批准" + request.RequestType);
                    if (superiorManager != null)
                    {
                        return superiorManager.Handle(request);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

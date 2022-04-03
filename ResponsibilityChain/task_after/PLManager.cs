using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain.task_after
{
    public class PLManager : IManager
    {
        private string Positon = "PL";

        private IManager superiorManager;

        public void SetSuperiorManager(IManager manager)
        {
            this.superiorManager = manager;
        }
        public bool Handle(Request request)
        {
            if (request.RequestType == "请假")
            {
                if (request.Number <= 5)
                {
                    Console.WriteLine(Positon + "批准了" + request.RequestType);
                    return true;
                }
                else
                {
                    Console.WriteLine(Positon + "没有权限" + request.RequestType);
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
            else if (request.RequestType == "加薪")
            {
                Console.WriteLine(Positon + "没有权限" + request.RequestType);
                if (superiorManager != null)
                {
                    return superiorManager.Handle(request);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}

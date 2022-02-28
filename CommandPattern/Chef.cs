using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Chef
    {
        public void ExecuteMuttonCommand()
        {
            Console.WriteLine("开始执行订单：" + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void ExecuteBaconCommand()
        {
            Console.WriteLine("开始执行订单：" + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void ExecuteGlutenCommand()
        {
            Console.WriteLine("开始执行订单：" + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}

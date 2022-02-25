using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.task_after
{
    public class VolumeExpression : Expression
    {
        public void Interpreter(string value)
        {
            if (value == "1")
            {
                Console.WriteLine("低音：" + value);
            }
            else
            {
                Console.WriteLine("高音：" + value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.task_after
{
    public class NoteExpression : Expression
    {
        public void Interpreter(string value)
        {
            if (value == "2")
            {
                Console.WriteLine("唱歌音符：" + value);
            }
            else
            {
                Console.WriteLine("唱歌音符：" + value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.task_after
{
    public interface Expression
    {
        public void Interpreter(string value);
    }
}

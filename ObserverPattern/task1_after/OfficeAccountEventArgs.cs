using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class OfficeAccountEventArgs:EventArgs
    {
        public string Message { get; }

        public OfficeAccountEventArgs(string message)
        {
            Message = message;
        }
    }
}

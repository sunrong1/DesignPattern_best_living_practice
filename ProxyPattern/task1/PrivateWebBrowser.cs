using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.task1
{
    public class PrivateWebBrowser
    {
        WebProxy proxy;
        public PrivateWebBrowser()
        {
            proxy = new WebProxy();
        }
        public bool RequestGoogle()
        {
            proxy.RequestGoogle();
            return true;
        }
    }
}

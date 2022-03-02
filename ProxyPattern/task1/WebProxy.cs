using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.task1
{
    public class WebProxy
    {
        private GoogleSite googleSite;
        public WebProxy()
        {
            googleSite = new GoogleSite();
        }
        public bool RequestGoogle()
        {
            Console.WriteLine("开始启用代理");
            Console.WriteLine("访问到了谷歌网站" + googleSite.Content);
            return true;
        }
    }
}

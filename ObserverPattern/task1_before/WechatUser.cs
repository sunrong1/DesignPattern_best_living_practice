using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// subscribe 订阅者
    /// </summary>
    public abstract class WechatUser
    {
        public abstract string Name { get; }

        public abstract void Update(object obj,OfficeAccountEventArgs args);


    }
}

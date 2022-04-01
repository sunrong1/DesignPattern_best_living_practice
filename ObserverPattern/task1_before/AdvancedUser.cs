using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AdvancedUser: WechatUser
    {
        public override string Name { get { return "高级用户"; } }

        public override void Update(object obj, OfficeAccountEventArgs args)
        {
            Console.WriteLine(Name + "接收到消息" + args.Message);
        }
    }
}

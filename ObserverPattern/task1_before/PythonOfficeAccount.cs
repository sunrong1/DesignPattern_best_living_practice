using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class PythonOfficeAccount : OfficeAccount
    {
        List<WechatUser> wechatUsers = new List<WechatUser>();

        public void Attack(WechatUser user)
        {
            wechatUsers.Add(user);
        }

        public void DeAttack(WechatUser user)
        {
            wechatUsers.Remove(user);
        }

        public void PublishNotify()
        {
            foreach (var item in wechatUsers)
            {
                item.Update("New Python 推送消息",null);
            }
        }
    }
}

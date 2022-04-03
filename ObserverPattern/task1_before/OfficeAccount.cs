using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// Subject主题
    /// </summary>
    public interface OfficeAccount
    {
        void Attack(WechatUser user);
        void DeAttack(WechatUser user);

        void PublishNotify();
    }
}

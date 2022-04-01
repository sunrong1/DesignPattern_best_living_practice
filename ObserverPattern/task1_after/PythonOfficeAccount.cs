using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.task1_after
{
    public class PythonOfficeAccount : OfficeAccount
    {
        public event EventHandler<OfficeAccountEventArgs> OnPublishNotify;
        List<WechatUser> wechatUsers = new List<WechatUser>();

        public void PublishNotify()
        {
            OfficeAccountEventArgs args = new OfficeAccountEventArgs("New Python 推送消息");
            if (OnPublishNotify != null)
            {
                OnPublishNotify(this, args);
            }
        }
    }
}

using ObserverPattern;
/// <summary>
/// 观察者模式-发布订阅模式
/// 场景1：微信公众号，发布消息后，就会推送给订阅的用户
/// 对象：公众号 众多用户，一对多对象的关系
/// 行为：众多用户订阅公众号
/// 变化：新的看法
/// </summary>
class Program
{
    /// <summary>
    /// 原始的发布订阅模式
    /// </summary>
    static void Main1()
    {

        OfficeAccount account = new PythonOfficeAccount();
        WechatUser daveUser = new NormalUser();
        WechatUser muUser = new AdvancedUser();
        WechatUser muUser1 = new AdvancedUser();
        WechatUser muUser2 = new AdvancedUser();
        //用户公众号订阅
        account.Attack(daveUser);
        account.Attack(muUser);
        account.Attack(muUser1);
        account.Attack(muUser2);
        //公众号发布消息，订阅者收到
        account.PublishNotify();
        //用户取消订阅
        account.DeAttack(daveUser);
    }

    /// <summary>
    /// 常用的发布订阅模式
    /// 与第一个相比，耦合度更低，更常用
    /// 但是类的构造更复杂，消息传输需要封装成标准形式，传递更困难
    /// </summary>
    static void Main()
    {

        ObserverPattern.task1_after.PythonOfficeAccount account = new ObserverPattern.task1_after.PythonOfficeAccount();
        WechatUser daveUser = new NormalUser();
        WechatUser muUser = new AdvancedUser();
        WechatUser muUser1 = new AdvancedUser();
        WechatUser muUser2 = new AdvancedUser();
        //用户公众号订阅
        account.OnPublishNotify += new EventHandler<OfficeAccountEventArgs>(daveUser.Update);
        account.OnPublishNotify += new EventHandler<OfficeAccountEventArgs>(muUser.Update);
        account.OnPublishNotify += new EventHandler<OfficeAccountEventArgs>(muUser1.Update);
        account.OnPublishNotify += new EventHandler<OfficeAccountEventArgs>(muUser2.Update);
        //公众号发布消息，订阅者收到
        account.PublishNotify();
        //用户取消订阅
        account.OnPublishNotify -= new EventHandler<OfficeAccountEventArgs>(daveUser.Update);
    }
}
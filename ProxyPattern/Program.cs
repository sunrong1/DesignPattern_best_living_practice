using ProxyPattern.task1;
/// <summary>
/// 代理在生活中也随处可见，明星的私人代理，公司代理，网络代理等等
/// 样例1：代理上网
/// 对象：个人浏览器 代理服务器 google
/// 动作：连接Google网站
/// 变化：访问控制，转发等动作增加
/// </summary>
class Program
{
    /// <summary>
    /// 私人网站代理
    /// </summary>
    static void Main()
    {
        PrivateWebBrowser browser = new PrivateWebBrowser();
        browser.RequestGoogle();

    }
}
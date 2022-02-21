/// <summary>
/// 处理请假、加薪的请求
/// 
/// 对象元素：PL，LM，CEO
/// 动作对象:处理员工的请假、加薪请求,当前人没有权限的，需要一级级的审批
/// 变化控制：处理对象顺序可能变化，请求种类有可能扩展
/// </summary>
using ResponsibilityChain;
using ResponsibilityChain.task_after;
using ResponsibilityChain.task_before;

class Program
{
    /// <summary>
    /// 初始一般程序Before
    /// </summary>
    static void Main1()
    {
        Manager pl = new Manager("PL");
        Manager lm = new Manager("LM");
        Manager CEO = new Manager("CEO");

        Request r1 = new Request();
        r1.RequestType = "请假";
        r1.Number = 6;
        r1.RequestContent = "Dave 的年休假";

        Request r2 = new Request();
        r2.RequestType = "加薪";
        r2.Number = 2000;
        r2.RequestContent = "Dave 的年休假";

        if (!pl.handleRequest(r1))
        {
            if (!lm.handleRequest(r1))
            {
                CEO.handleRequest(r1);
            }

        }

        if (!pl.handleRequest(r2))
        {
            if (!lm.handleRequest(r2))
            {
                CEO.handleRequest(r2);
            }
        }

    }

    /// <summary>
    /// 加入责任链模式 程序Before
    /// 
    /// 1. 首先减少了大量的分支判断，避免超级大类出现
    /// 2. 请求链的结构定义清晰，容易修改；
    /// 3. 类与类之间的连接简化，满足迪米特法则
    /// </summary>
    static void Main()
    {
        IManager pl = new PLManager();
        IManager lm = new LMManager();
        IManager CEO = new CEOManager();

        pl.SetSuperiorManager(lm);
        lm.SetSuperiorManager(CEO);

        Request r1 = new Request();
        r1.RequestType = "请假";
        r1.Number = 6;
        r1.RequestContent = "Dave 的年休假";

        Request r2 = new Request();
        r2.RequestType = "加薪";
        r2.Number = 2000;
        r2.RequestContent = "Dave 的年休假";

        pl.Handle(r1);
        pl.Handle(r2);
    }
}

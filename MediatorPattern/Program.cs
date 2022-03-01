/// <summary>
/// 中介者，房屋中介，联合国调停，4S店卖车中介，生活中的中介太多了，中介让我们生活方便多了
/// 对象：买房者 卖房者 中介
/// 动作：我要买房 我要卖方
/// 变化：更多的买房 卖方者 都通过中介管理
/// </summary>
class Program
{
    /// <summary>
    /// 初始程序：
    /// 没有中介者的时代
    /// 买房和卖房者相互联系，耦合严重；
    /// </summary>
    static void Main1()
    {
        MediatorPattern.task_before.Buyer buyer = new MediatorPattern.task_before.Buyer("dave");
        MediatorPattern.task_before.Seller seller = new MediatorPattern.task_before.Seller("地主");
        buyer.SellerMan = seller;
        seller.BuyerMan = buyer;
        buyer.Query("你卖房子吗？");
        seller.Query("你有钱吗？");
    }

    /// <summary>
    /// 版本2：增加中介者，各个买房和卖房都通过中介进行联系，耦合都大大降低
    /// </summary>
    static void Main()
    {
        MediatorPattern.task_after.Mediator mediator = new MediatorPattern.task_after.Mediator("中介");
        MediatorPattern.task_after.Buyer buyer = new MediatorPattern.task_after.Buyer("dave", mediator);
        MediatorPattern.task_after.Seller seller = new MediatorPattern.task_after.Seller("地主",mediator);
        mediator.SellerMan = seller;
        mediator.BuyerMan = buyer;
        buyer.Query("你卖房子吗？");
        seller.Query("你有钱吗？");
    }
}
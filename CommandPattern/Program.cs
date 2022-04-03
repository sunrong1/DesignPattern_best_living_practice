
using CommandPattern;
using CommandPattern.task_after;
/// <summary>
/// 商店吃烤肉串
/// 对象：厨师 订单 
/// 行为：执行订单
/// 变化：订单变化，客户的不同订单需求变化，有可能的取消增加
/// </summary>
class Program
{
    /// <summary>
    /// 初始方式1
    /// 厨师直接接受顾客的订单，简单直接，顾客自己去排队
    /// 缺少订单命令的管理功能；
    /// </summary>
    static void Main1()
    {
        Chef barbecueChef = new Chef();
        barbecueChef.ExecuteMuttonCommand();
        barbecueChef.ExecuteGlutenCommand();
        barbecueChef.ExecuteMuttonCommand();
        barbecueChef.ExecuteBaconCommand();

    }


    /// <summary>
    /// 命令模式
    /// 增加订单管理者
    /// 
    /// </summary>
    static void Main()
    {
        //开店前准备
        Chef chef = new Chef();
        Command oder1 = new BaconCommand(chef);
        Command oder2 = new MuttonCommand(chef);
        Command oder3 = new GlutenCommand(chef);

        Waiter waiter = new Waiter();

        //开始接受订单
        waiter.RecieveOrder(oder1);
        waiter.RecieveOrder(oder1);
        waiter.RecieveOrder(oder1);
        waiter.RecieveOrder(oder2);
        waiter.RecieveOrder(oder2);
        waiter.RecieveOrder(oder2);
        waiter.RecieveOrder(oder3);
        waiter.RecieveOrder(oder3);
        waiter.RecieveOrder(oder3);

        waiter.NotifyOrder();
        waiter.RecieveOrder(oder3);
        waiter.RecieveOrder(oder3);

        waiter.NotifyOrder();

    }
}


using FlyweightPattern.task_sample_dao;
/// <summary>
/// 虚拟世界的共享，一生二 二生三 三生万物
/// 线程池，string字符串池，缓冲池；
/// </summary>
class Program
{
    /// <summary>
    /// 享元模式的方式场景1 ：数据库连接池
    /// </summary>
    static void Main()
    {
        DaoConnect daoConnect = DaoConnectFactory.GetDaoConnect("User");
        daoConnect = DaoConnectFactory.GetDaoConnect("Shop");
        daoConnect = DaoConnectFactory.GetDaoConnect("User");
        daoConnect = DaoConnectFactory.GetDaoConnect("User");
        daoConnect = DaoConnectFactory.GetDaoConnect("User");

    }
}
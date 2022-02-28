

using FlyweightPattern.task_sample_dao;
/// <summary>
/// 虚拟世界的共享，一生二 二生三 三生万物
/// 现实生活中的共享，这个刚开始不太好找，其实也有很多，比如孩子上的学校，小学、初中、高中；比如每个人的家庭等等共享使用的东西；
///线程池，string字符串池，缓冲池；
/// 对象：数据库连接
/// 动作：获得数据库连接
/// 变化：获得多个不同或者相同连接
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
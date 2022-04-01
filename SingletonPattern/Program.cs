using SingletonPattern;

/// <summary>
/// 单例模式
/// 对象：单个对象
/// 行为：对象的创建
/// 变化：只能创建单个
/// </summary>
class Program
{
    /// <summary>
    /// 创建唯一的类，传统
    /// </summary>
    static void Main1()
    {
        IDCard iDCard = new IDCard();

        iDCard.Name = "dave";
        if (iDCard != null)
        {
            iDCard.Id = 1;
        }

    }

    /// <summary>
    /// 方法二，使用私有构造函数，使用静态方法创建类
    /// 一般的方法
    /// </summary>
    static void Main()
    {
        IDCard_thread id = IDCard_thread.GetInstance();

        id.Name = "dave";
        IDCard_thread id2 = IDCard_thread.GetInstance();
        Console.WriteLine(id2.Name);
    }
}

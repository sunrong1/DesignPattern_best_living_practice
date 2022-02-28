using TemplatePattern;
/// <summary>
/// 模板方法模式是非常常用的模式，生活中也随处可见
/// 模板方法属于行为型模式，即行为的分配方式的一种处理。
/// 案例1：制造各种型号的H6，行为制造H6各型号汽车，是一种制造算法，这种算法分为多个不同的步骤
/// 类：各型号H6
/// 动作：制造算法步骤
/// 变化：制造的步骤细节，各型号不同
/// </summary>
class Program
{
    /// <summary>
    /// 构建模板算法，步骤的细节让子类进行实现
    /// </summary>
    static void Main()
    {
        H6Car h6 = new MaxH6Car();
        h6.Produce();

        H6Car h61 = new SupremeH6Car();
        h61.Produce();

    }
}
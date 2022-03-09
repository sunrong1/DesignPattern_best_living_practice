using DecoratorPattern;
using DecoratorPattern.task1_after;
using DecoratorPattern.task1_before;
/// <summary>
/// 案例1：人出门要穿各种不同的衣服；游戏里面人物各种皮肤
/// 对象：各种装饰衣服
/// 行为：穿衣服展示
/// 变化：各种不同的穿法
/// </summary>
class Program
{
    /// <summary>
    /// 原始方法，各种组合方式，自己组合
    /// </summary>
    static void Main1()
    {
        Person p = new Person("Dave");
        IFinery finery = new DecoratorPattern.task1_before.UnderPants();
        finery.Show();
        finery = new DecoratorPattern.task1_before.SportPants();
        finery.Show();
        finery = new DecoratorPattern.task1_before.TShirt();
        finery.Show();
        p.Show();

    }

    /// <summary>
    /// 装饰类的调用方式，类似Stack的调用方式，层层调用后，再逐个返回
    /// </summary>
    static void Main()
    {
        Person p = new Person("Dave");
        Finery2 finery0 = new DecoratorPattern.task1_after.UnderPants("Dave");
        Finery2 finery1= new DecoratorPattern.task1_after.SportPants("Dave");
        Finery2 finery2 = new DecoratorPattern.task1_after.TShirt("Dave");
        finery0.Decorate(p);
        finery1.Decorate(finery0);
        finery2.Decorate(finery1);
        finery2.Show();

    }
}
using BuilderPattern;
/// <summary>
/// 建造者模式，又叫生成器模式
/// 对象：建造过程复杂的对象
/// 稳定的行为：建造步骤比较固定
/// 变化的行为：建造的步骤会发生变化
///
/// 场景1：
/// H6的建造过程稳定，都是三大件，外观和内饰，但是不同的型号创建表示不同
/// 场景2：
/// 机器人的构建过程，二个胳膊 二条腿 头和身体
/// </summary>
class Program
{
    /// <summary>
    /// 建造者模式方式
    /// </summary>
    static void Main()
    {

        H6Builder builder = new MaxH6Car();
        H6Director director = new H6Director(builder);
        director.Build();

        H6Builder builder1 = new SupermeH6Car();
        H6Director director1 = new H6Director(builder1);
        director1.Build();

    }
}
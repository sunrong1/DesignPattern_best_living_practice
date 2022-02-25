using FactoryPattern;
using FactoryPattern.factory_pattern;
using FactoryPattern.simple_factory;
/// <summary>
/// 长城生产H6的汽车产线
/// H6有很多款，自动版，max版本，superme版本，并且版本还会增加
/// 对象：H6各种车
/// 行为：生产
/// 变化：更多款式
/// </summary>
class Program
{
    /// <summary>
    /// 方法1
    /// 客户端创建类，客户端耦合了具体类，修改比较频繁。修改不灵活
    /// 没有封装，功能耦合较严重
    /// </summary>
    static void Main1()
    {
        H6Car h6Car = new MaxH6Car();
        h6Car.Produce();
        H6Car h6Car1 = new SupermeH6Car();
        h6Car1.Produce();
    }

    /// <summary>
    /// 方法2：简单工厂
    /// 新增工厂类，将创建类的活统一给工厂类做，客户端耦合降低，修改扩展方便
    /// 新增车，需要修改至少三处
    /// </summary>
    static void Main2()
    {
        H6Car h6Car = H6Factory.CreateH6Car("Max");
        h6Car.Produce();
        H6Car h6Car1 = H6Factory.CreateH6Car("Superme");
        h6Car1.Produce();
    }

    /// <summary>
    /// 方法3：工厂方式
    /// 新增工厂接口类，将创建类的活统一给工厂类做，客户端耦合降低，扩展方便
    /// 新增车型，只需要修改2处
    /// </summary>
    static void Main()
    {
        IH6Factory factory = new AutoH6CarFactory();
        H6Car h6Car= factory.CreateH6Car();
        h6Car.Produce();
        IH6Factory factory1 = new MaxH6CarFactory();
        H6Car h6Car1 = factory1.CreateH6Car();
        h6Car1.Produce();
    }
}

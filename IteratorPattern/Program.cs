using IteratorPattern.task1;
/// <summary>
/// 访问聚集类中的对象，非常常用，一般被内置。
/// 对象：一组对象
/// 行为：对对象的访问
/// 变化：对象的暴露的表示尽可能少。不暴露对象表示
/// </summary>
class Program
{
    /// <summary>
    /// 
    /// </summary>
    static void Main()
    {

        ConcreteGroup group = new ConcreteGroup();

        group[0] = "sun";
        group[1] = "rong";
        group[2] = "guang";

        Iterator iterator = group.GetIterator();
        while(iterator.Next() != null)
        {
            Console.WriteLine(iterator.CurrentItem);
        }
    }
}
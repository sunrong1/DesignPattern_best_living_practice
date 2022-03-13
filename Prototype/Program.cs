using Prototype;
/// <summary>
/// 场景1:考试试卷的复制，简历的复制，直接初始化复制成本高，能否快速复制？
/// 
/// </summary>
class Program
{
    /// <summary>
    /// 原始方法,修改比较困难，直接重新创建代价高
    /// </summary>
    static void Main1()
    {
        Resume a = new Resume("dave", "22");
        a.SetWorkExprience("多年项目经验");

        Resume b = a;

        b.SetWorkExprience("丰富的项目经验");
        a.Display();
        b.Display();


    }

    /// <summary>
    /// 克隆方法，浅复制
    /// </summary>
    static void Main2()
    {
        Resume a = new Resume("dave", "22");
        a.SetWorkExprience("多年项目经验");

        Resume b = (Resume)a.Clone();

        b.SetWorkExprience("丰富的项目经验");
        a.Display();
        b.Display();
    }

    /// <summary>
    /// 克隆方法，深复制
    /// </summary>
    static void Main()
    {
        Resume a = new Resume("dave", "22");
        a.SetWorkExprience("多年项目经验");
        a.SetSchool("上海大学","延长校区");
        Resume b = (Resume)a.Clone();

        b.SetWorkExprience("丰富的项目经验");
        b.SetSchool("清华大学", "北京校区");
        a.Display();
        b.Display();
        
        //深度复制
        Resume c = (Resume)a.Clone2();
        c.SetSchool("北京大学", "北京校区");
        c.Display();
    }
}
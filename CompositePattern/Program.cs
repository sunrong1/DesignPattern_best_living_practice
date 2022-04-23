using CompositePattern;
/// <summary>
/// 组合模式，俄罗斯套娃模式，树形结构，不关注类的细节, 只做容器。
/// C#也内置了组合模式，组件模式
/// 场景1：大学 学院 专业
/// 场景2：文件夹中 有文件和文件夹 下面的文件夹同样有文件和文件夹
/// 场景3：公司 有部门和子公司 子公司也有部门和子公司
/// 对象：一组对象
/// 行为：对对象的访问
/// 变化：对象的暴露的表示尽可能少。不暴露对象表示
/// </summary>
class Program
{
    /// <summary>
    /// 场景1：Linux操作系统中的文件和文件夹的管理模式
    /// </summary>
    static void Main()
    {
        FileComponent root = new FileDirector("/");
        FileComponent home = new FileDirector("Home");
        FileComponent rootUser = new FileDirector("Root");
        FileComponent bin = new FileDirector("Bin");
        FileComponent ls = new FileLeaf("ls");
        FileComponent cp = new FileLeaf("Cp");
        FileComponent daveFile = new FileLeaf("daveFile");
        
        root.Add(rootUser);
        rootUser.Add(daveFile);
        root.Add(home);
        root.Add(bin);
        bin.Add(ls);
        bin.Add(cp);
        root.Operation(1);
    }
}
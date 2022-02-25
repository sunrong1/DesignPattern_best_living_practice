using InterpreterPattern;
using InterpreterPattern.task_after;
/// <summary>
/// 场景：
/// 将乐谱翻译，进行演奏出来
/// 
/// 对象：乐谱 演奏者, 乐谱又分为：控制者和演奏方式
/// 动作：进行乐谱翻译
/// 变化：有可能乐谱增加，乐谱解释的方式增加；
/// </summary>
class Program
{
    /// <summary>
    /// 初始一般程序Before
    /// </summary>
    static void Main1()
    {
        PlayText playtext = new PlayText();
        playtext.Text = "A 1 B 2 B 3 B 2 A 2 B 1 B 2";
        while (playtext.Text.Length > 2)
        {
            string key = playtext.Text.Substring(0,1);
            string value = playtext.Text.Substring(2,1);

            switch (key)
            {
                case "A":
                    if (value == "1")
                    {
                        Console.WriteLine("低音：" + value); 
                    }
                    else
                    {
                        Console.WriteLine("高音：" + value);
                    }
                    break;

                case "B":
                    if (value == "2")
                    {
                        Console.WriteLine("唱歌音符：" + value); break;
                    }
                    else
                    {
                        Console.WriteLine("唱歌音符：" + value); break;
                    }
                    
                default:Console.WriteLine("识别错误：" + key);break;
            }
            if (playtext.Text.Length > 4)
            {
                playtext.Text = playtext.Text.Substring(4);
            }
            else
            {
                break;
            }
        }
       
    }

    /// <summary>
    /// 使用解释器模式后
    /// </summary>
    static void Main()
    {
        PlayText playtext = new PlayText();
        playtext.Text = "A 1 B 2 B 3 B 2 A 2 B 1 B 2";
        Expression expression=null;
        while (playtext.Text.Length > 2)
        {
            string key = playtext.Text.Substring(0, 1);
            string value = playtext.Text.Substring(2, 1);

            switch (key)
            {
                case "A":
                    expression = new VolumeExpression();
                    break;
                case "B":
                    expression = new NoteExpression();
                    break;
                default: Console.WriteLine("识别错误：" + key); break;
            }
            expression.Interpreter(value);
            if (playtext.Text.Length > 4)
            {
                playtext.Text = playtext.Text.Substring(4);
            }
            else
            {
                break;
            }
        }

    }
}
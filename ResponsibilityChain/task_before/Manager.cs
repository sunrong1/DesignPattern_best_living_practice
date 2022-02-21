using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain.task_before
{
    /// <summary>
    /// 常规写法
    /// </summary>
    public class Manager
    {
        public Manager(string postion)
        {
            this.positon = postion;
        }
        private string positon { get; set; }
        public bool handleRequest(Request request)
        {
            if (positon == "PL" )
            {
                if (request.RequestType == "请假" )
                {
                    if (request.Number <= 5)
                    {
                        Console.WriteLine(positon + "批准了" + request.RequestType);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(positon + "没有权限" + request.RequestType);
                        return false;
                    }
                }
                else if (request.RequestType == "加薪")
                {
                    Console.WriteLine(positon + "没有权限" + request.RequestType);
                }
            }
            else if (positon == "LM")
            {
                if (request.RequestType == "请假")
                {
                    if (request.Number <= 14)
                    {
                        Console.WriteLine(positon + "批准了" + request.RequestType);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(positon + "没有权限" + request.RequestType);
                        return false;
                    }
                }
                else if (request.RequestType == "加薪")
                {
                    if (request.Number <= 1000)
                    {
                        Console.WriteLine(positon + "批准了" + request.RequestType);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(positon + "没有权限" + request.RequestType);
                        return false;
                    }
                }
            }
            else if (positon == "CEO")
            {
                if (request.RequestType == "请假")
                {
                    if (request.Number <= 30)
                    {
                        Console.WriteLine(positon + "批准了" + request.RequestType);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(positon + "不批准" + request.RequestType);
                        return false;
                    }
                }
                else if (request.RequestType == "加薪")
                {
                    if (request.Number <= 2000)
                    {
                        Console.WriteLine(positon + "批准了" + request.RequestType);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine(positon + "不批准" + request.RequestType);
                        return false;
                    }
                }
            }
            return false;
        }
    }
}

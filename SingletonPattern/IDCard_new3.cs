using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 饿汉式简化方式的单例模式
    /// sealed：防止派生
    /// 
    /// </summary>
    public sealed class IDCard_new3
    {
        /// <summary>
        /// 饿汉式创建方式
        /// </summary>
        private static readonly IDCard_new3 instance = new IDCard_new3();

        public int Id { get; set; }

        public string Name { get; set; }

        private IDCard_new3() { }

        /// <summary>
        /// 简化的代码，保证唯一性和多线程安全使用
        /// </summary>
        /// <returns></returns>
        public static IDCard_new3 GetInstance()
        {
            return instance;
        }
    }
}

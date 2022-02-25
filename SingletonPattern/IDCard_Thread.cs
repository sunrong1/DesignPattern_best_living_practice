using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class IDCard_thread
    {
        private static IDCard_thread instance;

        public static readonly object syncLock = new object();
        public int Id { get; set; }

        public string Name { get; set; }

        private IDCard_thread() { }

        /// <summary>
        /// 双重锁定，保证效率和创建的类的唯一性
        /// </summary>
        /// <returns></returns>
        public static IDCard_thread GetInstance()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new IDCard_thread();
                    }
                }
            }
            return instance;
        }
    }
}

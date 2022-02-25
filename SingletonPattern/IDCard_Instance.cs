using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class IDCard_instance
    {
        private static IDCard_instance instance;

        public int Id { get; set; }

        public string Name { get; set; }

        private IDCard_instance() { }

        public static IDCard_instance GetInstance()
        {
            if (instance == null)
            {
                instance = new IDCard_instance();
            }
            return instance;
        }
    }
}

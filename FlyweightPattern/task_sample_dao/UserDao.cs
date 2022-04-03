using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.task_sample_dao
{
    public class UserDao:DaoConnect
    {
        public UserDao()
        {
            this.Name = "User";
        }

        public override string GetConnect()
        {
            Console.WriteLine("获得了链接：" + this.Name);
            return this.Name;
        }
    }
}

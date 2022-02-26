using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.task_sample_dao
{
    public class DaoConnectFactory
    {
        private static Dictionary<string, DaoConnect> daoConnects = new Dictionary<string, DaoConnect>();

        public static DaoConnect GetDaoConnect(string name)
        {
            DaoConnect daoConnect;
            if (daoConnects.ContainsKey(name))
            {
                daoConnect= daoConnects.GetValueOrDefault(name);
            }
            else
            {
                daoConnect = new UserDao();
                daoConnects.Add(name, daoConnect);
            }
            Console.WriteLine("Dao连接的数量：" + daoConnects.Count);
            return daoConnect;
        }
    }
}

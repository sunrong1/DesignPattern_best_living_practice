using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.task_sample_dao
{
    public abstract class DaoConnect
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public abstract string GetConnect();
    }
}

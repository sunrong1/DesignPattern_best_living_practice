using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.task1
{
    /// <summary>
    /// 聚集者类，可以直接或者迭代器的聚集者类
    /// </summary>
    public interface IGroup
    {
        Iterator GetIterator();
    }
}

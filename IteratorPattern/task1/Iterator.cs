using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.task1
{
    /// <summary>
    /// 核心迭代器接口
    /// </summary>
    public interface Iterator
    {
        object First();
        object Next();

        bool isFinised();

        object CurrentItem();
    }
}

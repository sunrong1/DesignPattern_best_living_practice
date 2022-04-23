using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.task1
{
    /// <summary>
    /// 具体类的迭代器
    /// </summary>
    public class ConcreteInterator : Iterator
    {
        private ConcreteGroup group;
        int currentNum =0;
        public ConcreteInterator(ConcreteGroup group)
        {
            this.group = group;
        }
        public object CurrentItem()
        {
            return group[currentNum];
        }

        public object First()
        {
            return group[0];
        }

        public bool isFinised()
        {
            if(currentNum >= group.Count()-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            if (isFinised())
            {
                return null;
            }
            currentNum++;
            return group[currentNum];
        }
    }
}

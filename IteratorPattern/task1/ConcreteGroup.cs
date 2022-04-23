using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.task1
{
    public class ConcreteGroup : IGroup
    {
        private IList<object> items = new List<object>();
        public Iterator GetIterator()
        {
            return new ConcreteInterator(this);
        }

        public int Count()
        { return items.Count; }

        public object this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }
}

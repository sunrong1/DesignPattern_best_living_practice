using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class FileLeaf : FileComponent
    {
        public FileLeaf(string name) : base(name)
        {
        }

        public override void Add(FileComponent component)
        {
            throw new NotImplementedException();
        }

        public override FileComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public override bool Operation(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("我是文件：" + GetName());
            return true;
        }

        public override void Remove(FileComponent component)
        {
            throw new NotImplementedException();
        }
    }
}

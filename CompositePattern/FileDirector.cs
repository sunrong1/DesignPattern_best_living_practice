using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class FileDirector : FileComponent
    {
        List<FileComponent> components = new List<FileComponent>();

        public FileDirector(string name) : base(name)
        {
        }

        public override void Add(FileComponent component)
        {
            components.Add(component);
        }

        public override FileComponent GetChild(int i)
        {
            return components[i];
        }

        public override bool Operation(int depth)
        {
            for(int i = 0; i < depth; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("我是文件夹：" + GetName());
            foreach (var item in components)
            {
                item.Operation(depth+1);
            }
            return true;
        }

        public override void Remove(FileComponent component)
        {
            components.Remove(component);
        }
    }
}

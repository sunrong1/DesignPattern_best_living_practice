using DecoratorPattern.task1_before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        { 
            Name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("展示完毕:" + Name);
        }
    }
}

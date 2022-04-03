using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.task1_after
{
    public class Finery2:Person
    {
        protected Person person;

        public Finery2(string name) : base(name)
        {
        }

        public void Decorate(Person person)
        {
            this.person = person;
        }
        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}

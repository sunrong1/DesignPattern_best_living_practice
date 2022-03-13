using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Resume:ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Age { get; set; }

        SchoolInfo schoolInfo = new SchoolInfo();
        public Resume(string name,string age)
        {
            Name = name;
            Age = age;
        }

        public void SetWorkExprience(string description)
        {
            this.Description = description;
        }

        public void SetSchool(string schoolName,string schoolDescription)
        {
            schoolInfo.Name = schoolName;
            schoolInfo.Description = schoolDescription;
        }

        public void Display()
        {
            Console.WriteLine("信息：" +Age+ Description+ Name);
            Console.WriteLine("学校：" + schoolInfo.Name);
        }

        public object Clone()
        {
           return this.MemberwiseClone();
        }

        public object Clone2()
        {
            Resume resume = new Resume(this.Name,this.Age);
            resume.schoolInfo= (SchoolInfo)schoolInfo.Clone();
            resume.SetWorkExprience(this.Description);
            return resume;
        }
    }
}

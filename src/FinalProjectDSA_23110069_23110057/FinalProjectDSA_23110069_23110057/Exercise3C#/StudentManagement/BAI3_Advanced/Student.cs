using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_Advanced
{
    public class Student
    {
        private string id;
        private string name;
        private string major;
        private string phoneNum;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Major { get => major; set => major = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        public Student() { }
        public Student(string id, string name, string major, string phoneNum)
        {
            this.id = id;
            this.name = name;
            this.major = major;
            this.phoneNum = phoneNum;
        }  
    }
}

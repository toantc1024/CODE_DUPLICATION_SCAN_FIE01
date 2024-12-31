using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList_C_
{
    internal class Person
    {
        private string name;
        private string age;
        private string sex;
        private string height;
        private string weight;
        public string Name { get => name; set { name = value; } }
        public string Age { get => age; set { age = value; } }
        public string Sex { get => sex; set { sex = value; } }
        public string Height { get => height; set { height = value; } }
        public string Weight { get => weight; set { weight = value; } }

        public Person(string Name, string Age, string Sex)
        {
            this.Name = Name;
            this.Age = Age;
            this.Sex = Sex;
        }
        public void TakeInfo(string fullName, string age, string sex)
        {
            Name = fullName;
            Age = age;
            Sex = sex;

        }
        public void TakeInfo(string fullName, string age, string sex, string height, string weight)
        {
            Name = fullName;
            Age = age;
            Sex = sex;
            Height = height;
            Weight = weight;
        }
        public double CalculateBMI(double height, double weight)
        {
            double BMI;
            BMI = weight / (height * height);
            return Math.Round(BMI,2);
        }
    }
}

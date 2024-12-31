using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_linked_list_generic
{
    public class Student
    {
        public string name;
        public string id;
        public int age;

        public Student(string name, string id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {name}, ID: {id}, Age: {age}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CLinkedListGeneric<Student> students = new CLinkedListGeneric<Student>();
            students.AddLast(new Student("Mai", "22119056", 22));
            students.AddLast(new Student("Hoang", "22119055", 21));
            students.AddLast(new Student("Dung", "22119054", 20));


            Console.WriteLine("Danh sach sinh vien sau khi them:");
            students.PrintList();

            var foundStudents = students.FindNodesByAge(s => s.age >= 21);
            Console.WriteLine("\nSinh vien co do tuoi >= 21:");
            foreach (var student in foundStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xep theo ten:");
            students.SelectionSort();

            students.AddFirst(new Student("Anna", "22119057", 19));
            Console.WriteLine("\nDanh sach sinh vien sau khi them sinh vien vao dau danh sach:");
            students.PrintList();

            students.RemoveFirst();
            Console.WriteLine("\nDanh sach sinh vien sau khi xoa sinh vien dau danh sach:");
            students.PrintList();

            students.RemoveLast();
            Console.WriteLine("\nDanh sach sinh vien sau khi xoa sinh vien cuoi danh sach:");
            students.PrintList();

            var searchResult = students.FindNodes(s => s.name == "Dung");
            Console.WriteLine("\nKet qua tim kiem sinh vien co ten 'Dung':");
            foreach (var student in searchResult)
            {
                Console.WriteLine(student);
            }

            CLinkedListGeneric<Student> list1 = new CLinkedListGeneric<Student>();
            list1.AddLast(new Student("Alice","1", 20));
            list1.AddLast(new Student("Bob", "2",22));
            list1.AddLast(new Student("Charlie", "3", 21));

            CLinkedListGeneric<Student> list2 = new CLinkedListGeneric<Student>();
            list2.AddLast(new Student("David", "4", 23));
            list2.AddLast(new Student("Eve", "5", 20));
            list2.AddLast(new Student("Frank", "6", 24));

            Console.WriteLine("\nDanh sach 1:");
            list1.PrintList();

            Console.WriteLine("\nDanh sach 2:");
            list2.PrintList();

            CLinkedListGeneric<Student> mergedList = list1.MergeTwoLists(list1, list2);

            Console.WriteLine("\nDanh sach sau khi hop nhat:");
            mergedList.PrintList();

            Console.WriteLine("\nKet thuc test");
            Console.Read();
        }
    }
}

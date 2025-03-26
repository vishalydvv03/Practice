using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }


    class Program
    {
        //public static int CompareNames(Student obj1, Student obj2)
        //{
        //    return obj1.Name.CompareTo(obj2.Name);
        //}
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student() { Id = 100, Name = "Vishal" });
            list.Add(new Student() { Id = 2, Name = "Harsh" });
            list.Add(new Student() { Id = 300, Name = "Yash" });
            list.Add(new Student() { Id = 1, Name = "Vivek" });

            //Comparison<Student> stud = new Comparison<Student>(CompareNames);

            //list.Sort(CompareNames);

            //list.Sort(delegate (Student s1, Student s2) 
            //{
            //    return s1.Name.CompareTo(s2.Name);
            //}
            //); 

            //using Lambda Expr
            list.Sort((s1,s2)=>s1.Name.CompareTo(s2.Name));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Student Name : {list[i].Name} & ID : {list[i].Id}");
            }

            Console.ReadKey();
        }
    }
}

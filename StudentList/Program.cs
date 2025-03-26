using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    public class Student :IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student obj)
        {
            if(this.Id > obj.Id)
            {
                return 1;
            }
            else if(this.Id < obj.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student() {Id =10, Name="Vishal" });
            list.Add(new Student() { Id = 2, Name = "Harsh" });
            list.Add(new Student() { Id = 300, Name = "Yash" });
            list.Add(new Student() { Id = 1, Name = "Vivek" });

            list.Sort();

            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine($"Student Name : {list[i].Name} & ID : {list[i].Id}");
            }

            Console.ReadKey();
        }
    }
}

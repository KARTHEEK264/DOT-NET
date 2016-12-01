using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSample
{
    struct Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
        {
            new Student() { ID = 1, Name = "John", Age =21},
            new Student() { ID = 2, Name = "Joe", Age =24},
            new Student() { ID = 3, Name = "Jason", Age =25},
            new Student() { ID = 4, Name = "Joy", Age =22},
            new Student() { ID = 5, Name = "Joseph", Age =23},
        };

           // Student match = student.Find(s => s.ID == 3);
            double averageAge = student.Average(s => s.Age);
            Console.WriteLine($"Average age is {averageAge}");
            Console.ReadLine();


        }
    }
}
//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Student
    {
        public int Id;
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van Anh" },
                new Student { Id = 2, Name = "Tran Thi Be" },
                new Student { Id = 3, Name = "Le Minh Ca" }
            };
            Console.WriteLine($"Tong so sinh vien: {students.Count}");
        }
    }
}

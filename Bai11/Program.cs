//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Student
    {
        public int Id;
        public string Name;
    }

    internal class program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van A" },
                new Student { Id = 2, Name = "Tran Thi B" },
                new Student { Id = 3, Name = "Le Minh C" }
            };

            Console.WriteLine("Danh sách sinh viên:");
            Console.WriteLine("--------------------------");
            foreach (var sv in students)
                Console.WriteLine($"ID: {sv.Id} | Tên: {sv.Name}");
        }
    }
}

//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
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
                new Student { Id = 1, Name = "Nguyen Van Anh" },
                new Student { Id = 2, Name = "Tran Thi Be" },
                new Student { Id = 3, Name = "Le Minh Ca" }
            };
            Console.Write("Nhap ten can tim: ");
            string keyword = Console.ReadLine().ToLower();

            var results = students.FindAll(sv =>
                sv.Name.ToLower().Contains(keyword));

            if (results.Count == 0)
                Console.WriteLine("Khong tim thay sinh vien nao.");
            else
            {
                Console.WriteLine("Ket qua tim kiem:");
                foreach (var sv in results)
                    Console.WriteLine($"ID: {sv.Id} | Tên: {sv.Name}");
            }
        }
    }
}

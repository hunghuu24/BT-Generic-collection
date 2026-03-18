//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    internal class Program
    {
        class Student
        {
            public int Id;
            public string Name;
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van Anh" },
                new Student { Id = 2, Name = "Tran Thi Be" },
                new Student { Id = 3, Name = "Le Minh Ca" }
            };
            Console.Write("Nhap ID can xoa: ");
            int idToDelete = int.Parse(Console.ReadLine());

            Student found = students.Find(sv => sv.Id == idToDelete);

            if (found != null)
            {
                students.Remove(found);
                Console.WriteLine($"Đã xoa sinh vien: {found.Name}");
            }
            else
                Console.WriteLine("Khong tim thay sinh vien voi ID này.");

            Console.WriteLine("\nDanh sach sau khi xoa:");
            foreach (var sv in students)
                Console.WriteLine($"ID: {sv.Id} | Ten: {sv.Name}");
        }
    }
}

//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        class Student
        {
            public string Name;
            public double Score;
        }
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>
            {
                new Student { Name = "Nguyen Van An",  Score = 8.5 },
                new Student { Name = "Tran Thi Binh",  Score = 9.2 },
                new Student { Name = "Le Minh Cuong",  Score = 7.8 },
                new Student { Name = "Pham Thi Dung",  Score = 9.2 }
            };

                Console.WriteLine("Danh sach sinh vien:");
                Console.WriteLine("-------------------------------");
                foreach (var sv in students)
                    Console.WriteLine($"Ten: {sv.Name,-20} | Điem: {sv.Score}");

                double maxScore = 0;
                foreach (var sv in students)
                    if (sv.Score > maxScore) maxScore = sv.Score;

                Console.WriteLine("\nSinh vien có điem cao nhat:");
                Console.WriteLine("-------------------------------");
                foreach (var sv in students)
                    if (sv.Score == maxScore)
                        Console.WriteLine($"Ten: {sv.Name,-20} | Điem: {sv.Score}");
        }
    }
}

//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu [{i + 1}]: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            int maxCount = 0;
            int mostFrequent = 0;
            foreach (var pair in freq)
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequent = pair.Key;
                }

            Console.WriteLine($"So xuat hien nhieu nhat: {mostFrequent} (xuat hien {maxCount} lan)");
        }
    }
}

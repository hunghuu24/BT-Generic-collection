//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string input = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            Console.WriteLine("\nSo lan xuat hien cua moi ky tu:");
            foreach (var pair in charCount)
                Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}

//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]: ", i);
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }
            for(int i = list.Count - 1; i >= 0; i--)
                Console.Write("{0} ", list[i]);
        }
    }
}

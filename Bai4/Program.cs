using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
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
            foreach (int x in list)
            {
                if(x % 2 == 0)
                    Console.Write("{0} ", x);
            }    
        }
    }
}

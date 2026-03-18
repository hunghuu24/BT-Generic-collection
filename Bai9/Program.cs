//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
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
            Console.Write("List ban dau: ");
            foreach (int x in list)
                Console.Write("{0} ", x);
            for (int i = 0; i < list.Count; i++)
                for (int j = i + 1; j < list.Count; j++)
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        j--;
                    }
            Console.Write("\nList sau khi xoa phan tu trung:");
            foreach (int x in list)
                Console.Write("{0} ", x);
        }
    }
}

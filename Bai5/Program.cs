using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                String x = Console.ReadLine();
                list.Add(x);
            }
            foreach (String x in list)
                Console.WriteLine("{0} ", x);
            Console.Write("Nhap ten can xoa: ");
            String y = Console.ReadLine();
            list.Remove(y);
            foreach (String x in list)
                Console.WriteLine("{0} ", x);
        }
    }
}

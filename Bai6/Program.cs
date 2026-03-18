using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                String x = Console.ReadLine();
                list.Add(x);
            }
            foreach (String x in list)
                Console.WriteLine("{0} ", x);
            Console.Write("Nhap chuoi can tim: ");
            String y = Console.ReadLine();
            int s = 0;
            foreach (String x in list)
                if (x == y)
                    s = 1;
            if (s == 1)
                Console.WriteLine("Co ton tai");
            else
                Console.WriteLine("Khong ton tai");
        }
    }
}

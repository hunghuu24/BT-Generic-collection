using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }
            Console.Write("5 so bat ki: ");
            foreach (int i in list)
                Console.Write("{0} ", i);
        }
    }
}

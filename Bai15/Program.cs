//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
        {
            { "hello",    "Xin chao" },
            { "goodbye",  "Tạm biet" },
            { "thank you","Cam on" },
            { "sorry",    "Xin loi" },
            { "yes",      "Co" },
            { "no",       "Khong" }
        };

            Console.Write("Nhap tu tieng Anh can tra: ");
            string word = Console.ReadLine().ToLower();

            if (dict.ContainsKey(word))
                Console.WriteLine($"Nghia tieng Viet: {dict[word]}");
            else
                Console.WriteLine("Khong tim thay tu nay trong tu đien.");
        }
    }
}

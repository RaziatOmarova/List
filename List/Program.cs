using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Sake = new List<string>  { "Екатерина", "Виктория", "Виктор", "Андрей", "Аня" };
            Console.WriteLine(Name(Sake));
            Console.ReadKey();
        }
        public static int Name(List<string> number)
        {
            int n = 0;
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i].Length >= 7)
                {
                    n++;
                }
            }
            return n;
        }
    }
}

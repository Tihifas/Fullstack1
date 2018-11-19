using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELOOO!");
            Console.WriteLine("Args Length = " + args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Args[" + i + "] = " + args[0]);
                Console.WriteLine("Args[" + i + "] = " + args[0]);
                Console.WriteLine("Args[" + i + "] = " + args[0]);

            }
            Console.ReadKey();
        }
    }
}

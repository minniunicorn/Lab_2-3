using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySum
{
    class MySum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum");
            Console.WriteLine(args.Length);
            Console.WriteLine(Convert.ToInt32(args[0])+Convert.ToInt32(args[1]));
            Console.ReadKey();
        }
    }
}

using PatterSingleton.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Logger.Default();
            var b = Logger.DefaultMultiThread();
            if (a == b)
            {
                Console.WriteLine("same instance");
            }
            Logger.Default().LogError("error to log");
            Console.ReadKey();
        }
    }
}

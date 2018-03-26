using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterSingleton.Log
{
    public class Logger : IDisposable
    {
        private static object locker = new object(); //support multi thread

        private static Logger instance;
        public static Logger Default() //Similar to MemoryCache class name .Default
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public static Logger DefaultMultiThread() //Similar to MemoryCache class name .Default
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public bool LogError(string Message)
        {
            Console.WriteLine(string.Format("Error message '{0}' saved",Message));
            return true;
        }

        public void Dispose()
        {
            //with singleton we can implement interfaces
            Console.WriteLine("Disposed, just to show an advantaje over just static classes");
        }
    }
}

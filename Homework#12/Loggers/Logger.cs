using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12.Loggers
{
    internal class Logger: IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Logger Disposed");
        }
    }
}

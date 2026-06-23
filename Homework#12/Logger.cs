

namespace Homework_12
{
    internal class Logger : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Logger Disposed");
        }
    }
}

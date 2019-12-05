using System;
using MyLibrary;

namespace NET471
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Say().Hello();
            Console.WriteLine(message);
        }
    }
}

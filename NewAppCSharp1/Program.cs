using System;

namespace NewAppCSharp1
{
    class Program
    {
        static void Howdy()
            {
                Console.WriteLine("Howdy World!");
            }

        static void Main(string[] args)
        {
            Bye yo = new Bye();
            Howdy();
            yo.Duces();
        }
    }
}

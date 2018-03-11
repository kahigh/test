using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("How are your name?");
            string str = Console.ReadLine();
            
            Console.WriteLine("Hello {0}!", str);

            // новые изменения
            Console.ReadLine();
        }
    }
}

using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object Oriented Program");
            DemoJson json = new DemoJson();
            json.Read();
        }
    }
}

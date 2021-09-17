using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("enter ur age: ");
            string age = Console.ReadLine();
            Console.WriteLine("hello "+name + "ur age is " + age);
            Console.ReadLine();
        }
    }
}
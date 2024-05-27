using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("plz enter a:");
            string num1;
            num1 = Console.ReadLine();
            a = int.Parse(num1);
            Console.WriteLine("plz enter b:");
            string num2;
            num2 = Console.ReadLine();
            b = int.Parse(num2);
            int avg;
            avg = (a + b) / 2;
            if (avg > a) 
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }
    }
}

using System;

namespace ConsoleCS
{
    public class Program
    {
        static public int time(int a)
        {
            return (a / 60);
        }
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int a = time(int.Parse(S));
            Console.Write("m = ");
            Console.Write(a);
            Console.ReadKey();
        }
    }
}

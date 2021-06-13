using System;

namespace FinalTest_pt3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ3
            static void Main(string[] args)
            {
                string input = Console.ReadLine();
                while (input != "End")
                {
                    input = Console.ReadLine();
                }
                Console.WriteLine("Find what?: ");
                string mode = Console.ReadLine();
                if (mode == "FindMax")
                {
                    byte a = Math.Max(input, input);
                    Console.WriteLine(a);
                }
                else if (mode == "FindMin")
                {
                    byte b = Math.Min(input, input);
                    Console.WriteLine(b);
                }
                else if (mode == "FindMean")
                {
                    byte c = Math.Min(input, input);
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine("Invalid Mode");

            }
        }
    }
}

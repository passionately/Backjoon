using System;

namespace 조건문2
{
    class 시험성적
    {
        static void Main(string[] args)
        {
            string e = Console.ReadLine();
            int E = int.Parse(e);

            if (0 <= E && E <= 100)
            {
                if (90 <= E && E <= 100)
                {
                    Console.WriteLine("A");
                }
                else if (80 <= E && E <= 89)
                {
                    Console.WriteLine("B");
                }
                else if (70 <= E && E <= 79)
                {
                    Console.WriteLine("C");
                }
                else if (60<= E && E <=69)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
        }
    }
}
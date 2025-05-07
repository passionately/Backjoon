using System;

namespace 반복문9
{
    class 별찍기1
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int N = int.Parse(n);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
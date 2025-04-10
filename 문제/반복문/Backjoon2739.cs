using System;

namespace 반복문1
{
    class 구구단
    {
        static void Main(string[] args)
        {
            string bj = Console.ReadLine();
            int N = int.Parse(bj);

            if (1 <= N && N <= 9)
            {
                for (int i = 1; i <= 9; i++)
                {
                    int S = N * i;
                    Console.WriteLine(N + " * " + i + " = " + S);
                }
            }
        }
    }
}
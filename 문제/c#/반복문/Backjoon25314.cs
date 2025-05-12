using System;

namespace 반복문5
{
    class 코딩은체육과목입니다
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int N = int.Parse(n);

            if (4 <= N && N <= 1000 && N % 4 == 0)
            {
                int B = N / 4;

                for (int i = 1; i <= B; i++)
                {
                    Console.Write("long" + " ");
                } Console.WriteLine("int");
            }
        }
    }
}
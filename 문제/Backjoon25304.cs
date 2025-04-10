using System;

namespace 반복문4
{
    class 영수증
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int X = int.Parse(x); // 총 금액

            string n = Console.ReadLine();
            int N = int.Parse(n); // 산 물건 갯수

            if (1 <= X && X <= 1000000000)
            {
                if (1 <= N && N <= 100)
                {
                    int S = 0, T = 0;

                    for (int i = 1; i <= N; i++)
                    {
                        string[] C = Console.ReadLine().Split();
                        int a = int.Parse(C[0]);
                        int b = int.Parse(C[1]);

                        S = a * b;
                        T += S;
                    } 
                    
                    if (X == T)
                    {
                        Console.WriteLine("Yes");
                    } else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }
    }
}
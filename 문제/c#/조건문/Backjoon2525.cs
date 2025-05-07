using System;

namespace 조건문6
{
    class 오븐시계
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split();
            int A = int.Parse(t[0]);
            int B = int.Parse(t[1]);

            string n = Console.ReadLine();
            int C = int.Parse(n);

            if (0 <= A && A <= 23 && 0 <= B && B <= 59 && 0 <= C && C <= 1000)
            {
                int D = B + C;
                int R = A + D / 60; // 끝나는 시
                int S = D % 60; // 끝나는 분

                if (59 >= D && D >= 0)
                {
                    Console.WriteLine(A + " " + D);
                } else
                {
                    if (R >= 24)
                    {
                        R -= 24;
                        Console.WriteLine(R + " " + S);
                    } else
                    {
                        Console.WriteLine(R + " " + S);
                    }
                }
            }
        }
    }
}
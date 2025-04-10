using System;

namespace 조건문7
{
    class 주사위세개
    {
        static void Main(string[] args)
        {
            string[] bj = Console.ReadLine().Split();
            int f = int.Parse(bj[0]);
            int s = int.Parse(bj[1]);
            int t = int.Parse(bj[2]);

            if (1 <= f && f <= 6 && 1 <= s && s <= 6 && 1 <= t && t <= 6)
            {
                if (f == s && s == t)
                {
                    int M = 10000 + f * 1000;
                    Console.WriteLine(M);
                } else if (f == s)
                {
                    int M = 1000 + f * 100;
                    Console.WriteLine(M);
                } else if (s == t)
                {
                    int M = 1000 + s * 100;
                    Console.WriteLine(M);
                } else if (f == t)
                {
                    int M = 1000 + t * 100;
                    Console.WriteLine(M);
                } else
                {
                    if (f > s && f > t)
                    {
                        int M = f * 100;
                        Console.WriteLine(M);
                    } else if (s > f && s > t) {
                        int M = s * 100;
                        Console.WriteLine(M);
                    } else
                    {
                        int M = t * 100;
                        Console.WriteLine(M);
                    }
                }
            }
        }
    }
}
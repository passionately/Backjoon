using System;

namespace 배열2
{
    class x보다작은수
    {
        static void Main(string[] args)
        {
            string[] f = Console.ReadLine().Split();
            int N = int.Parse(f[0]);
            int X = int.Parse(f[1]);

            string[] a = Console.ReadLine().Split();

            if (1 <= N && N <= 10000 && 1 <= X && X <= 10000)
            {
                for (int i = 0; i < N; i++)
                {
                    if (X > int.Parse(a[i]))
                    {
                        int A = int.Parse(a[i]);

                        Console.Write(A + " ");
                    }
                }
            }
        }
    }
}
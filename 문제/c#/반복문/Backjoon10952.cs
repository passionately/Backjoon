using System;

namespace 반복문11
{
    class AB5
    {
        static void Main(string[] args)
        {
            while (true) {
                string[] c = Console.ReadLine().Split();
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);

                int S = A + B;

                if (A == 0 && B == 0)
                {
                    break;
                }

                Console.WriteLine(S);
            }
        }
    }
}
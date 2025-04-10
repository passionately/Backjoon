 using System;

namespace 조건문3
{
    class 합
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int n = int.Parse(N);

            if (1 <= n && n <= 10000)
            {
                int i;
                int j = 0;

                for (i = 1; i <= n; i++) {
                    j += i;
                }
                Console.WriteLine(j);
            }
        }
    }
}
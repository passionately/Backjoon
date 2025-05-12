using System;

namespace 반복문8
{
    class AB8
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int T = int.Parse(t);

            for (int i = 1; i <= T; i++)
            {
                string[] s = Console.ReadLine().Split();
                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);
                int C = A + B;

                int x = i;

                Console.WriteLine("Case #" + x + ": " + A + " + " + B + " = " + C);
            }
        }
    }
}
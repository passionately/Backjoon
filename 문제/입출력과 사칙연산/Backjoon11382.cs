using System;

namespace 사칙연산11
{
    class 꼬마정민
    {
        static void Main(string[] args)
        {
            string[] bj = Console.ReadLine().Split();

            long A = long.Parse(bj[0]);
            long B = long.Parse(bj[1]);
            long C = long.Parse(bj[2]);

            Console.Write(A + B + C);
        }
    }
}
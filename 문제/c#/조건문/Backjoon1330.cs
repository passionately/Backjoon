using System;

namespace 조건문1
{
    class 두수비교하기
    {
        static void Main(string[] args)
        {
            string[] bj = Console.ReadLine().Split();

            int A = int.Parse(bj[0]);
            int B = int.Parse(bj[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            } else if (A < B)
            {
                Console.WriteLine("<");
            } else if (A == B)
            {
                Console.WriteLine("==");
            }
        }
    }
}
using System;
using System.Text;

namespace 반복문6
{
    class 빠른AB
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int T = int.Parse(t);
            StringBuilder sb = new StringBuilder(""); // 반복문의 값을 저장하기위해 작성

            for (int i = 1; i <= T; i++)
            {
                string[] C = Console.ReadLine().Split();
                int A = int.Parse(C[0]);
                int B = int.Parse(C[1]);
                int S = A + B;

                sb.AppendLine("" + S);
            }
            string al = sb.ToString();
            Console.WriteLine(al);
        }
    }
}
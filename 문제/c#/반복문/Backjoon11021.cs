using System;

namespace 반복문7
{
    class AB7
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int T = int.Parse(t); // 테스트 케이스 개수

            for (int i = 1; i <= T; i++)
            {
                string[] c = Console.ReadLine().Split(); // 테스트 케이스 줄에 나타나는 A, B값을 저장하는 배열
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);
                int C = A + B;

                Console.WriteLine("Case #" + i + ": " + C);
            }
        }
    }
}
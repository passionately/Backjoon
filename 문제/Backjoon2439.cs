using System;

namespace 반복문10
{
    class 별찍기2
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int N = int.Parse(n);

            for (int i = 1; i <= N; i++) // 조건: 총 몇 줄을 출력할 건지 (몇 번 반복할지)
            {
                for (int s = N; s > i; s--) // 조건: 한 줄에 공백을 몇 개 출력할 건지
                {
                    Console.Write(" ");
                }

                for (int j = i; j > 0; j--) // 조건 : 한 줄에 *을 몇 개 출력할 건지 
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
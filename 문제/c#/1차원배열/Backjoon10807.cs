using System;

namespace 배열1
{
    class 개수세기
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine(); // 첫째 줄 정수, 두 번째 나타나는 정수 개수 입력
            int N = int.Parse(n);

            if (1 <= N && N <= 100)
            {
                string[] s = Console.ReadLine().Split(); // 둘째 줄에 나타나는 정수

                string v = Console.ReadLine(); // 셋째 줄에 나타나는 정수, 둘째 줄의 정수와 비교
                int V = int.Parse(v);

                int X = 0;

                for (int i = 0; i < N; i++)
                {
                    if (V == int.Parse(s[i])) // 둘째 줄에 나타나는 정수와 셋째 줄에 나타나는 정수가 같으면 비교
                    {
                        X++;
                    }
                }
                Console.WriteLine(X);
            }
        }
    }
}
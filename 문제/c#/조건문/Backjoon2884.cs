using System;

namespace 조건문5
{
    class 알람시계
    {
        static void Main(string[] args)
        {
            string[] bj = Console.ReadLine().Split();
            int H = int.Parse(bj[0]);
            int M = int.Parse(bj[1]);

            if (0 <= H && H <= 23 && 0 <= M && M <= 59)
            {
                if (0 <= M - 45)
                {
                    M -= 45;
                    Console.WriteLine(H + " " + M);
                } else if (0 > M - 45)
                {
                    if (H == 0)
                    {
                        H = 23;
                        M -= 45;

                        // 위에서 45를 빼면 나오는 음수값 M만큼 분 단위인 60에 더해주면 원하는 분이 나옴
                        M = 60 + M;

                        Console.WriteLine(H + " " + M);
                    } else
                    {
                        H -= 1;
                        M -= 45;

                        M = 60 + M;

                        Console.WriteLine(H + " " + M);
                    }
                }
            }
        }
    }
}
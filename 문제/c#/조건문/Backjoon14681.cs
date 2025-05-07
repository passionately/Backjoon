using System;

namespace 조건문4
{
    class 사분면고르기
    {
        static void Main(string[] args)
        {
            string bj1 = Console.ReadLine();
            int x = int.Parse(bj1);

            string bj2 = Console.ReadLine();
            int y = int.Parse(bj2);
            

            if (-1000 <= x && x <= 1000 && -1000 <= y && y <= 1000)
            {
                if (x != 0 && y != 0)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("1");
                    } else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("2");
                    } else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("3");
                    } else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("4");
                    }
                }
            }
        }
    }
}
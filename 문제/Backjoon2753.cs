using System;

namespace 조건문3
{
    class 윤년
    {
        static void Main(string[] args)
        {
            string y = Console.ReadLine();
            int Y = int.Parse(y);

            if (1 <= Y && Y <= 4000)
            {
                if (Y % 4 == 0 && (Y % 100 != 0 || Y % 400 == 0))
                {
                    Console.WriteLine("1");
                } else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
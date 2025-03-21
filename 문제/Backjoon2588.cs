using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace 사칙연산10 {
    class 곱셈 {
        static void Main(string[] args) {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            // (int)Char.GetNumericValue() 를 작성하면 Char을 int 형태로 변경할 수 있음
            // B[2], B[1], B[0] 이렇게 원하는 자리의 글자를 가져올 수 있음
            int C = int.Parse(A) * (int)Char.GetNumericValue(B[2]);
            int D = int.Parse(A) * (int)Char.GetNumericValue(B[1]);
            int E = int.Parse(A) * (int)Char.GetNumericValue(B[0]);
            int F = int.Parse(A) * int.Parse(B);

            Console.WriteLine(C + "\n" + D + "\n" + E + "\n" + F);
        }
    }
}
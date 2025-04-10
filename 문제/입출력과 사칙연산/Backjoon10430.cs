using System;

namespace 사칙연산9 {
    class 나머지 {
        static void Main(string[] args) {
            // A, B, C를 공백을 포함하여 한 줄에 작성하기 위하여 Split를 써줌
            // Split란 문자열을 나눠주는 메소드로 괄호 안에 아무것도 넣지 않으면 공백을 기준으로 자름
            string[] bj = Console.ReadLine().Split();

            // 문자열에서 정수로 형식 변환 하기 위하여 Parse를 써줌
            int A = int.Parse(bj[0]);
            int B = int.Parse(bj[1]);
            int C = int.Parse(bj[2]);

            Console.WriteLine((A+B)%C);
            Console.WriteLine(((A%C) + (B%C))%C);
            Console.WriteLine((A*B)%C);
            Console.WriteLine(((A%C) * (B%C))%C);
        }
    }
}
using System;

namespace 조건문2 {
    class AB3 {
        static void Main(string[] args) {
            string t = Console.ReadLine(); // 테스트 케이스 개수
            int T = int.Parse(t);

            for (int i = 0; i < T; i++)
            {
                string[] a = Console.ReadLine().Split();
                // 테스트 케이스 줄에 주어지는 A, B
                int A = int.Parse(a[0]);
                int B = int.Parse(a[1]);
             
                Console.WriteLine(A + B);
            }
        }
    }
}
using System;

namespace BitwiseMultiplicationAndDividation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;

            int result1 = num1 << 1;

            Console.WriteLine("result1: " + result1); // result1= 2, 2^승수

            int result2 = result1 << 2; // result1 * 2 *2 8 = 1000

            Console.WriteLine("result2: " + result2);

            int result3 = result2 >> 3; // 1

            Console.WriteLine("result3: " + result3);

            //int result4 = result3 << 2.5f; 비트 이동연산제 우항으로 부동소수점 수는 사용 불가능.
            //int result5 = 2.1f << 2.5f;
        }
    }
}
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 11;

            int result1 = num1 + num2;
            int result2 = num1 - num2;

            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            uint result3 = (uint)num1 - (uint)num2; // 부호 없는 num1과 num2를 uint로 변환뒤 빼면 어떨까?

            Console.WriteLine("result3: " + result3); // 큰 양수 42949672895

            int num3 = int.MaxValue; // 32비트 정수의 최댓값으로 정의한 뒤 1을 더 함. 최대 표현가능한 수를 넘김 ※ 오버플로우
            int result4 = num3 + 1; // 오버플로우가 발생. 사용할때 데이터형의 표현가능한 범위에 신경쓰면서 코딩 추천

            Console.WriteLine("result4: " + result4); // 왜 가장 작은 수가 나오냐 가장 위의 비트수를 버리고 뒤에꺼 1로 가득 차고
            // 가장 작은 수로 가고 오버플로우

            float num4 = 2.3f;

            float result5 = num1 + num4;
            float result6 = num4 - num1;

            Console.WriteLine("result5: " + result5);
            Console.WriteLine("result6: " + result6);

            float result7 = num2 * num4;

            Console.WriteLine("result7: " + result7);

            float result8 = num2 / num1; // 둘 중 하나를 최소한 float형으로 변경해야 함.
            float result9 = num2 / (float)num1;

            Console.WriteLine("result8: " + result8);
            Console.WriteLine("result9: " + result9);

            int result10 = num1 % num2;
            int result11 = num2 % num1;

            Console.WriteLine("result10: " + result10); //10
            Console.WriteLine("result11: " + result11); //1
        }
    }
}
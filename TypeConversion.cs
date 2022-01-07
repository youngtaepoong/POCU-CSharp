using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = 'a'; // char1를 'a'로 정의

            int int1 = char1; // 묵시적 변환. char 형은 int로 자동변환 가능 16bit -> 32bitr
            Console.WriteLine("int1: " + int1); // 97

            long long1 = char1;
            Console.WriteLine("long1: " + long1);

            ulong ulong1 = char1;
            Console.WriteLine("ulong1: " + ulong1);

            float float1 = char1;
            Console.WriteLine("float1: " + float1);

            double double1 = char1;
            Console.WriteLine("double1: " + double1);

            long long2 = long.MaxValue;
            int long2ToInt = (int)long2;

            Console.WriteLine("long2: " + long2);
            Console.WriteLine("long2ToInt: " + long2ToInt); // -1
            /* long.MaxValue가 이진수로 어떻게 표현될지 생각해보자. 최상위 비트만 0이고 나머지 비트는 다 1
               int는 32비트, long은 64비트, 따라서 int로 변환(cast)하는 순간 왼쪽의 32비트는 다 0이 된다. 
               그 결과 이진수로 111111111111111이 되고, 이는 -1*/

            float float2 = 3.14159f;
            int float2ToInt = (int)float2;

            Console.WriteLine("float2: " + float2);
            Console.WriteLine("float2ToInt: " + float2ToInt); // float2int 또한 명시적 변환 필요. 왜? 소수점 이하가 날라가니까. 즉 3


            int int2 = -1;
            uint int2ToUInt = (uint)int2; // 정수끼리의 변환은 바이너리를 따른 형태로 해석.

            Console.WriteLine("int2ToUInt: " + int2ToUInt);

        }
    }
}
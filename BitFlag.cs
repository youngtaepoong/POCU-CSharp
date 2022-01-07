using System;

namespace BitFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BIT_FLAG_SIZE = 8; // 바이트 안에 몇 개의 비트가 들어갈 수 있는지 정의

            byte bitFlags = 0; //초기값들은 0으로
            /* byte는 8비트. 따라서 총 8개의 불리언(bool) 값을 저장할 수 있다.
             * 불리언 형은 오직 두가지 상태를 지원: 참(1)또는 거짓
             * 따라서 각 비트는 불리언 값 하나를 표현 가능
             */

            byte mask1 = 1 << 2; //오른쪽에서부터 세 번째 비트를 참으로 설정.
            /* 다른 비트는 여전히 0이였으면 좋곘으니.. 1을 왼쪽으로 2만큼 비트이동!
             * 이제 mask1 값은 2진수 '00000100'. 3번째 비트가 true이니 올바른 방향! 하지만 이것을 bitFlags안에 잘 꾸겨넣어야 함.*/

            bitFlags |= mask1; // bitflag와 mask1을 or연산자를 통해 // 00000000 | 00000100

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            // 00000100 성공적으로 bitFlags의 3번째 비트를 참으로 설정.
            byte mask3 = (1 << 3) | (1 << 5);

            bitFlags |= mask3; /* 오른쪽 끝에서 4번째 그리고 6번째 비트를 참으로 설정.
                                * mask3는 '00101000'이 됨. 역시 우리에게 필요한 마스크가 맞지? 
                                  00000100 | 00101000
                                */
      

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= (byte)~mask1; // 3번째 비트 끄고 싶다면! 
            /* 다른 비트는 건드리지 말고. 즉 다른 비트들이 1이라면 그 비트들은 여전히 1로, 0이라면 0으로 유지.
             * mask1의 비트들을 뒤집으면 '00000100'에서 '11111011'로 변함. 여기에 &연산자로 3번째 비트 끄기 */

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            // 3번째 비트 끄기

            bitFlags &= 0;
            /* 만약 모든 비트 끄고 싶다면?
             * 그냥 0하고 &를 하면 됨. */

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));


            char char1 = 'A';  // 65         - 01000001
            int result1 = char1 | ' '; // 32 - 00100000

            Console.WriteLine("result1: " + (char)result1); // 소문자 'a' - 01100001 = 97

            char char2 = 'a'; //97 
            int result2 = char2 & '_'; //95

            Console.WriteLine("result2: " + (char)result2);
        }
    }
}
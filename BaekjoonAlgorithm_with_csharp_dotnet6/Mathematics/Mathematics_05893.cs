using System;
using System.Numerics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05893
    {
        static string MultiplyBinaryBy17(string binaryNumber)
        {
            BigInteger bigInteger = 0;

            // 이진수를 BigInteger로 변환
            foreach (char bit in binaryNumber)
            {
                bigInteger <<= 1;
                if (bit == '1')
                    bigInteger += 1;
            }

            // 16을 곱하고 이진수에 1을 더하여 17을 곱하는 효과를 얻음
            bigInteger = (bigInteger << 4) + bigInteger;

            // BigInteger를 이진수 문자열로 변환하여 반환
            string result = "";
            while (bigInteger > 0)
            {
                result = bigInteger % 2 + result;
                bigInteger /= 2;
            }

            return result;
        }

        public void solve()
        {
            // 이진수 입력 받기
            string binaryNumber = Console.ReadLine().Trim();

            // 17을 곱한 이진수 출력
            Console.Write(MultiplyBinaryBy17(binaryNumber));
        }
    }
}

using System.Numerics;
using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01373
    {
        static string ConvertBinaryToOctal(string binary)
        {
            int length = binary.Length;
            int remainder = length % 3;

            // 입력된 이진수의 길이를 3의 배수로 만들기
            if (remainder != 0)
            {
                binary = binary.PadLeft(length + 3 - remainder, '0');
                length = binary.Length;
            }

            // 3비트씩 묶어서 8진수로 변환하기
            StringBuilder octalBuilder = new StringBuilder();
            for (int i = 0; i < length; i += 3)
            {
                int value = (binary[i] - '0') * 4 + (binary[i + 1] - '0') * 2 + (binary[i + 2] - '0');
                octalBuilder.Append(value);
            }

            // 변환된 숫자가 0으로 시작하는 경우 앞의 0 제거
            string octal = octalBuilder.ToString().TrimStart('0');

            return octal == "" ? "0" : octal; // 변환된 8진수 반환
        }

        public void solve()
        {
            string binary = Console.ReadLine(); // 2진수 입력 받기
            string octal = ConvertBinaryToOctal(binary); // 2진수를 8진수로 변환
            Console.WriteLine(octal);
        }
    }
}

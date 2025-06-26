namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01252
    {
        public void solve()
        {
            string[] input = Console.ReadLine()!.Split();
            string a = input[0];
            string b = input[1];

            // 두 문자열 길이 맞추기 (앞에 0을 붙임)
            int maxLen = Math.Max(a.Length, b.Length);
            a = a.PadLeft(maxLen, '0');
            b = b.PadLeft(maxLen, '0');

            string result = "";
            int carry = 0;

            for (int i = maxLen - 1; i >= 0; i--)
            {
                int bitA = a[i] - '0';
                int bitB = b[i] - '0';
                int sum = bitA + bitB + carry;

                result = (sum % 2) + result;
                carry = sum / 2;
            }

            if (carry > 0)
            {
                result = "1" + result;
            }

            // 0 제거 (맨 앞자리만 제거, 결과가 0이면 그대로 출력)
            result = result.TrimStart('0');
            if (result == "") result = "0";

            Console.WriteLine(result);
        }
    }
}

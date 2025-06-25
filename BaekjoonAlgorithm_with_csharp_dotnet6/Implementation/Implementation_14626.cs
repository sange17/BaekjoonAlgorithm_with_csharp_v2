namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_14626
    {
        public void solve()
        {
            string input = Console.ReadLine()!;
            int missingIndex = input.IndexOf('*');
            int[] weights = new int[12];
            int sum = 0;

            // 가중치 설정 (1, 3 반복)
            for (int i = 0; i < 12; i++)
            {
                weights[i] = (i % 2 == 0) ? 1 : 3;
            }

            // 체크기호 추출
            int checkDigit = input[12] - '0';

            // 빠진 숫자를 제외하고 sum 계산
            for (int i = 0; i < 12; i++)
            {
                if (i == missingIndex) continue;
                sum += (input[i] - '0') * weights[i];
            }

            // 빠진 숫자 X를 찾기 위한 역산
            for (int x = 0; x <= 9; x++)
            {
                int total = sum + x * weights[missingIndex];
                int m = (10 - (total % 10)) % 10;
                if (m == checkDigit)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }
    }
}

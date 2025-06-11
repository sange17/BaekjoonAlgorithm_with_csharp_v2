namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_32401
    {
        public void solve()
        {
            int N = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;
            int count = 0;

            // 모든 길이 3 이상 부분 문자열 검사
            for (int i = 0; i < N; i++)
            {
                for (int len = 3; i + len <= N; len++)
                {
                    string sub = S.Substring(i, len);
                    if (IsSimilarANA(sub))
                        count++;
                }
            }

            Console.WriteLine(count);
        }

        // 유사 ANA 문자열인지 확인하는 함수
        static bool IsSimilarANA(string s)
        {
            if (s[0] != 'A' || s[^1] != 'A') return false;

            int aCount = 0;
            int nCount = 0;
            foreach (char c in s)
            {
                if (c == 'A') aCount++;
                if (c == 'N') nCount++;
            }

            return aCount == 2 && nCount == 1;
            
        }
    }
}
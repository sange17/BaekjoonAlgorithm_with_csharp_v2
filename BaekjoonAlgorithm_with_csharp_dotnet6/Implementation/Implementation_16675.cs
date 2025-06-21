namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16675
    {
        public void solve()
        {
            string[] input = Console.ReadLine()!.Split();
            string ML = input[0];
            string MR = input[1];
            string TL = input[2];
            string TR = input[3];

            string[] minseong = { ML, MR };
            string[] taekyung = { TL, TR };

            Dictionary<string, string> winMap = new Dictionary<string, string>
            {
                { "S", "P" }, // 가위 > 보
                { "P", "R" }, // 보 > 바위
                { "R", "S" }  // 바위 > 가위
            };

            bool MSWins = false;
            bool TKWins = false;

            // 민성이가 무조건 이길 수 있는 경우
            foreach (string mHand in minseong)
            {
                if (Beats(mHand, TL, winMap) && Beats(mHand, TR, winMap))
                {
                    MSWins = true;
                    break;
                }
            }

            // 태경이가 무조건 이길 수 있는 경우
            foreach (string tHand in taekyung)
            {
                if (Beats(tHand, ML, winMap) && Beats(tHand, MR, winMap))
                {
                    TKWins = true;
                    break;
                }
            }

            if (MSWins)
                Console.WriteLine("MS");
            else if (TKWins)
                Console.WriteLine("TK");
            else
                Console.WriteLine("?");
        }

        // 가위바위보 이기는지 체크
        static bool Beats(string a, string b, Dictionary<string, string> winMap)
        {
            return winMap[a] == b;
        }
    }
}

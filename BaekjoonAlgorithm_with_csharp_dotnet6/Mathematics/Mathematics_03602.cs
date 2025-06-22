namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03602
    {
        public void solve()
        {
            string[] input = Console.ReadLine()!.Split();
            int b = int.Parse(input[0]);
            int w = int.Parse(input[1]);

            int left = 1;
            int right = (int)Math.Sqrt(b + w);
            int maxSide = 0;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int totalTiles = mid * mid;

                // 필요한 타일 수 계산
                int blackNeeded = totalTiles / 2;
                int whiteNeeded = totalTiles / 2;
                if (totalTiles % 2 == 1)
                    blackNeeded += 1; // 홀수면 흑이 하나 더 필요 (대칭이므로 흑/백 바꿔도 됨)

                // 타일 수가 충분한지 확인
                if ((b >= blackNeeded && w >= whiteNeeded) || (w >= blackNeeded && b >= whiteNeeded))
                {
                    maxSide = mid;
                    left = mid + 1; // 더 큰 정사각형 시도
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (maxSide == 0)
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                Console.WriteLine(maxSide);
            }
        }
    }
}

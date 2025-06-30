namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01551
    {
        public void solve()
        {
            // 입력 받기
            string[] nk = Console.ReadLine()!.Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            List<int> sequence = Console.ReadLine()!.Split(',').Select(int.Parse).ToList();

            // K번 반복해서 차분 수열 계산
            for (int step = 0; step < k; step++)
            {
                List<int> newSequence = new List<int>();
                for (int i = 0; i < sequence.Count - 1; i++)
                {
                    newSequence.Add(sequence[i + 1] - sequence[i]);
                }
                sequence = newSequence;
            }

            // 결과 출력
            Console.WriteLine(string.Join(",", sequence));
        }
    }
}

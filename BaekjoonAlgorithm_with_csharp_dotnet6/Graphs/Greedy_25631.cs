using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Greedy_25631
    {
        public void solve()
        {
            int N = int.Parse(Console.ReadLine());
            int[] martroshkas = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(martroshkas);
            int remaining = 0; // 남은 마트로시카의 개수
            int prevSize = martroshkas[0]; // 첫 번째 마트로시카의 크기로 초기화

            for (int i = 1; i < N; i++)
            {
                if (martroshkas[i] > prevSize)
                {
                    prevSize = martroshkas[i];
                }
                else
                {
                    remaining++;
                }
            }

            Console.WriteLine(N - remaining);
        }
    }
}

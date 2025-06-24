namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01461
    {
        public void solve()
        {
            var input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            var positions = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            var negatives = positions.Where(x => x < 0).Select(x => -x).OrderByDescending(x => x).ToList();
            var positives = positions.Where(x => x > 0).OrderByDescending(x => x).ToList();

            int distance = 0;

            distance += CalculateDistance(negatives, M);
            distance += CalculateDistance(positives, M);

            // 가장 먼 책 위치 (절댓값 최대)
            int maxDistance = 0;
            if (negatives.Count > 0)
                maxDistance = Math.Max(maxDistance, negatives[0]);
            if (positives.Count > 0)
                maxDistance = Math.Max(maxDistance, positives[0]);

            // 가장 먼 거리만 편도 처리했으므로 왕복 거리에서 한 번 빼줌
            distance -= maxDistance;

            Console.WriteLine(distance);
        }

        static int CalculateDistance(List<int> books, int M)
        {
            int dist = 0;
            for (int i = 0; i < books.Count; i += M)
            {
                dist += books[i] * 2;
            }
            return dist;
        }
    }
}

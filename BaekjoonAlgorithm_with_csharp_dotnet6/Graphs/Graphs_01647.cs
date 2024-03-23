namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Graphs_01647
    {
        static int[] parent;

        public void solve()
        {
            // 입력 받기
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            parent = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                parent[i] = i;
            }

            SortedSet<(int, int, int)> edges = new SortedSet<(int, int, int)>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split();
                int start = int.Parse(input[0]);
                int end = int.Parse(input[1]);
                int cost = int.Parse(input[2]);
                edges.Add((cost, start, end));
            }

            int result = Kruskal(edges);

            // 결과 출력
            Console.WriteLine(result);
        }

        static int Find(int x)
        {
            if (x == parent[x])
                return x;
            return parent[x] = Find(parent[x]);
        }

        static void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
                parent[rootY] = rootX;
        }

        static int Kruskal(SortedSet<(int, int, int)> edges)
        {
            int totalCost = 0;
            int maxCost = 0; // 최대 비용을 저장할 변수 추가
            foreach ((int cost, int start, int end) in edges)
            {
                if (Find(start) != Find(end))
                {
                    Union(start, end);
                    totalCost += cost;
                    if (cost > maxCost)
                        maxCost = cost;
                }
            }
            return totalCost - maxCost; // 최대 비용을 빼고 반환
        }
    }
}

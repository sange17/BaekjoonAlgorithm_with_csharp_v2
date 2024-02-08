using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 그래프 이론
// 최소 스패닝 트리
namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Edge : IComparable<Edge>
    {
        public int Source;
        public int Destination;
        public int Weight;

        public int CompareTo(Edge other)
        {
            return this.Weight.CompareTo(other.Weight);
        }
    }

    class UnionFind
    {
        private int[] parent;
        private int[] rank;

        public UnionFind(int n)
        {
            parent = new int[n];
            rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public int Find(int u)
        {
            if (parent[u] != u)
                parent[u] = Find(parent[u]); // 경로 압축
            return parent[u];
        }

        public void Union(int u, int v)
        {
            int uRoot = Find(u);
            int vRoot = Find(v);

            if (uRoot == vRoot) return;

            if (rank[uRoot] < rank[vRoot])
                parent[uRoot] = vRoot;
            else if (rank[uRoot] > rank[vRoot])
                parent[vRoot] = uRoot;
            else
            {
                parent[vRoot] = uRoot;
                rank[uRoot]++;
            }
        }
    }

    class Graphs_01197
    {
        static int Kruskal(List<Edge> edges, int V)
        {
            edges.Sort(); // 간선을 가중치 순으로 정렬
            int totalWeight = 0;
            UnionFind uf = new UnionFind(V);

            foreach (Edge edge in edges)
            {
                if (uf.Find(edge.Source) != uf.Find(edge.Destination))
                {
                    uf.Union(edge.Source, edge.Destination);
                    totalWeight += edge.Weight;
                }
            }

            return totalWeight;
        }

        public void solve()
        {
            string[] VE = Console.ReadLine().Split();
            int V = int.Parse(VE[0]);
            int E = int.Parse(VE[1]);

            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < E; i++)
            {
                string[] edgeInfo = Console.ReadLine().Split();
                int A = int.Parse(edgeInfo[0]);
                int B = int.Parse(edgeInfo[1]);
                int C = int.Parse(edgeInfo[2]);
                edges.Add(new Edge { Source = A - 1, Destination = B - 1, Weight = C });
            }

            Console.WriteLine(Kruskal(edges, V));
        }
    }
}

using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27172
    {
        public void solve()
        {
            StringBuilder sb = new StringBuilder();

            int N = Int32.Parse(Console.ReadLine());
            int[] X = new int[N];
            int INF = 0;
            string[] strings = Console.ReadLine().Split(" ");
            for(int i = 0; i < N; i++)
            {
                INF = Math.Max(INF, X[i] = Int32.Parse((string)strings[i]));
            }

            int[] P = new int[N + 1];
            int[] pos = new int[INF + 1];
            for(int i = 0; i < N; i++)
            {
                pos[X[i]] = i + 1;
            }

            for(int i = 0; i < N; i++)
            {
                for(int j = X[i] * 2; j <= INF; j += X[i])
                {
                    if (pos[j] != 0)
                    {
                        P[pos[j]]--;
                        P[pos[X[i]]]++;
                    }
                }
            }

            for(int i = 1; i <= N; i++)
            {
                sb.Append(P[i]).Append(' ');
            }
            Console.Write(sb.ToString());
        }
    }
}

using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Geometry
{

    class Geometry_10216
    {
        static int[] parent;
        static int[,] unit;

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine());

            int N = 0;
            string line = string.Empty;
            int x = 0;
            int y = 0;
            int r = 0;
            int ans = 0;
            int x_dif = 0;
            int y_dif = 0;
            while (T-- > 0)
            {
                N = Int32.Parse(sr.ReadLine());

                parent = new int[N];
                unit = new int[N, 3];

                for(int i = 0; i < N; i++)
                {
                    line = sr.ReadLine();

                    x = Int32.Parse(line.Split(' ')[0]);
                    y = Int32.Parse(line.Split(' ')[1]);
                    r = Int32.Parse(line.Split(' ')[2]);

                    unit[i, 0] = x;
                    unit[i, 1] = y;
                    unit[i, 2] = r;

                    parent[i] = i;
                }

                ans = N;
                for (int i = 0; i < N; i++)
                {
                    for(int j = i + 1; j < N; j++)
                    {
                        x_dif = unit[i,0] - unit[j,0];
                        y_dif = unit[i,1] - unit[j,1];
                        r = unit[i,2] + unit[j,2];

                        if(x_dif * x_dif + y_dif * y_dif <= r * r)
                        {
                            if(find(i) != find(j))
                            {
                                union(i,j);
                                ans--;
                            }
                        }
                    }
                }

                sw.WriteLine(ans);
            }

            sr.Close();
            sw.Close();
        }

        static int find(int x)
        {
            if(x == parent[x])
            {
                return x;
            }

            return parent[x] = find(parent[x]);
        }

        static void union(int x, int y)
        {
            x = find(x);
            y = find(y);

            if(x != y)
            {
                if(x < y)
                {
                    parent[y] = x;
                }
                else
                {
                    parent[x] = y;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_17144
    {
        static int R, C, T;
        static int[,] map;
        static int[] up = new int[] { 1, -1, 0, 0 };
        static int[] side = new int[] { 0, 0, 1, -1 };
        static int airPos1 = 0;
        static int airPos2 = 0;

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] s = sr.ReadLine().Split(' ');

            R = Int32.Parse(s[0]);
            C = Int32.Parse(s[1]);
            T = Int32.Parse(s[2]);

            map = new int[R, C];
            int num = 0;
            for(int i = 0; i < R; i++)
            {
                string[] s1 = sr.ReadLine().Split(' ');
                for(int j = 0; j < C; j++)
                {
                    map[i, j] = Int32.Parse(s1[j]);
                }
            }

            findAir();
            for(int i = 0; i < T; i++)
            {
                solveFunc();
            }

            int result = count();

            Console.WriteLine(result + 2);

        }

        public void findAir()
        {
            for(int i = 0; i < R; i++)
            {
                if(map[i,0] == -1)
                {
                    airPos1 = i;
                    airPos2 = i + 1;
                    break;
                }
            }
        }

        public void solveFunc()
        {
            map = dustSimulation();
            airSimulation();
        }

        public void airSimulation()
        {
            int top = airPos1;

            for(int x = top - 1; x > 0; x--)
            {
                map[x, 0] = map[x - 1, 0];
            }

            for(int y = 0; y < C - 1; y++)
            {
                map[0, y] = map[0, y + 1];
            }

            for(int x = 0; x < top; x++)
            {
                map[x, C - 1] = map[x + 1, C - 1];
            }

            for(int y = C - 1; y > 1; y--)
            {
                map[top, y] = map[top, y - 1];
            }

            map[top, 1] = 0;

            int bottom = airPos2;

            for(int x = bottom + 1; x < R - 1; x++)
            {
                map[x, 0] = map[x + 1, 0];
            }

            for(int y = 0; y < C - 1; y++)
            {
                map[R - 1, y] = map[R - 1, y + 1];
            }

            for(int x = R - 1; x > bottom; x--)
            {
                map[x, C - 1] = map[x - 1, C - 1];
            }

            for(int y = C - 1; y > 1; y--)
            {
                map[bottom, y] = map[bottom, y - 1];
            }

            map[bottom, 1] = 0;
        }

        public int[,] dustSimulation()
        {
            int[,] tMap = new int[50, 50];
            for(int i = 0; i < R; i++)
            {
                for(int j = 0; j < C; j++)
                {
                    if (map[i, j] == -1)
                    {
                        tMap[i, j] = -1;
                        continue;
                    }

                    tMap[i, j] += map[i, j];
                    for(int k = 0; k < 4; k++)
                    {
                        int nx = j + side[k];
                        int ny = i + up[k];

                        if (ny < 0 || ny >= R || nx < 0 || nx >= C) continue;
                        if (map[ny, nx] == -1) continue;

                        tMap[ny, nx] += (map[i, j] / 5);
                        tMap[i, j] -= (map[i, j] / 5);
                    }
                }
            }
            return tMap;
        }

        public int count()
        {
            int temp = 0;
            for(int i = 0; i < R; i++)
            {
                for(int j = 0; j < C; j++)
                {
                    temp += map[i, j];
                }
            }

            return temp;
        }
    }
}

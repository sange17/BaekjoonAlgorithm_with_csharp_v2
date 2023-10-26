using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Graphs
{
    class Graphs_01987
    {
        static int r = 0;
        static int c = 0;
        static int[,] board;
        static int[] dx = { -1, 0, 1, 0 };
        static int[] dy = { 0, 1, 0, -1 };
        static int max = 0;
        static bool[] alpha;

        static void backtracking(int x, int y, int len)
        {
            alpha[board[x, y]] = true;
            max = Math.Max(max, len);

            for(int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                if (nx >= 0 && ny >= 0 && nx < r && ny < c)
                {
                    if (alpha[board[nx, ny]] == false)
                    {
                        backtracking(nx, ny, len + 1);
                        alpha[board[nx, ny]] = false;
                    }
                }
            }
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            r = Int32.Parse(line.Split(' ')[0]);
            c = Int32.Parse(line.Split(' ')[1]);

            board = new int[r, c];
            for(int i = 0; i < r; i++)
            {
                line = sr.ReadLine();
                for(int j = 0; j < c; j++)
                {
                    board[i, j] = line[j] - 'A';
                }
            }

            alpha = new bool[26];
            backtracking(0, 0, 1);
            Console.WriteLine(max);
        }
    }
}

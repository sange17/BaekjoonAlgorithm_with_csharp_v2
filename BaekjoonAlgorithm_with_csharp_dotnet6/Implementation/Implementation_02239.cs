using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02239
    {
        static bool[,] rows = new bool[9, 10];
        static bool[,] cols = new bool[9, 10];
        static bool[,] board3by3 = new bool[9, 10];
        static int[,] board9by9 = new int[9, 9];
        static StringBuilder sb = new StringBuilder(); 

        static void sudoku(int idx)
        {
            string line = string.Empty;
            if(idx >= 81)
            {
                sb = new StringBuilder();
                for(int i = 0; i < 9; i++)
                {
                    for(int j = 0; j < 9; j++)
                    {
                        sb.Append(board9by9[i,j]);
                    }
                    
                    if(i < 8)
                    {
                        sb.Append("\n");
                    }
                }

                Console.Write(sb.ToString());
                Environment.Exit(0);
            }

            int r = idx / 9;
            int c = idx % 9;

            if (board9by9[r, c] != 0) sudoku(idx + 1);
            else
            {
                 for(int i = 1; i < 10; i++)
                {
                    if (rows[r, i] || cols[c, i] || board3by3[3 * (r / 3) + c / 3, i]) continue;
                    rows[r, i] = true;
                    cols[c, i] = true;
                    board3by3[3*(r/3) + c / 3, i] = true;
                    board9by9[r, c] = i;
                    sudoku(idx + 1);
                    rows[r, i] = false;
                    cols[c, i] = false;
                    board3by3[3 * (r / 3) + c / 3, i] = false;
                    board9by9[r, c] = 0;
                }
            }
        }

        public void solve()
        {
            string line = string.Empty;
            for(int i = 0; i < 9; i++)
            {
                line = Console.ReadLine();
                for(int j = 0; j < 9; j++)
                {
                    board9by9[i, j] = line[j] - '0';
                    rows[i, board9by9[i, j]] = true;
                    cols[j, board9by9[i, j]] = true;
                    board3by3[3 * (i / 3) + (j / 3), board9by9[i, j]] = true;
                }
            }
            sudoku(0);
        }
    }
}

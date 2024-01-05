using System;
using System.Data;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_03190
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int K = Int32.Parse(Console.ReadLine());
            int[,] map = new int[N + 1, N + 1];

            // 사과가 있는 위치는 1로 초기화
            string line = string.Empty;
            for(int i = 0; i < K; i++)
            {
                line = Console.ReadLine();

                int appleRow = Int32.Parse(line.Split(' ')[0]);
                int appleCol = Int32.Parse(line.Split(' ')[1]);

                map[appleRow, appleCol] = 1;
            }

            int L = Int32.Parse(Console.ReadLine());

            // 시간에 따라서 회전시킬 방향 queue 생성
            Queue<Spin> spin = new Queue<Spin>();
            for(int i = 0; i < L; i++)
            {
                line = Console.ReadLine();
                int timeSetting = Int32.Parse(line.Split(' ')[0]);
                String dirSetting = line.Split(' ')[1];

                spin.Enqueue(new Spin(timeSetting, dirSetting));
            }

            int[] dr = { -1, 0, 1, 0 };
            int[] dc = { 0, 1, 0, -1 };

            int row = 1;
            int col = 1;
            int time = 0;
            int dir = 1;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(row, col));
            map[row, col] = 2;

            while(true)
            {
                int dR = row + dr[dir];
                int dC = col + dc[dir];

                time++;

                if (dR < 1 || dC < 1 || dR > N || dC > N)
                    break;
                if (map[dR, dC] == 2)
                    break;

                if (map[dR, dC] == 0)
                {
                    Node node = queue.Dequeue();
                    map[node.row, node.col] = 0;
                }
                if(spin.Count() > 0)
                {
                    if(time == spin.Peek().time)
                    {
                        Spin s = spin.Dequeue();

                        if (s.dir.Equals("L"))
                            dir = dir - 1 < 0 ? 3 : dir - 1;
                        if (s.dir.Equals("D"))
                            dir = dir + 1 > 3 ? 0 : dir + 1;
                    }
                }

                map[dR, dC] = 2;
                queue.Enqueue(new Node(dR, dC));
                row = dR;
                col = dC;
            }

            Console.Write(time);
        }

        class Spin
        {
            public int time;
            public string dir;

            public Spin(int time, string dir)
            {
                this.time = time;
                this.dir = dir;
            }
        }

        class Node
        {
            public int row, col;
            public Node(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }
    }
}


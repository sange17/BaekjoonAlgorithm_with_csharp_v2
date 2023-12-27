using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_13335
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int W = Int32.Parse(line.Split(" ")[1]);
            int L = Int32.Parse(line.Split(" ")[2]);

            Queue<int> q1 = new Queue<int>();
            line = Console.ReadLine();
            for(int i = 0; i < N; i++)
            {
                q1.Enqueue(Int32.Parse(line.Split(" ")[i]));
            }

            int time = 0;
            int bw = 0;
            Queue<int> q2 = new Queue<int>();
            for(int i = 0; i < W; i++)
            {
                q2.Enqueue(0);
            }

            while(q2.Count > 0)
            {
                time++;
                bw -= q2.Dequeue();
                if(q1.Count > 0)
                {
                    if(q1.Peek() + bw <= L)
                    {
                        bw += q1.Peek();
                        q2.Enqueue(q1.Dequeue());
                    }
                    else
                    {
                        q2.Enqueue(0);
                    }
                }
            }

            Console.Write(time);
        }
    }
}

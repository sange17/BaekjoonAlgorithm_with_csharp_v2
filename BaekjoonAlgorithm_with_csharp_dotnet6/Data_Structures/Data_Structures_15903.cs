using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_15903
    {
        public void solve()
        {
            string[] array = Console.ReadLine().Split(" ");
            int n = Int32.Parse(array[0]);
            int m = Int32.Parse(array[1]);

            PriorityQueue<long, long> pq = new PriorityQueue<long, long>();

            string[] tryArray = Console.ReadLine().Split(" ");
            
            for(int i = 0; i < n; i++)
            {
                pq.Enqueue(long.Parse(tryArray[i]), long.Parse(tryArray[i]));
            }

            for(int i = 0; i < m; i++)
            {
                long a = pq.Dequeue();
                long b = pq.Dequeue();
                pq.Enqueue(a + b, a + b);
                pq.Enqueue(a + b, a + b);
            }

            long ans = 0;

            while(pq.Count > 0) 
            {
                ans += pq.Dequeue();
            }

            Console.Write(ans);
        }
    }
}

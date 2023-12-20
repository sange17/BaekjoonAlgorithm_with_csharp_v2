using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_11000
    {
        public class Lecture
        {
            public int start;
            public int end;

            public Lecture(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());
            Lecture[] lectures = new Lecture[N];

            string line = string.Empty;
            int start = 0;
            int end = 0;
            for(int i = 0; i < N; i++)
            {
                line = sr.ReadLine();

                start = Int32.Parse(line.Split(' ')[0]);
                end = Int32.Parse(line.Split(' ')[1]);

                lectures[i] = new Lecture(start, end);
            }

            lectures = lectures.OrderBy(x => x.start).ThenBy(x => x.end).ToArray();

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            pq.Enqueue(lectures[0].end, lectures[0].end);

            for(int i = 1; i < N; i++)
            {
                if (pq.Peek() <= lectures[i].start)
                {
                    pq.Dequeue();
                }
                pq.Enqueue(lectures[i].end, lectures[i].end);
            }

            sw.Write(pq.Count);
            sr.Close();
            sw.Close();
        }
    }
}

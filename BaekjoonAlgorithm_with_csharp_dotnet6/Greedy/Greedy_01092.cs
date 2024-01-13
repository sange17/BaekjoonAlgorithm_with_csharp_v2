using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01092
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            List<int> crane = new List<int>();

            string[] lineN = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                crane.Add(Int32.Parse(lineN[i]));
            }

            int M = Int32.Parse(Console.ReadLine());
            List<int> box = new List<int>();

            string[] lineM = Console.ReadLine().Split(' ');
            for(int i = 0; i < M; i++)
            {
                box.Add(Int32.Parse(lineM[i]));
            }

            crane.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));
            box.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));

            if (crane[0] < box[0])
            {
                Console.Write(-1);
                return;
            }

            int day = 0;
            while(box.Count > 0)
            {
                int boxIdx = 0;
                int craneIdx = 0;

                while (craneIdx < N)
                {
                    if (boxIdx == box.Count)
                        break;
                    else if (crane[craneIdx] >= box[boxIdx])
                    {
                        box.RemoveAt(boxIdx);
                        craneIdx++;
                    }
                    else
                        boxIdx++;
                }
                day++;
            }

            Console.Write(day);
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01052
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int K = Int32.Parse(line.Split(" ")[1]);
            int count = 0;

            if (N <= K)
            {
                Console.Write(0);
                return;
            }

            int buy = 0;
            while (true)
            {
                count = 0;
                int copyN = N;
                while (copyN != 0)
                {
                    if (copyN % 2 == 1)
                    {
                        count += 1;
                    }
                    copyN /= 2;
                }
                if (count <= K)
                    break;
                N += 1;
                buy += 1;
            }

            Console.Write(buy);
        }
    }
}

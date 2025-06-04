namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09517
    {
        public void solve()
        {
            int K = Int32.Parse(Console.ReadLine()!);
            int N = Int32.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine()!;
                int T = Int32.Parse(line.Split(" ")[0]);
                string Z = line.Split(" ")[1];

                sum += T;
                if (sum >= 210)
                {
                    Console.Write(K);
                    break;
                }

                if (Z == "T") K++;
                if (K > 8) K = 1;
            }
        }
    }
}

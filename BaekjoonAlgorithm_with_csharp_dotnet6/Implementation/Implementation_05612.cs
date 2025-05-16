namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05612
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int m = Int32.Parse(Console.ReadLine()!);
            string line = string.Empty;
            int IN = 0;
            int OUT = 0;
            int sum = m;
            int max = m;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!;
                IN = Int32.Parse(line.Split(" ")[0]);
                OUT = Int32.Parse(line.Split(" ")[1]);

                sum += (IN - OUT);

                if(sum < 0)
                {
                    max = 0;
                    break;
                }

                if(max < sum)
                {
                    max = sum;
                }
            }

            Console.Write(max);
        }
    }
}

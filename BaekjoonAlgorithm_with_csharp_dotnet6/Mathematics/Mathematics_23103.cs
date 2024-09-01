namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_23103
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            string line = Console.ReadLine()!;
            int xi1 = Int32.Parse(line.Split(" ")[0]);
            int yi1 = Int32.Parse(line.Split(" ")[1]);

            int sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                line = Console.ReadLine()!;

                int xi2 = Int32.Parse(line.Split(" ")[0]);
                int yi2 = Int32.Parse(line.Split(" ")[1]);

                sum += (Math.Abs(xi1 - xi2) + Math.Abs(yi1 - yi2));

                xi1 = xi2;
                yi1 = yi2;
            }

            Console.Write(sum);
        }
    }
}

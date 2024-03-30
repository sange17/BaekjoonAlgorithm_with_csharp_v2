namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27890
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int x0 = Int32.Parse(line.Split(" ")[0]);
            int N = Int32.Parse(line.Split(" ")[1]);

            for(int i = 0; i < N; i++)
            {
                if (x0 % 2 == 0)
                    x0 = ((x0 / 2) ^ 6);
                else
                    x0 = ((2 * x0) ^ 6);
            }

            Console.Write(x0);
        }
    }
}

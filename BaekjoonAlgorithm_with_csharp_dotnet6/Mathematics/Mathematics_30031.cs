namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30031
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string line = string.Empty;

            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                int w = Int32.Parse(line.Split(" ")[0]);
                int h = Int32.Parse(line.Split(" ")[1]);

                if (w == 136)
                    sum += 1000;
                else if (w == 142)
                    sum += 5000;
                else if (w == 148)
                    sum += 10000;
                else if (w == 154)
                    sum += 50000;
            }

            Console.Write(sum);
        }
    }
}

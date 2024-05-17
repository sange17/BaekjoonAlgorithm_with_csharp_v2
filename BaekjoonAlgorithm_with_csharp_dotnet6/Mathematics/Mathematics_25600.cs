namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25600
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int a = Int32.Parse(line.Split(" ")[0]);
                int d = Int32.Parse(line.Split(" ")[1]);
                int g = Int32.Parse(line.Split(" ")[2]);

                if(a == d + g)
                {
                    if(max < a * (d + g) * 2)
                    {
                        max = a * (d + g) * 2;
                    }
                }
                else
                {
                    if(max < a * (d + g))
                    {
                        max = a * (d + g);
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}

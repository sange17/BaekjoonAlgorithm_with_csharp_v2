namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24609
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            int min = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int t = Int32.Parse(Console.ReadLine()!);

                sum += t;

                if (sum < 0)
                {
                    min += Math.Abs(sum);
                    sum = 0;
                }
            }

            Console.Write(min);
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_07770
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int height = 1;
            int minBlock = 0;
            int maxBlock = 0;

            while (true)
            {
                minBlock += height * height + (height - 1) * (height - 1);
                height++;
                maxBlock = minBlock + height * height + (height - 1) * (height - 1) - 1;
                if (minBlock <= n && maxBlock >= n)
                {
                    Console.Write(height - 1);
                    break;
                }
            }
        }
    }
}

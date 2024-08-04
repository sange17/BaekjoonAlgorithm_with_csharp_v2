namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_08658
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);

            int min = 0;
            int max = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i != 0)
                {
                    min = i;
                    break;
                }
            }

            for(int j = N; j > 0; j--)
            {
                if(N % j != 0)
                {
                    max = j;
                    break;
                }
            }

            Console.Write(min + " " + max);
        }
    }
}

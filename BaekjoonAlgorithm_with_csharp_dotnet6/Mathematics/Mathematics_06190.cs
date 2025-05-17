namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06190
    {
        public void solve()
        {
            long N = int.Parse(Console.ReadLine()!);
            int score = 0;

            while (true)
            {
                if(N == 1) 
                {
                    Console.Write(score);
                    break;
                }

                if (N % 2 == 0)
                    N /= 2;
                else
                    N = (N * 3 + 1);

                score++;
            }
        }
    }
}

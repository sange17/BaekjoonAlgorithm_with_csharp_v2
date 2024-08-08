namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06779
    {
        public void solve()
        {
            int h = Int32.Parse(Console.ReadLine()!);
            int M = Int32.Parse(Console.ReadLine()!);

            int c = 0;
            bool check = false;
            int result = 0;
            for (int t = 1; t <= M; t++)
            {
                c = (-6 * t * t * t) + (h * t * t) + (2 * t) + 1;

                if (c <= 0)
                {
                    check = true;
                    result = t;
                    break;
                }
            }

            if (check)
                Console.Write("The balloon first touches ground at hour: " + result);
            else
                Console.Write("The balloon does not touch ground in the given time.");
        }
    }
}

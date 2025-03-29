namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_19771
    {
        public void solve()
        {
            int N = int.Parse(Console.ReadLine()!);
            int count = 0;
            int seat = 0;
            while (true)
            {
                if((seat / 2) > (N - 2 - count))
                {
                    Console.Write(seat -= 2);
                    break;
                }

                count++;
                seat += 2;
            }
        }
    }
}

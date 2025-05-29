namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_13670
    {
        public void solve()
        {
            int h1 = 0;
            int m1 = 0;
            int h2 = 0;
            int m2 = 0;
            int htom1 = 0;
            int htom2 = 0;

            while (true)
            {
                int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                h1 = array[0];
                m1 = array[1];
                h2 = array[2];
                m2 = array[3];

                if (h1 == 0 && m1 == 0 && h2 == 0 && m2 == 0) break;

                htom1 = h1 * 60 + m1;
                htom2 = h2 * 60 + m2;

                if (htom1 > htom2)
                {
                    Console.WriteLine(1440 - htom1 + htom2);
                }
                else
                {
                    Console.WriteLine(htom2 - htom1);
                }
            }
        }
    }
}

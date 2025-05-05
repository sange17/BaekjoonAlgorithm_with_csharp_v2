namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_32710
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            bool[] array = new bool[101];
            for (int i = 2; i <= 9; i++)
            {
                array[i] = true;
                for (int j = 1; j <= 9; j++)
                {
                    array[j] = true;
                    array[i * j] = true;
                }
            }

            if (array[N])
                Console.Write(1);
            else
                Console.Write(0);
        }
    }
}

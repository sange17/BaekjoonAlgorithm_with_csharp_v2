namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03533
    {
        public void solve()
        {
            bool[] bools = new bool[10];
            string[] chars = Console.ReadLine().Split(' ');
            for(int i = 0; i < 10; i++)
            {
                bools[i] = (Int32.Parse(chars[i]) == 1);
            }

            bool result = false;
            for(int i = 0; i < 10; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    result ^= (bools[i] || bools[j]);
                    for(int k = j + 1; k < 10; k++)
                    {
                        result ^= (bools[i] || bools[j] || bools[k]);
                    }
                }
            }

            Console.Write(result ? 1 : 0);
        }
    }
}

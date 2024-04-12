namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05343
    {
        public void solve()
        {
            int N = Int32.Parse (Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string bits = Console.ReadLine();

                int cntErr = 0;
                for(int j = 0; j < bits.Length; j+=8)
                {
                    int cntOnes = 0;
                    for (int k = 0; k < 7; k++)
                    {
                        if (bits[j + k] == '1')
                            cntOnes++;
                    }
                    if ((cntOnes % 2) != (bits[j + 7] - '0'))
                        cntErr++;
                }
                Console.WriteLine(cntErr);
            }
        }
    }
}

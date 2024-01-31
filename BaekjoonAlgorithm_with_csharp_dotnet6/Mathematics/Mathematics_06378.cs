using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06378
    {
        public void solve()
        {
            while(true)
            {
                string S = Console.ReadLine();

                if (S.Equals("0")) break;

                while(true)
                {
                    int sum = 0;

                    if (S.Length < 2) break;
                    else
                    {
                        for (int i = 0; i < S.Length; i++)
                        {
                            sum += S[i] - '0';
                        }
                    }

                    S = sum.ToString();
                }
                Console.WriteLine(S);
            }
        }
    }
}

using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_02745
    {
        public void solve()
        {
            string line = Console.ReadLine();
            string N = line.Split(" ")[0];
            int B = Int32.Parse(line.Split(" ")[1]);

            int tmp = 1;
            int sum = 0;

            for(int i = N.Length - 1; i >= 0; i--)
            {
                if('A' <= N[i] && N[i] <= 'Z')
                {
                    sum += (N[i] - 'A' + 10) * tmp;
                }
                else
                {
                    sum += (N[i] - '0') * tmp;
                }

                tmp *= B;
            }

            Console.WriteLine(sum);
        }
    }
}

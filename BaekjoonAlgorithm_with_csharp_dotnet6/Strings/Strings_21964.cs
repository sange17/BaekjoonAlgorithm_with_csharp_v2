using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_21964
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            Console.Write(line.Substring(N - 5, 5));
        }
    }
}

using System;
using System.Numerics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16428
    {
        public void solve()
        {
            string[]? input = Console.ReadLine().Split(' ');
            BigInteger.TryParse(input[0], out BigInteger a);
            BigInteger.TryParse(input[1], out BigInteger b);

            BigInteger mod = a % b;
            if (mod < 0)
                mod += BigInteger.Abs(b);

            Console.WriteLine((a - mod) / b);
            Console.Write(mod);
        }
    }
}

using System;
using System.Numerics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01837
    {
        public void solve()
        {
            string line = Console.ReadLine();
            BigInteger P = BigInteger.Parse(line.Split(' ')[0]);
            BigInteger K = BigInteger.Parse(line.Split(" ")[1]);
            BigInteger i = new BigInteger(1);

            while(true)
            {
                if(i.CompareTo(K) == 1 || i.CompareTo(K) == 0)
                {
                    Console.Write("GOOD");
                    break;
                }

                i += BigInteger.One;

                if((P % i).CompareTo(BigInteger.Zero) == 0 && i.CompareTo(K) == -1)
                {
                    Console.Write("BAD " + i);
                    break;
                }
            }
        }
    }
}

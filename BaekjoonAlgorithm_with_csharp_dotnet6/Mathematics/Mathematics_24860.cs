using System.Numerics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24860
    {
        public void solve()
        {
            string line = Console.ReadLine();
            BigInteger vk = BigInteger.Parse(line.Split(" ")[0]);
            BigInteger jk = BigInteger.Parse(line.Split(" ")[1]);
            line = Console.ReadLine();
            BigInteger vr = BigInteger.Parse(line.Split(" ")[0]);
            BigInteger jr = BigInteger.Parse(line.Split(" ")[1]);
            line = Console.ReadLine();
            BigInteger vh = BigInteger.Parse(line.Split(" ")[0]);
            BigInteger dh = BigInteger.Parse(line.Split(" ")[1]);
            BigInteger jh = BigInteger.Parse(line.Split(" ")[2]);
            BigInteger c1 = BigInteger.Multiply(vh, BigInteger.Multiply(dh, BigInteger.Multiply(jh, BigInteger.Multiply(vk, jk))));
            BigInteger c2 = BigInteger.Multiply(vh, BigInteger.Multiply(dh, BigInteger.Multiply(jh, BigInteger.Multiply(vr, jr))));

            Console.Write(BigInteger.Add(c1, c2));
        }
    }
}

using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16431
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int bX = Int32.Parse(line.Split(" ")[0]);
            int bY = Int32.Parse(line.Split(" ")[1]);

            line = Console.ReadLine();
            int dX = Int32.Parse(line.Split(" ")[0]);
            int dY = Int32.Parse(line.Split(" ")[1]);

            line = Console.ReadLine();
            int jX = Int32.Parse(line.Split(" ")[0]);
            int jY = Int32.Parse(line.Split(" ")[1]);

            int b = Math.Max(Math.Abs(jX-bX), Math.Abs(jY-bY));
            int d = Math.Abs(jX-dX) + Math.Abs(jY-dY);

            if (b == d)
                Console.Write("tie");
            else if(b < d)
                Console.Write("bessie");
            else
                Console.Write("daisy");
        }
    }
}

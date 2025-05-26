namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27855
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int H1 = Int32.Parse(line.Split(" ")[0]);
            int B1 = Int32.Parse(line.Split(" ")[1]);
            line = Console.ReadLine()!;
            int H2 = Int32.Parse(line.Split(" ")[0]);
            int B2 = Int32.Parse(line.Split(" ")[1]);

            int P1 = H1 * 3 + B1 * 1;
            int P2 = H2 * 3 + B2 * 1;

            if (P1 == P2)
                Console.Write("NO SCORE");
            else if(P1 > P2)
                Console.Write(1 + " " + (P1 - P2));
            else if(P1 < P2)
                Console.Write(2 + " " + (P2 - P1));
        }
    }
}

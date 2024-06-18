namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_13610
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int X = Int32.Parse(line.Split(" ")[0]);
            int Y = Int32.Parse(line.Split(" ")[1]);

            int count = 1;
            while (true)
            {
                if ((Y - X) * count >= Y) break;
                count++;
            }

            Console.Write(count);
        }
    }
}

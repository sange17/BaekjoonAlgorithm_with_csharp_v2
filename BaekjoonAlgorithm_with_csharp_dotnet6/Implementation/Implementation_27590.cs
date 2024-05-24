namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_27590
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int ds = Int32.Parse(line.Split(" ")[0]);
            int ys = Int32.Parse(line.Split(" ")[1]);
            line = Console.ReadLine();
            int dm = Int32.Parse(line.Split(" ")[0]);
            int ym = Int32.Parse(line.Split(" ")[1]);

            int s = ys - ds;
            int m = ym - dm;

            while (s != m)
            {
                if (s < m) s += ys;
                else m += ym;
            }

            Console.WriteLine(s);
        }
    }
}

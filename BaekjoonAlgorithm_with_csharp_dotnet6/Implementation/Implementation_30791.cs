namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30791
    {
        public void solve()
        {
            string line = Console.ReadLine();

            int a = Int32.Parse(line.Split(' ')[0]);
            int b = Int32.Parse(line.Split(' ')[1]);
            int c = Int32.Parse(line.Split(' ')[2]);
            int d = Int32.Parse(line.Split(' ')[3]);
            int e = Int32.Parse(line.Split(' ')[4]);

            int count = 0;
            if (a - 1000 <= b) count++;
            if (a - 1000 <= c) count++;
            if (a - 1000 <= d) count++;
            if (a - 1000 <= e) count++;

            Console.WriteLine(count);
        }
    }
}

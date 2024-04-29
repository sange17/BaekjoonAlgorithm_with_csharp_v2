namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24365
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            int c = Int32.Parse(line.Split(" ")[2]);
            int k = (a + b + c) / 3;

            Console.Write((k - a)+(k-(b-(k-a))));
        }
    }
}

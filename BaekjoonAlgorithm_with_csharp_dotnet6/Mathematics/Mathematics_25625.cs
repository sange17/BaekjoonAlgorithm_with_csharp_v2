namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25625
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int x = Int32.Parse(line.Split(" ")[0]);
            int y = Int32.Parse(line.Split(" ")[1]);

            if(x > y) Console.Write(x + y);
            else Console.Write(y - x);
        }
    }
}

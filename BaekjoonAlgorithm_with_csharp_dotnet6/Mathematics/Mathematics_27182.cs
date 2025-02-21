namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27182
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int m = Int32.Parse(line.Split(" ")[1]);

            if(n > 7) Console.Write(n - 7);
            else Console.Write(m + 7);
        }
    }
}

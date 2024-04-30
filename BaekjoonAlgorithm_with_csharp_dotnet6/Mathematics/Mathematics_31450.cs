namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31450
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int M = Int32.Parse(line.Split(" ")[0]);
            int K = Int32.Parse(line.Split(" ")[1]);

            if(M % K == 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

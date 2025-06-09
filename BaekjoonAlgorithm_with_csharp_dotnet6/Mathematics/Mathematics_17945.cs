namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    internal class Mathematics_17945
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int A = Int32.Parse(line.Split(" ")[0]);
            int B = Int32.Parse(line.Split(" ")[1]);

            for (int x = -1000; x <= 1000; x++)
            {
                if(x * (x + (2 * A)) + B == 0) Console.Write(x + " ");
            }
        }
    }
}

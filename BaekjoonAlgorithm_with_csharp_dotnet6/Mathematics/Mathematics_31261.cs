namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31261
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            Console.Write((((a + b) * a) + a) * a);
        }
    }
}

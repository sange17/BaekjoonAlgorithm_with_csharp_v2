namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25784
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            int c = Int32.Parse(line.Split(" ")[2]);

            if (a + b == c || a + c == b || b + c == a) Console.Write(1);
            else if (a * b == c || a * c == b || b * c == a) Console.Write(2);
            else Console.Write(3);
        }
    }
}

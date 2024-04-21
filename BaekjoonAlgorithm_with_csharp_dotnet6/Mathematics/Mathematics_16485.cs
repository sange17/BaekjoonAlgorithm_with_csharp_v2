namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16485
    {
        public void solve()
        {
            string line = Console.ReadLine();
            double a = Double.Parse(line.Split(" ")[0]);
            double b = Double.Parse(line.Split(" ")[1]);

            if(a % b == 0) Console.WriteLine((int)(a / b));
            else Console.WriteLine(a / b);
        }
    }
}

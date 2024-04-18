namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_20215
    {
        public void solve()
        {
            string line = Console.ReadLine();
            double a = Double.Parse(line.Split(" ")[0]);
            double b = Double.Parse(line.Split(" ")[1]);
            Console.Write(a + b - Math.Pow((a * a + b * b), 0.5));
        }
    }
}

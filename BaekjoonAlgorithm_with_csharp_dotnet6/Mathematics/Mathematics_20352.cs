namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_20352
    {
        public void solve()
        {
            double a = Double.Parse(Console.ReadLine());
            double r = Math.Sqrt(a / Math.PI);
            Console.Write(2 * Math.PI * r);
        }
    }
}

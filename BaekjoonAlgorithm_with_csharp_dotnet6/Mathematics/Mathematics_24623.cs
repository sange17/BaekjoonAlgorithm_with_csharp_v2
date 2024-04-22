namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24623
    {
        public void solve()
        {
            double n = Double.Parse(Console.ReadLine());
            double a = Double.Parse(Console.ReadLine());

            Console.Write((int)Math.Round(((180 - a) / 2 + a / 2)));
        }
    }
}

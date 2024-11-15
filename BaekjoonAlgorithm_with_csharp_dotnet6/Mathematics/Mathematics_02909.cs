namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02909
    {
        public void solve()
        {
            double[] array = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();

            Console.Write(Math.Round(array[0] / Math.Pow(10, array[1]), MidpointRounding.AwayFromZero) * Math.Pow(10, array[1]));
        }
    }
}

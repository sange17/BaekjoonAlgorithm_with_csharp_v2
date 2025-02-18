namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_26532
    {
        public void solve()
        {
            var input = Console.ReadLine()?.Split();

            var width = int.Parse(input![0]);
            var length = int.Parse(input![1]);

            var sqYard = width * length;

            var acreToYard = 4840.0;
            var cntCorn = 5.0;

            var acres = (double)sqYard / acreToYard;
            var bags = (int)Math.Ceiling(acres / cntCorn);

            Console.Write($"{bags}");
        }
    }
}

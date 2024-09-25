namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_08932
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                double[] array = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();
                sum += Math.Floor((9.23076  * Math.Pow((26.7 - array[0]), 1.835)));  //100미터 허들
                sum += Math.Floor((1.84523  * Math.Pow((array[1] - 75), 1.348)));  //높이뛰기
                sum += Math.Floor((56.0211  * Math.Pow((array[2] - 1.5), 1.05)));  //포환던지기
                sum += Math.Floor((4.99087  * Math.Pow((42.5 - array[3]), 1.81)));  //200미터 달리기
                sum += Math.Floor((0.188807 * Math.Pow((array[4] - 210), 1.41))); //멀리뛰기
                sum += Math.Floor((15.9803  * Math.Pow((array[5] - 3.8), 1.04)));  //창던지기
                sum += Math.Floor((0.11193  * Math.Pow((254 - array[6]), 1.88)));  //800미터 달리기
                Console.WriteLine(Math.Round(sum));
            }
        }
    }
}

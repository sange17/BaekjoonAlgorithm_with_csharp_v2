namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03602
    {
        public void solve()
        {
            int[] inputArr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int min = Math.Min(inputArr[0], inputArr[1]);
            int max = Math.Max(inputArr[0], inputArr[1]);
            
            if(min == 0) Console.Write("Impossible");
            else
            {
                if (min == max)
                    Console.Write(Math.Floor(Math.Pow(min * 2, 0.5)));
                else
                    Console.Write(Math.Floor(Math.Pow(min * 2 + 1, 0.5)));
            }
        }
    }
}

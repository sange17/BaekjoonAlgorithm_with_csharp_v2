namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05235
    {
        public void solve()
        {
            var T = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                var array = Console.ReadLine()!.Split(' ');
                var n = int.Parse(array[0]);
                var oddSum = 0;
                var evenSum = 0;

                for (int j = 0; j < n; j++)
                {
                    if (int.Parse(array[j + 1]) % 2 == 0)
                        evenSum += int.Parse(array[j + 1]);
                    else
                        oddSum += int.Parse(array[j + 1]);
                }

                if (oddSum > evenSum)
                    Console.WriteLine("ODD");
                else if (evenSum > oddSum)
                    Console.WriteLine("EVEN");
                else
                    Console.WriteLine("TIE");
            }
        }
    }
}

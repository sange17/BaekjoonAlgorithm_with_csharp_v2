namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11874
    {
        public void solve()
        {
            var l = int.Parse(Console.ReadLine()!);
            var d = int.Parse(Console.ReadLine()!);
            var x = int.Parse(Console.ReadLine()!);

            Func<int, int> SumDigits = (num) => {
                int ret = 0;
                while (true)
                {
                    if (num == 0) break;

                    ret += num % 10;
                    num /= 10;
                }

                return ret;
            };

            Func<int, bool> isSameToX = (i) => SumDigits(i) == x;

            for (int i = l; i <= d; i++)
            {
                if (isSameToX(i))
                {
                    Console.WriteLine(i); break;
                }
            }

            for (int i = d; i >= l; i--)
            {
                if (isSameToX(i))
                {
                    Console.WriteLine(i); break;
                }
            }
        }
    }
}

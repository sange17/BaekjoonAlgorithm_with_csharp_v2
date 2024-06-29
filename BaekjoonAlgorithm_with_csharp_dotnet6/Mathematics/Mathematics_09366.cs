namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09366
    {
        public void solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                // null 체크하지 않아서 많이 틀린 문제
                string? line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    int[] lines = Array.ConvertAll(line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

                    Array.Sort(lines);

                    int a = lines[0];
                    int b = lines[1];
                    int c = lines[2];

                    if (a + b <= c)
                    {
                        Console.WriteLine("Case #" + i + ": invalid!");
                    }
                    else if ((a == b) && (a == c))
                    {
                        Console.WriteLine("Case #" + i + ": equilateral");
                    }
                    else if ((a == b) || (a == c) || (b == c))
                    {
                        Console.WriteLine("Case #" + i + ": isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Case #" + i + ": scalene");
                    }
                }
            }
        }
    }
}

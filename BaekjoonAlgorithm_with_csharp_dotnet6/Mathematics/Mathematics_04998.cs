namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04998
    {
        public void solve()
        {
            while (true)
            {
                string line = Console.ReadLine()!;
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                double[] array = line.Split(" ").Select(double.Parse).ToArray();
                double money = array[0];
                int years = 0;

                while (true)
                {
                    years++;
                    money += (money * (array[1] / 100));

                    if (money >= array[2])
                    {
                        Console.WriteLine(years);
                        years = 0;
                        break;
                    }
                }
            }
        }
    }
}

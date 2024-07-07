namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_23348
    {
        public void solve()
        {
            string[] array = Console.ReadLine()!.Split(" ");
            int n = Int32.Parse(Console.ReadLine()!);

            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    string[] points = Console.ReadLine()!.Split(" ");
                    sum += (Int32.Parse(points[0]) * Int32.Parse(array[0]) 
                          + Int32.Parse(points[1]) * Int32.Parse(array[1])
                          + Int32.Parse(points[2]) * Int32.Parse(array[2]));
                }

                if(max < sum) { max = sum; }
            }

            Console.Write(max);
        }
    }
}

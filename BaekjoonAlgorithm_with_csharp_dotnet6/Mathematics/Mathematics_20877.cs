namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_20877
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int pars = 0;
            int strokes = 0;
            for (int i = 1; i <= array.Length; i++)
            {
                if (i % 2 == 0) pars += 3;
                else pars += 2;

                if (array[i - 1] < 8) 
                    strokes += array[i - 1];
                else 
                    strokes += 7;
            }

            Console.Write(strokes - pars);
        }
    }
}

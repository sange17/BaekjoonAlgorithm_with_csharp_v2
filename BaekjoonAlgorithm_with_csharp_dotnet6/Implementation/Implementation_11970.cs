namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_11970
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            line = Console.ReadLine()!;
            int c = Int32.Parse(line.Split(" ")[0]);
            int d = Int32.Parse(line.Split(" ")[1 ]);

            bool[] array = new bool[101];
            for (int i = 0; i < array.Length; i++)
            {
                if (i > a && i <= b) array[i] = true;
                if (i > c && i <= d) array[i] = true;
            }

            Console.Write(array.Where(x => x == true).Count());
        }
    }
}

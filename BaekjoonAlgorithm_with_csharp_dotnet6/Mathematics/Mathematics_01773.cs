namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01773
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            bool[] array = new bool[inputs[1] + 1];

            for (int i = 0; i < inputs[0]; i++)
            {
                int C = Int32.Parse(Console.ReadLine()!);

                for (int j = C; j < inputs[1] + 1; j += C)
                {
                    array[j] = true;
                }
            }

            Console.Write(array.Where(x => x == true).Count());
        }
    }
}

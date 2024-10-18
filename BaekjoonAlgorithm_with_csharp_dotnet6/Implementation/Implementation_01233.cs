namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01233
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] array = new int[81];

            int max = 0;
            for (int i = 1; i <= inputs[0]; i++)
            {
                for (int j = 1; j <= inputs[1]; j++)
                {
                    for (int k = 1; k <= inputs[2]; k++)
                    {
                        array[i + j + k]++;
                        if(max < array[i + j + k])
                            max = array[i + j + k];
                    }
                }
            }

            for (int i = 3; i < array.Length; i++)
            {
                if (array[i] == max)
                { 
                    Console.Write(i);
                    break;
                }
            }
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01592
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] students = new int[array[0] + 1];

            int result = 0;
            int index = 1;
            while (true)
            {
                students[index]++;

                if (students.Contains(array[1]))
                {
                    Console.Write(result);
                    break;
                }

                if (students[index] % 2 == 0)
                {
                    if (index - array[2] < 1)
                    {
                        index = index - array[2] + array[0];
                    }
                    else
                    {
                        index -= array[2];
                    }
                }
                else
                {
                    if (index + array[2] > array[0])
                    {
                        index = index + array[2] - array[0];
                    }
                    else
                    {
                        index += array[2];
                    }
                }

                result++;
            }
        }
    }
}

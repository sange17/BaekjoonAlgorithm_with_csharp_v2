namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05778
    {
        public void solve()
        {
            while (true)
            {
                string line = Console.ReadLine()!;

                if (line == "0 0")
                {
                    break;
                }

                int N = Convert.ToInt32(line.Split(' ')[0]);
                int M = Convert.ToInt32(line.Split(' ')[1]);
                string line2 = Console.ReadLine()!;

                if (M == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    string[] array = line2.Split(' ');
                    int[] ints = new int[array.Length];

                    for (int i = 0; i < array.Length; i++)
                        ints[i] = 0;

                    for (int i = 0; i < array.Length; i++)
                        ints[Convert.ToInt32(array[i]) - 1]++;

                    int count = 0;
                    for (int i = 0; i < array.Length; i++)
                        if (ints[i] > 1) count++;


                    Console.WriteLine(count);
                }
            }
        }
    }
}

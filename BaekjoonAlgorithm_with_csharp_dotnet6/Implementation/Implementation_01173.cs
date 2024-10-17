namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01173
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int time = 0;
            int pulse = array[1];
            if (array[1] + array[3] > array[2])
            {
                Console.Write(-1);
            }
            else
            {
                while (true)
                {
                    if (array[0] == 0)
                    {
                        Console.Write(time);
                        break;
                    }

                    if (pulse + array[3] <= array[2])
                    {
                        time++;
                        array[0]--;
                        pulse += array[3];
                    }
                    else
                    {
                        if (pulse - array[4] < array[1])
                        {
                            pulse = array[1];
                        }
                        else
                        {
                            pulse -= array[4];
                        }
                        time++;
                    }
                }
            }
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04592
    {
        public void solve()
        {
            while (true)
            {
                string line = Console.ReadLine()!;

                if (line == "0") break;

                line = line.Substring(2);
                if (line.Length == 1)
                {
                    Console.Write(line + " $");
                }
                else
                {
                    int[] array = line.Split(" ").Select(int.Parse).ToArray();

                    int last = array[0];
                    Console.Write(array[0] + " ");

                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] == last)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(array[i] + " ");
                            last = array[i];
                        }
                    }

                    Console.WriteLine("$");
                }
            }
        }
    }
}

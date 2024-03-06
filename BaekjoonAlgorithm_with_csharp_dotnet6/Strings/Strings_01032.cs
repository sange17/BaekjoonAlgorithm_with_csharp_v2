namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01032
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] array = line.ToCharArray();
            if (N == 1)
            {
                Console.Write(line);
            }
            else
            {
                for (int i = 1; i < N; i++)
                {
                    line = Console.ReadLine();
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] != line[j])
                        {
                            array[j] = '?';
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}

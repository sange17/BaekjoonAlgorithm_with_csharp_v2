namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    internal class Implementation_04636
    {
        public void solve()
        {
            while (true)
            {
                int n = Int32.Parse(Console.ReadLine()!);
                if (n == -1) break;

                int min = int.MaxValue;
                int max = int.MinValue;
                string minName = string.Empty;
                string maxName = string.Empty;
                for (int i = 0; i < n; i++)
                {
                    string[] array = Console.ReadLine()!.Split(" ");
                    int x = int.Parse(array[0]);
                    int y = int.Parse(array[1]);
                    int z = int.Parse(array[2]);
                    string name = array[3];

                    if (max < x * y * z)
                    {
                        max = x * y * z;
                        maxName = name;
                    }
                    if (min > x * y * z)
                    {
                        min = x * y * z;
                        minName = name;
                    }
                }

                Console.WriteLine(maxName + " took clay from " + minName + ".");
            }
        }
    }
}

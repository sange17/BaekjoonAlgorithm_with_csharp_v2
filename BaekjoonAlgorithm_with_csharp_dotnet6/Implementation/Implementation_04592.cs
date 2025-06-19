namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04592
    {
        public void solve()
        {
            while (true)
            {
                string line = Console.ReadLine()!;

                string[] array = line.Split(' ');
                int n = int.Parse(array[0]);

                if (line == "0")
                    break;

                var prev = -1;

                for (int i = 1; i < array.Length; i++)
                {
                    var num = int.Parse(array[i]);
                    if (num != prev)
                    {
                        Console.Write(num + " ");
                        prev = num;
                    }
                }

                Console.WriteLine("$");
            }
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_09443
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            char c = 'A';
            int count = 0;

            string[] array = new string[n];
            for (int i = 0; i < n; i++)
                array[i] = Console.ReadLine()!;
            Array.Sort(array);

            for (int i = 0; i < n; i++)
            {
                if (array[i][0] == c)
                {
                    c = (char)(c + 1);
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

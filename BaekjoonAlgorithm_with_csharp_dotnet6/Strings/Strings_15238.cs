namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_15238
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            int[] array = new int[26];
            for (int i = 0; i < n; i++)
                array[line[i] - 97]++;

            int maxIndex = 0;
            int max = 0;
            for (int i = 0; i < 26; i++)
            {
                if (max < array[i])
                {
                    maxIndex = i;
                    max = array[i];
                }
            }

            Console.Write((char)(97 + maxIndex) + " " + max);
        }
    }
}

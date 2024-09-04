namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_25277
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string[] array = Console.ReadLine()!.Split(' ');

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == "he" || array[i] == "she" || array[i] == "him" || array[i] == "her")
                    count++;
            }

            Console.Write(count);
        }
    }
}

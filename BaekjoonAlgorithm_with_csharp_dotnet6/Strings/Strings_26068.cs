namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26068
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine()!;
                if (Convert.ToInt32(line.Split("-")[1]) <= 90)
                    count++;
            }

            Console.Write(count);
        }
    }
}

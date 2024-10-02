namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_08387
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string line1 = Console.ReadLine()!;
            string line2 = Console.ReadLine()!;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (line1[i] == line2[i]) count++;
            }

            Console.Write(count);
        }
    }
}

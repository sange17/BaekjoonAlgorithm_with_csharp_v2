namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_28808
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int m = Int32.Parse(line.Split(" ")[1]);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!;
                if(line.Contains('+')) count++;
            }

            Console.Write(count);
        }
    }
}

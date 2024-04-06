namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_11121
    {
        static int t = 0;
        static string a, b;
        static string isOk()
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return "ERROR";
            }
            return "OK";
        }

        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine());
            while(t > 0)
            {
                string line = Console.ReadLine();
                a = line.Split(" ")[0];
                b = line.Split(" ")[1];

                Console.WriteLine(isOk());
                t--;
            }
        }
    }
}

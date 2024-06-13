namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_08371
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (str1[i] != str2[i])
                    count++;
            }

            Console.Write(count);
        }
    }
}

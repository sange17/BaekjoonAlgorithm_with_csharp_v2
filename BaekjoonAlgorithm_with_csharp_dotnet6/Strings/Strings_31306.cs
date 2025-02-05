namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31306
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int cnt1 = 0;
            int ycnt2 = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u')
                    cnt1++;
                else if (line[i] == 'y')
                    ycnt2++;
            }

            Console.Write(cnt1 + " " + (cnt1 + ycnt2));
        }
    }
}

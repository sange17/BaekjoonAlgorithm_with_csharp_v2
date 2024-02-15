namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_02941
    {
        public void solve()
        {
            string line = Console.ReadLine();
            string[] str = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            for(int i = 0; i < str.Length; i++)
            {
                if (line.Contains(str[i]))
                {
                    line = line.Replace(str[i], "!");
                }
            }

            Console.Write(line.Length);
        }
    }
}

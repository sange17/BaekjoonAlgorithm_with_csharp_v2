namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01120
    {
        public void solve()
        {
            string line = Console.ReadLine();
            string strA = line.Split(" ")[0];
            string strB = line.Split(" ")[1];

            int min = 50;
            int cnt = 0;
            for(int i = 0; i <= strB.Length - strA.Length; i++)
            {
                cnt = 0;
                for(int j = 0; j < strA.Length; j++)
                {
                    if (strA[j] != strB[i + j])
                    {
                        cnt++;
                    }
                }

                if (cnt < min) min = cnt;

                if (min == 0)
                {
                    Console.Write(min);
                    return;
                }
            }
            Console.Write(min);
        }
    }
}

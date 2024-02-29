namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_11328
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());
            string line = string.Empty;

            char[] charsA;
            char[] charsB;
            for(int i = 0; i < N; i++)
            {
                line = sr.ReadLine();

                charsA = line.Split(' ')[0].ToCharArray();
                charsB = line.Split(' ')[1].ToCharArray();

                if(charsA.Length != charsB.Length)
                {
                    sw.WriteLine("Impossible");
                }
                else
                {
                    Array.Sort(charsA);
                    Array.Sort(charsB);
                    int cnt = 0;
                    for(int j = 0; j < charsA.Length; j++)
                    {
                        if (charsA[j].Equals(charsB[j]))
                        {
                            cnt++;
                        }
                        else
                        {
                            sw.WriteLine("Impossible");
                            break;
                        }
                    }

                    if(cnt == charsA.Length) sw.WriteLine("Possible");
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}

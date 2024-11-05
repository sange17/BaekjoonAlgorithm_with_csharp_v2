namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04581
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int yCnt = 0;
                int nCnt = 0;
                int pCnt = 0;
                int aCnt = 0;
                double count = 0;
                string line = sr.ReadLine()!;

                if (line == "#")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                count = line.Length;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'Y') yCnt++;
                    else if (line[i] == 'N') nCnt++;
                    else if (line[i] == 'P') pCnt++;
                    else if (line[i] == 'A') aCnt++;
                }

                //아무도 투표를 하지 않았을 때
                if (count == pCnt)
                {
                    sw.WriteLine("tie");
                }
                //정족수
                else if (count / 2.0 <= aCnt)
                {
                    sw.WriteLine("need quorum");
                }
                //찬성이 많을 때
                else if (yCnt > nCnt)
                {
                    sw.WriteLine("yes");
                }
                //반대가 많을 때
                else if (yCnt < nCnt)
                {
                    sw.WriteLine("no");
                }
                //찬반이 같을 때
                else if (yCnt == nCnt)
                {
                    sw.WriteLine("tie");
                }
            }
        }
    }
}

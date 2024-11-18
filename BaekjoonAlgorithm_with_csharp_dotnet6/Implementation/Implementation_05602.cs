namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05602
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] nmArray = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] people = new int[nmArray[1]];
            int[] voteArray = new int[nmArray[1]];

            //학생 별 여행 후보지 투표 수를 rank배열에 담는 과정
            for (int i = 0; i < nmArray[0]; i++)
            {
                people = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < nmArray[1]; j++)
                {
                    if (people[j] == 1) voteArray[j]++;
                }
            }

            //순위 정하기
            while (true)
            {
                //모든 순위가 -1이면 끝
                if (voteArray.Max() == -1)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }
                else
                {
                    for (int i = 0; i < nmArray[1]; i++)
                    {
                        if (voteArray[i] == voteArray.Max())
                        {
                            sw.Write((i + 1) + " ");
                            voteArray[i] = -1;      //순위가 정해지면 -1
                            break;
                        }
                    }
                }
            }
        }
    }
}

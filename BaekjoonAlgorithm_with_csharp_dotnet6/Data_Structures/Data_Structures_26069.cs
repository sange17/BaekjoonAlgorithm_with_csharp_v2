using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_26069
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string userA = string.Empty;
            string userB = string.Empty;

            HashSet<string> enterUser = new HashSet<string>();
            enterUser.Add("ChongChong");

            int N = Int32.Parse(sr.ReadLine());

            string line = string.Empty;
            for(int i = 0; i < N; i++)
            {
                line = sr.ReadLine();
                userA = line.Split(' ')[0];
                userB = line.Split(' ')[1];

                if(enterUser.Contains(userA) || enterUser.Contains(userB))
                {
                    enterUser.Add(userA);
                    enterUser.Add(userB);
                }
            }

            sw.WriteLine(enterUser.Count);

            sr.Close();
            sw.Close();
        }
    }
}

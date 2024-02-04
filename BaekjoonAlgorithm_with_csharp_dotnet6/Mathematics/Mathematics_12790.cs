using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_12790
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            string line = string.Empty;
            int HP = 0;
            int MP = 0;
            int ATK = 0;
            int DEF = 0;
            int wHP = 0;
            int wMP = 0;
            int wATK = 0;
            int wDEF = 0;
            int CP = 0;
            for(int i = 0; i < N; i++)
            {
                line = sr.ReadLine();

                HP = int.Parse(line.Split(" ")[0]);
                MP = int.Parse(line.Split(" ")[1]);
                ATK = int.Parse(line.Split(" ")[2]);
                DEF = int.Parse(line.Split(" ")[3]);
                wHP = int.Parse(line.Split(" ")[4]);
                wMP = int.Parse(line.Split(" ")[5]);
                wATK = int.Parse(line.Split(" ")[6]);
                wDEF = int.Parse(line.Split(" ")[7]);

                CP += (((HP + wHP) < 1 ? 1 : (HP + wHP)) * 1);
                CP += (((MP + wMP) < 1 ? 1 : (MP + wMP)) * 5);
                CP += (((ATK + wATK) < 0 ? 0 : (ATK + wATK)) * 2);
                CP += ((DEF + wDEF) * 2);

                sw.WriteLine(CP);
                CP = 0;
            }

            sr.Close();
            sw.Close();
        }
    }
}

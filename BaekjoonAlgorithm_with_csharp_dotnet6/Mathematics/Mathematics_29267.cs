namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_29267
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int n = Int32.Parse(line.Split(" ")[0]);
            int k = Int32.Parse(line.Split(" ")[1]);

            int cnt = 0;
            int save = 0;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                line = sr.ReadLine();

                if(line == "save")
                {
                    save = cnt;
                    sw.WriteLine(save);
                    flag = true;
                }

                if (line == "load")
                {
                    if(flag)
                    {
                        cnt = save;
                    }
                    else
                    {
                        cnt = 0;
                    }
                    sw.WriteLine(cnt);
                }

                if (line == "shoot")
                {
                    cnt -= 1;
                    sw.WriteLine(cnt);
                }

                if (line == "ammo")
                {
                    cnt += k;
                    sw.WriteLine(cnt);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}

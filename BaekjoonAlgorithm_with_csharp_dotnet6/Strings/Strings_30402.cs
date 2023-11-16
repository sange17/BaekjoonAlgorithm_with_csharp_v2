using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_30402
    {
        public void solve()
        {
            string[] line = new string[15];
            string result = string.Empty;
            bool check = false;

            for(int i = 0; i < 15; i++)
            {
                line = Console.ReadLine().Split(' ');

                for(int j = 0; j < 15; j++)
                {
                    if (line[j].Equals("w"))
                    {
                        result = "chunbae";
                        check = true;
                        break;
                    }
                    if (line[j].Equals("b"))
                    {
                        result = "nabi";
                        check = true;
                        break;
                    }
                    if (line[j].Equals("g"))
                    {
                        result = "yeongcheol";
                        check = true;
                        break;
                    }
                }

                if(check)
                {
                    Console.Write(result);
                    break;
                }
            }
        }
    }
}

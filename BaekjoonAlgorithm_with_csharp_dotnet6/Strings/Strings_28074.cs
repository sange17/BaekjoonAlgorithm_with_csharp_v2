using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_28074
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int lineLength = line.Length;
            bool M = false;
            bool O = false;
            bool B = false;
            bool I = false;
            bool S = false;
            string result = "NO";
            for(int i = 0; i < lineLength; i++)
            {
                if (line[i] == 'M')
                    M = true;

                if (line[i] == 'O')
                    O = true;

                if (line[i] == 'B')
                    B = true;

                if (line[i] == 'I')
                    I = true;

                if (line[i] == 'S')
                    S = true;

                if (M && O && B && I && S)
                {
                    result = "YES";
                    break;
                }
            }

            Console.Write(result);
        }
    }
}

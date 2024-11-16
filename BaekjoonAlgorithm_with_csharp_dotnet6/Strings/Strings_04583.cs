namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_04583
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;
                if(line == "#")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }
                
                bool check = false;
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != 'b'
                    && line[i] != 'd'
                    && line[i] != 'p'
                    && line[i] != 'q'
                    && line[i] != 'i'
                    && line[i] != 'o'
                    && line[i] != 'v'
                    && line[i] != 'w'
                    && line[i] != 'x')
                    {
                        check = true;
                        break;
                    }
                }

                if (check) sw.WriteLine("INVALID");
                else
                {
                    string reverse = new string(line.Reverse().ToArray());

                    for (int i = 0; i < reverse.Length; i++)
                    {
                        if (reverse[i] == 'b') sw.Write('d');
                        else if (reverse[i] == 'd') sw.Write('b');
                        else if (reverse[i] == 'p') sw.Write('q');
                        else if (reverse[i] == 'q') sw.Write('p');
                        else if (reverse[i] == 'i') sw.Write('i');
                        else if (reverse[i] == 'o') sw.Write('o');
                        else if (reverse[i] == 'v') sw.Write('v');
                        else if (reverse[i] == 'w') sw.Write('w');
                        else if (reverse[i] == 'x') sw.Write('x');
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}

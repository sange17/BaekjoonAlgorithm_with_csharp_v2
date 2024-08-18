namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05751
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int n = Int32.Parse(sr.ReadLine()!);

                if (n == 0)
                {
                    sr.Close();
                    sw.Close();
                    return;
                }

                string[] array = sr.ReadLine()!.Split(" ");

                int x = 0; 
                int y = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == "0")
                        x++;
                    else 
                        y++;
                }

                sw.WriteLine("Mary won " + x + " times and John won " + y + " times");
            }
        }
    }
}

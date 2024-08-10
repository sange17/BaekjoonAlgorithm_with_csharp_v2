namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    internal class Strings_08815
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int z = Int32.Parse(sr.ReadLine()!);

            string line = "BCBCDCDADABA";

            int input = 0;
            int index = 0;
            for (int i = 0; i < z; i++)
            {
                input = Int32.Parse(sr.ReadLine()!);
                input--;

                if (input == 0)
                    sw.WriteLine("A");
                else
                {
                    if (input % 12 == 0) index = 12;
                    else index = input % 12;

                    sw.WriteLine(line[index - 1]);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}

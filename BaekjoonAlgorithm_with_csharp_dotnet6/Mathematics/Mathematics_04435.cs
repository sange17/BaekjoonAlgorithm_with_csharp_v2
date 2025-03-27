namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04435
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            int[] gandalfArray = { 1, 2, 3, 3, 4, 10 };
            int[] sauronArray = { 1, 2, 2, 2, 3, 5, 10 };

            for (int i = 1; i <= n; i++)
            {
                int[] gandalfScoreArray = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int gandalfScore = 0;
                
                int[] sauronScoreArray = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int sauronScore = 0;

                for(int j = 0; j < gandalfArray.Length; j++)
                    gandalfScore += (gandalfArray[j] * gandalfScoreArray[j]);

                for (int j = 0; j < sauronArray.Length; j++)
                    sauronScore += (sauronArray[j] * sauronScoreArray[j]);

                sw.Write("Battle " + i + ": ");
                if (gandalfScore > sauronScore)
                    sw.WriteLine("Good triumphs over Evil");
                else if(gandalfScore < sauronScore)
                    sw.WriteLine("Evil eradicates all trace of Good");
                else
                    sw.WriteLine("No victor on this battle field");
            }

            sr.Close();
            sw.Close();
        }
    }
}

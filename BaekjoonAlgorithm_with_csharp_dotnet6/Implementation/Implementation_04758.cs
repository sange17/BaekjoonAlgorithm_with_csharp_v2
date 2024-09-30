namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04758
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                double[] array = sr.ReadLine()!.Split(" ").Select(double.Parse).ToArray();
                bool a1 = false;
                bool a2 = false; 
                bool a3 = false;

                if (array[0] == 0 && array[1] == 0 && array[2] == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                if (array[0] <= 4.5 && array[1] >= 150 && array[2] >= 200)
                {
                    sw.Write("Wide Receiver ");
                    a1 = true;
                }
                
                if (array[0] <= 6.0 && array[1] >= 300 && array[2] >= 500)
                {
                    sw.Write("Lineman ");
                    a2 = true;
                }
                
                if (array[0] <= 5.0 && array[1] >= 200 && array[2] >= 300)
                {
                    sw.Write("Quarterback ");
                    a3 = true;
                }
                
                if(!a1 && !a2 && !a3)
                {
                    sw.Write("No positions ");
                }

                sw.WriteLine();
            }
        }
    }
}

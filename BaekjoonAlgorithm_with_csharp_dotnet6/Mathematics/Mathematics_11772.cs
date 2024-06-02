namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11772
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                double num = double.Parse(line.Substring(0, line.Length - 1));
                double pot = double.Parse(line.Substring(line.Length - 1));

                if (pot == 0)
                    sum += 1;
                else
                    sum += Math.Pow(num, pot);
            }

            Console.Write(sum);
        }
    }
}

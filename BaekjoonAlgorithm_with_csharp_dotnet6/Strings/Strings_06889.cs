namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_06889
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());

            string[] arr1 = new string[n];
            string[] arr2 = new string[m];

            for (int i = 0; i < n; i++)
                arr1[i] = Console.ReadLine();

            for (int i = 0; i < m; i++)
                arr2[i] = Console.ReadLine();
                    
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    sw.WriteLine(arr1[i] + " as " + arr2[j]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
